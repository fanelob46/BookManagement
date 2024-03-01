using Microsoft.AspNetCore.Identity;

namespace BooksMvc.Models.Roles
{
    public class ApplicationRole : IdentityRole
    {
        public List<string>? Roles { get; set; }
    }
}
