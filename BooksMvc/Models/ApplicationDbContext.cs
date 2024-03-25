using BooksMvc.Models.Roles;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BooksMvc.Models
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
       /* protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedRoles(builder);
        }*/
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        /* private static void SeedRoles(ModelBuilder builder)
        {
             builder.Entity<IdentityRole>().HasData
                 (
                 new IdentityRole() { Name = "Admin", ConcurrencyStamp = "1", NormalizedName = "Admin" },
                 new IdentityRole() { Name = "Manager", ConcurrencyStamp = "2", NormalizedName = "Manager" },
                 new IdentityRole() { Name = "HelpDesk", ConcurrencyStamp = "3", NormalizedName = "HelpDesk" },
                 new IdentityRole() { Name = "user", ConcurrencyStamp = "4", NormalizedName = "user" }
                 );

         }*/

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Category>().HasData(
                
                new Category { Id =1 , Name = "Action"},
                new Category { Id = 2, Name = "Sci-fi"},
                new Category { Id = 3, Name = "History"}
                );
        }


    }
}
