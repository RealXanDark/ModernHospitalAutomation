using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using HospitalAutomation;
using HospitalAutomation.Models;
using HospitalAutomation.Web.Services;
using HospitalAutomation.Web.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace HospitalAutomation.Web.Controllers;

public class AccountController : Controller
{
    private readonly DbHanHospitalContext _context;
    private readonly RegistrationService _registrationService;
    private readonly ILogger<AccountController> _logger;

    public AccountController(DbHanHospitalContext context, RegistrationService registrationService, ILogger<AccountController> logger)
    {
        _context = context;
        _registrationService = registrationService;
        _logger = logger;
    }

    [HttpGet]
    [AllowAnonymous]
    public async Task<IActionResult> Index(string? returnUrl = null, string activePanel = "login")
    {
        var model = new LoginRegisterViewModel
        {
            Login = new LoginInputModel { ReturnUrl = NormalizeReturnUrl(returnUrl) },
            Register = new RegisterInputModel(),
            BloodGroups = await GetBloodGroupSelectListAsync(),
            ActivePanel = activePanel,
        };

        return View(model);
    }

    [HttpPost]
    [AllowAnonymous]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Login([FromForm] LoginInputModel loginModel)
    {
        var viewModel = await BuildViewModelAsync(loginModel, new RegisterInputModel(), activePanel: "login");

        if (!ModelState.IsValid)
        {
            return View("Index", viewModel);
        }

        try
        {
            var normalizedIdentity = loginModel.IdentityNumber.Trim();
            var encryptedIdentity = Encryption.Encrypt(normalizedIdentity);
            var identity = await _context.TblIdentityNumbers
                .Include(i => i.TblUser)
                .ThenInclude(u => u.Type)
                .FirstOrDefaultAsync(i => i.IdentityNumber == encryptedIdentity && !i.IsDeleted);

            if (identity?.TblUser is null || identity.TblUser.IsDeleted || identity.TblUser.Type is null)
            {
                ModelState.AddModelError(string.Empty, "Kullanıcı adı veya şifre hatalı.");
                return View("Index", viewModel);
            }

            var encryptedPassword = Encryption.Encrypt(loginModel.Password);
            if (!identity.TblUser.Password.SequenceEqual(encryptedPassword))
            {
                ModelState.AddModelError(string.Empty, "Kullanıcı adı veya şifre hatalı.");
                return View("Index", viewModel);
            }

            if (identity.TblUser.TypeId == 3)
            {
                var hasActivePatient = await _context.TblPatients
                    .AnyAsync(p => p.IdentityNumberId == identity.IdentityNumberId && !p.IsDeleted);

                if (!hasActivePatient)
                {
                    ModelState.AddModelError(string.Empty, "Bu hesap pasif durumdadır. Lütfen destek ile iletişime geçin.");
                    return View("Index", viewModel);
                }
            }

            var claims = new List<Claim>
            {
                new(ClaimTypes.NameIdentifier, identity.TblUser.UserId.ToString()),
                new(ClaimTypes.Name, normalizedIdentity),
                new(ClaimTypes.Role, identity.TblUser.Type.UserTypeName),
            };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

            var redirectUrl = loginModel.ReturnUrl ?? Url.Action("Index", "Home")!;
            return LocalRedirect(redirectUrl);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Kullanıcı giriş işlemi sırasında hata oluştu");
            ModelState.AddModelError(string.Empty, "Giriş işlemi sırasında beklenmeyen bir hata oluştu.");
            return View("Index", viewModel);
        }
    }

    [HttpPost]
    [AllowAnonymous]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Register([FromForm] RegisterInputModel registerModel)
    {
        var viewModel = await BuildViewModelAsync(new LoginInputModel(), registerModel, activePanel: "register");

        if (!ModelState.IsValid)
        {
            return View("Index", viewModel);
        }

        var (succeeded, errorMessage) = await _registrationService.RegisterPatientAsync(registerModel);
        if (!succeeded)
        {
            ModelState.AddModelError(string.Empty, errorMessage ?? "Kayıt işlemi tamamlanamadı.");
            return View("Index", viewModel);
        }

        TempData["RegisterSuccess"] = "Kayıt işlemi başarıyla tamamlandı. Şimdi giriş yapabilirsiniz.";
        return RedirectToAction(nameof(Index), new { activePanel = "login" });
    }

    [Authorize]
    public async Task<IActionResult> Logout()
    {
        await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    [AllowAnonymous]
    public IActionResult AccessDenied()
    {
        return View();
    }

    private async Task<LoginRegisterViewModel> BuildViewModelAsync(LoginInputModel loginModel, RegisterInputModel registerModel, string activePanel)
    {
        return new LoginRegisterViewModel
        {
            Login = loginModel,
            Register = registerModel,
            BloodGroups = await GetBloodGroupSelectListAsync(),
            ActivePanel = activePanel,
        };
    }

    private async Task<IEnumerable<SelectListItem>> GetBloodGroupSelectListAsync()
    {
        return await _context.TblBloodGroups
            .OrderBy(bg => bg.BloodGroupName)
            .Select(bg => new SelectListItem
            {
                Text = bg.BloodGroupName,
                Value = bg.BloodGroupId.ToString(),
            })
            .ToListAsync();
    }

    private string? NormalizeReturnUrl(string? returnUrl) =>
        string.IsNullOrWhiteSpace(returnUrl) ? null : (Url.IsLocalUrl(returnUrl) ? returnUrl : null);
}
