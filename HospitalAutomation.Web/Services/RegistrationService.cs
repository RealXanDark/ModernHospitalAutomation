using System.Diagnostics.CodeAnalysis;
using System.Threading;
using HospitalAutomation;
using HospitalAutomation.Models;
using HospitalAutomation.Web.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace HospitalAutomation.Web.Services;

public class RegistrationService
{
    private readonly DbHanHospitalContext _context;
    private readonly ILogger<RegistrationService> _logger;

    public RegistrationService(DbHanHospitalContext context, ILogger<RegistrationService> logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<(bool Succeeded, string? ErrorMessage)> RegisterPatientAsync(RegisterInputModel model, CancellationToken cancellationToken = default)
    {
        await using var transaction = await _context.Database.BeginTransactionAsync(cancellationToken);

        try
        {
            if (!await TryResolveIdentityAsync(model.IdentityNumber, cancellationToken, out var identityId, out var identityError))
            {
                return (false, identityError);
            }

            if (!await TryResolveEmailAsync(model.Email, cancellationToken, out var emailId, out var emailError))
            {
                return (false, emailError);
            }

            if (!await TryResolvePhoneAsync(model.PhoneNumber, cancellationToken, out var phoneId, out var phoneError))
            {
                return (false, phoneError);
            }

            var encryptedFirstName = Encryption.Encrypt(model.FirstName.ToLower().Trim());
            var encryptedLastName = Encryption.Encrypt(model.LastName.ToLower().Trim());
            var encryptedPassword = Encryption.Encrypt(model.Password);

            var user = new TblUser
            {
                IdentityNumberId = identityId,
                Password = encryptedPassword,
                TypeId = 3,
                IsDeleted = false,
            };

            var patient = new TblPatient
            {
                IdentityNumberId = identityId,
                FirstName = encryptedFirstName,
                LastName = encryptedLastName,
                DateOfBirth = model.DateOfBirth!.Value,
                Gender = model.Gender!.Value,
                BloodGroupId = model.BloodGroupId!.Value,
                EmailId = emailId,
                PhoneNumberId = phoneId,
                IsDeleted = false,
            };

            _context.TblUsers.Add(user);
            _context.TblPatients.Add(patient);

            await _context.SaveChangesAsync(cancellationToken);
            await transaction.CommitAsync(cancellationToken);

            return (true, null);
        }
        catch (Exception ex)
        {
            await transaction.RollbackAsync(cancellationToken);
            _logger.LogError(ex, "Hasta kaydı oluşturulurken hata oluştu");
            return (false, "Kayıt sırasında beklenmeyen bir hata oluştu. Lütfen tekrar deneyin.");
        }
    }

    private async Task<bool> TryResolveIdentityAsync(string identityNumber, CancellationToken cancellationToken, [NotNullWhen(true)] out int identityId, out string? errorMessage)
    {
        var encryptedIdentity = Encryption.Encrypt(identityNumber.Trim());

        var identity = await _context.TblIdentityNumbers
            .FirstOrDefaultAsync(i => i.IdentityNumber == encryptedIdentity, cancellationToken);

        if (identity is not null)
        {
            var hasActivePatient = await _context.TblPatients
                .AnyAsync(p => p.IdentityNumberId == identity.IdentityNumberId && !p.IsDeleted, cancellationToken);
            var hasActiveUser = await _context.TblUsers
                .AnyAsync(u => u.IdentityNumberId == identity.IdentityNumberId && !u.IsDeleted, cancellationToken);

            if (hasActivePatient || hasActiveUser)
            {
                identityId = default;
                errorMessage = "Bu kimlik numarası ile aktif bir hesap zaten mevcut. Lütfen giriş yapmayı deneyin.";
                return false;
            }

            identityId = identity.IdentityNumberId;
            errorMessage = null;
            return true;
        }

        var identityNumberEntity = new TblIdentityNumber
        {
            IdentityNumber = encryptedIdentity,
            IsDeleted = false,
        };

        _context.TblIdentityNumbers.Add(identityNumberEntity);
        await _context.SaveChangesAsync(cancellationToken);

        identityId = identityNumberEntity.IdentityNumberId;
        errorMessage = null;
        return true;
    }

    private async Task<bool> TryResolveEmailAsync(string email, CancellationToken cancellationToken, [NotNullWhen(true)] out int emailId, out string? errorMessage)
    {
        var normalizedEmail = email.Trim().ToLowerInvariant();
        var encryptedEmail = Encryption.Encrypt(normalizedEmail);

        var emailEntity = await _context.TblEmailAddresses
            .FirstOrDefaultAsync(e => e.Email == encryptedEmail, cancellationToken);

        if (emailEntity is not null)
        {
            var isInUse = await _context.TblPatients
                .AnyAsync(p => p.EmailId == emailEntity.EmailId && !p.IsDeleted, cancellationToken);

            if (isInUse)
            {
                emailId = default;
                errorMessage = "Bu e-posta adresi başka bir hesap tarafından kullanılıyor.";
                return false;
            }

            emailId = emailEntity.EmailId;
            errorMessage = null;
            return true;
        }

        var newEmail = new TblEmailAddress
        {
            Email = encryptedEmail,
            IsDeleted = false,
        };

        _context.TblEmailAddresses.Add(newEmail);
        await _context.SaveChangesAsync(cancellationToken);

        emailId = newEmail.EmailId;
        errorMessage = null;
        return true;
    }

    private async Task<bool> TryResolvePhoneAsync(string phoneNumber, CancellationToken cancellationToken, [NotNullWhen(true)] out int phoneId, out string? errorMessage)
    {
        var normalizedPhone = phoneNumber.Trim();
        if (!normalizedPhone.StartsWith("0"))
        {
            normalizedPhone = $"0{normalizedPhone}";
        }

        var encryptedPhone = Encryption.Encrypt(normalizedPhone);

        var phoneEntity = await _context.TblPhoneNumbers
            .FirstOrDefaultAsync(p => p.PhoneNumber == encryptedPhone, cancellationToken);

        if (phoneEntity is not null)
        {
            var isInUse = await _context.TblPatients
                .AnyAsync(p => p.PhoneNumberId == phoneEntity.PhoneNumberId && !p.IsDeleted, cancellationToken);

            if (isInUse)
            {
                phoneId = default;
                errorMessage = "Bu telefon numarası başka bir hesap tarafından kullanılıyor.";
                return false;
            }

            phoneId = phoneEntity.PhoneNumberId;
            errorMessage = null;
            return true;
        }

        var newPhone = new TblPhoneNumber
        {
            PhoneNumber = encryptedPhone,
            IsDeleted = false,
        };

        _context.TblPhoneNumbers.Add(newPhone);
        await _context.SaveChangesAsync(cancellationToken);

        phoneId = newPhone.PhoneNumberId;
        errorMessage = null;
        return true;
    }
}
