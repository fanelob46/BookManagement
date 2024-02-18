using System.ComponentModel.DataAnnotations;

namespace BooksMvc.Models.Aunthetication.SignUp
{
    public class RegisterUser
    {
        [Required(ErrorMessage = "User name Required")]
        public String? UserName { get; set; }

        
        [EmailAddress]
        [Required(ErrorMessage = "Email Adrress Required")]
        public String? Email { get; set; }

        [Required(ErrorMessage = "Password Required")]
        public String? Password { get; set; }
        
        
    }
}
