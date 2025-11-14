using Microsoft.AspNetCore.Mvc.Rendering;

namespace HospitalAutomation.Web.ViewModels;

public class LoginRegisterViewModel
{
    public LoginInputModel Login { get; set; } = new();

    public RegisterInputModel Register { get; set; } = new();

    public IEnumerable<SelectListItem> BloodGroups { get; set; } = Enumerable.Empty<SelectListItem>();

    public string ActivePanel { get; set; } = "login";
}
