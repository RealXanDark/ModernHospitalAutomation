using System.ComponentModel.DataAnnotations;

namespace HospitalAutomation.Web.ViewModels;

public class LoginInputModel
{
    [Required(ErrorMessage = "TC kimlik numarası zorunludur.")]
    [StringLength(11, MinimumLength = 11, ErrorMessage = "TC kimlik numarası 11 haneli olmalıdır.")]
    [RegularExpression(@"^\\d{11}$", ErrorMessage = "TC kimlik numarası yalnızca rakamlardan oluşmalıdır.")]
    [Display(Name = "TC Kimlik No")]
    public string IdentityNumber { get; set; } = string.Empty;

    [Required(ErrorMessage = "Şifre zorunludur.")]
    [MinLength(5, ErrorMessage = "Şifre en az 5 karakter olmalıdır.")]
    [Display(Name = "Şifre")]
    public string Password { get; set; } = string.Empty;

    public string? ReturnUrl { get; set; }
}
