using System.ComponentModel.DataAnnotations;

namespace BooksMvc.Models.Aunthetication.SignUp
{
    public class ForgotPasswordModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
