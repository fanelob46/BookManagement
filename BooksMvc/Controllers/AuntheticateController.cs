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
            var result = await _userManager.CreateAsync(user, registerUser.Password);
            if (result.Succeeded)
            {
                return StatusCode(StatusCodes.Status201Created,
                   new Response { Status = "Error", Messange = "User Created Successfully!" });
            }
            else
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                   new Response { Status = "Error", Messange = "User failed to be created!" });
            }
            //Assign a role

        }
    }
}
