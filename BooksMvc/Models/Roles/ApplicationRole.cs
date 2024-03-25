using Microsoft.AspNetCore.Identity;

namespace BooksMvc.Models.Roles
{
    public class ApplicationRole : IdentityRole
    {
        public string? Description { get; set; }
    }
}
