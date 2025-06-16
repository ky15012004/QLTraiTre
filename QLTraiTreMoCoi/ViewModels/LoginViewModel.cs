using System.ComponentModel.DataAnnotations;

namespace QLTraiTreMoCoi.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "CCCD is required.")]
        public string CCCD { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
