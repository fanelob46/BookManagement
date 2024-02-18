using Azure.Identity;
using BooksMvc.Models;
using BooksMvc.Models.Aunthetication.SignUp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BooksMvc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuntheticateController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private IConfiguration _configuration;
        public AuntheticateController(UserManager<IdentityUser> userManager, 
            RoleManager<IdentityRole> roleManager, IConfiguration configuration)
        {
            _roleManager = roleManager;

            _configuration = configuration;
            _userManager = userManager;

        }

        [HttpPost]
        public async  Task<IActionResult> Register([FromBody] RegisterUser registerUser , string role)
        {
            //Check if the user exist
            var userExist = await _userManager.FindByEmailAsync(registerUser.Email);
            if (userExist != null)
            {
                return StatusCode(StatusCodes.Status403Forbidden,
                    new Response { Status = "Error", Messange = "User already exists!" });
            }
            //add user to database
            IdentityUser user = new()
            { 
               Email = registerUser.Email,
               SecurityStamp = Guid.NewGuid().ToString(),
               UserName = registerUser.UserName
                
            };
            if(await _roleManager.RoleExistsAsync(role))
            {
                var result = await _userManager.CreateAsync(user,registerUser.Password);
                if (!result.Succeeded)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError,
                        new Response { Status = "Error", Messange = "User fail to create" });
                }
                ///Add role to user
                await _userManager.AddToRoleAsync(user, role);
                return StatusCode(StatusCodes.Status200OK,
                       new Response { Status = "Success", Messange = "User created succesfully" });
            }
            else
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                       new Response { Status = "Error", Messange = "the role doesnt exist" });
            }
        }
    }
}
