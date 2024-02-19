using System.ComponentModel.DataAnnotations;

namespace BooksMvc.Models.Aunthetication.Login
{
    public class LoginUser
    {
        [Required(ErrorMessage = "User Name is Required")]
        public String? Username { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        public String? Password { get; set; }
    }
}
