using System.ComponentModel.DataAnnotations;

namespace QLTraiTreMoCoi.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "CCCD is required.")]
        public string CCCD { get; set; }
        [Required(ErrorMessage = "HoTen is required.")]
        public string HoTen { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(40, MinimumLength = 8, ErrorMessage = "The {0} must be at {2} and at max {1} character")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword", ErrorMessage = "Password is not match.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        public string ConfirmPassword { get; set; }
    }
}
