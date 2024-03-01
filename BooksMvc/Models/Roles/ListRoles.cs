using Microsoft.AspNetCore.Identity;

namespace BooksMvc.Models.Roles
{
    public class ListRoles : IdentityRole
    {
        public List<string>? Roles { get; set; }
    }
}
