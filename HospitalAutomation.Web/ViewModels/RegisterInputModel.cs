using System.ComponentModel.DataAnnotations;

namespace HospitalAutomation.Web.ViewModels;

public class RegisterInputModel
{
    [Required(ErrorMessage = "TC kimlik numarası zorunludur.")]
    [StringLength(11, MinimumLength = 11, ErrorMessage = "TC kimlik numarası 11 haneli olmalıdır.")]
    [RegularExpression(@"^\\d{11}$", ErrorMessage = "TC kimlik numarası yalnızca rakamlardan oluşmalıdır.")]
    [Display(Name = "TC Kimlik No")]
    public string IdentityNumber { get; set; } = string.Empty;

    [Required(ErrorMessage = "Ad alanı zorunludur.")]
    [Display(Name = "Ad")]
    [StringLength(70, ErrorMessage = "Ad en fazla 70 karakter olabilir.")]
    public string FirstName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Soyad alanı zorunludur.")]
    [Display(Name = "Soyad")]
    [StringLength(70, ErrorMessage = "Soyad en fazla 70 karakter olabilir.")]
    public string LastName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Doğum tarihi zorunludur.")]
    [Display(Name = "Doğum Tarihi")]
    [DataType(DataType.Date)]
    public DateOnly? DateOfBirth { get; set; }

    [Required(ErrorMessage = "Cinsiyet seçimi zorunludur.")]
    [Display(Name = "Cinsiyet")]
    public bool? Gender { get; set; }

    [Required(ErrorMessage = "Kan grubu zorunludur.")]
    [Display(Name = "Kan Grubu")]
    public byte? BloodGroupId { get; set; }

    [Required(ErrorMessage = "E-posta adresi zorunludur.")]
    [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
    [Display(Name = "E-Posta")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Telefon numarası zorunludur.")]
    [Display(Name = "Telefon Numarası")]
    [RegularExpression(@"^0?5\\d{9}$", ErrorMessage = "Telefon numarasını 05XXXXXXXXX formatında giriniz.")]
    public string PhoneNumber { get; set; } = string.Empty;

    [Required(ErrorMessage = "Şifre zorunludur.")]
    [MinLength(5, ErrorMessage = "Şifre en az 5 karakter olmalıdır.")]
    [Display(Name = "Şifre")]
    public string Password { get; set; } = string.Empty;

    [Required(ErrorMessage = "Şifre doğrulaması zorunludur.")]
    [Compare("Password", ErrorMessage = "Şifreler eşleşmiyor.")]
    [Display(Name = "Şifre (Tekrar)")]
    public string ConfirmPassword { get; set; } = string.Empty;
}
