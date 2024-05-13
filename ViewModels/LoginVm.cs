using System.ComponentModel.DataAnnotations;

namespace Restuarant.ViewModels
{
    public class LoginVm
    {
        [Required(ErrorMessage = "Username is required.")]
        public string? Username { get; set; }
        [Required(ErrorMessage ="Password is required")]
        public string? Password { get; set; }

        [Display(Name ="Remember Me")]
        public bool RememberMe { get; set; }

    }
}
