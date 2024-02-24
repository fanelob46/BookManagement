using System.ComponentModel.DataAnnotations;

namespace BooksMvc.Models.Aunthetication.SignUp
{
    public class ResetPassword
    {
        [Required]
        public string Password { get; set; } = null!;
        [Compare("Password", ErrorMessage = "Password Dont Match")]
        public string ConfirmPassword { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Token { get; set; } = null!;

    }
}
