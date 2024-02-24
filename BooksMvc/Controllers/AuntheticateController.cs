using Azure.Identity;
using BooksMvc.Models;
using BooksMvc.Models.Aunthetication.Login;
using BooksMvc.Models.Aunthetication.SignUp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using UserManagement.Models;
using UserManagement.Services;
using JwtRegisteredClaimNames = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames;

namespace BooksMvc.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuntheticateController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private IConfiguration _configuration;
        private readonly IEmailService _emailService;
        public AuntheticateController(UserManager<IdentityUser> userManager, 
            RoleManager<IdentityRole> roleManager, IConfiguration configuration, IEmailService emailService)
        {
            _roleManager = roleManager;

            _configuration = configuration;
            _userManager = userManager;
            _emailService = emailService;

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
       
        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] LoginUser loginUser)
        {
            //checking the user
            var user = await _userManager.FindByNameAsync(loginUser.Username);
            if(user!=null && await _userManager.CheckPasswordAsync(user,loginUser.Password)) 
            {
                var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                };
                var userRoles = await _userManager.GetRolesAsync(user);
                foreach(var role in userRoles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, role));
                }
                var jwtToken = GetToken(authClaims);

                return Ok(new { 
                    token = new JwtSecurityTokenHandler().WriteToken(jwtToken),
                    expiration = jwtToken.ValidTo
                });
            }
            return Unauthorized();
        }
        [HttpPost]
        [AllowAnonymous]
       
        public async Task<IActionResult> ForgotPassword([Required] string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user != null)
            {
                var token = await _userManager.GeneratePasswordResetTokenAsync(user);
                var ForgotPasswordlink = Url.Action(nameof(ResetPassword), "Auntheticate", new { token, email = user.Email }, Request.Scheme);
                var message = new Message(new string[] { user.Email! }, "Forgot password link", ForgotPasswordlink!);
                _emailService.SendEmail(message);
                return StatusCode(StatusCodes.Status200OK,
                       new Response { Status = "Success", Messange = $"Password change request is sent {user.Email}" });
            }
            return StatusCode(StatusCodes.Status400BadRequest,
                       new Response { Status = "Error", Messange = $"Could send link " });
        }

        [HttpGet("reset-password")]
        public async Task<IActionResult> ResetPassword(string token, string email)
        {
            var model = new ResetPassword { Token = token, Email = email };
            return Ok(new
            { 
                model 
            });
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("reset-password")]
        public async Task<IActionResult> ResetPassword (ResetPassword resetPassword)
        {
            var user = await _userManager.FindByEmailAsync(resetPassword.Email);
            if (user != null)
            {
                var resetPassResult = await _userManager.ResetPasswordAsync(user, resetPassword.Token, resetPassword.Password);
                if(!resetPassResult.Succeeded)
                {
                    foreach (var error in resetPassResult.Errors)
                    {
                        ModelState.AddModelError(error.Code, error.Description);
                    }
                    return Ok(ModelState);
                }
                return StatusCode(StatusCodes.Status200OK,
                      new Response { Status = "Success", Messange = $"Password has been changed " });
        }
            return StatusCode(StatusCodes.Status400BadRequest,
                      new Response { Status = "Error", Messange = $"Could send link " });
        }
        private JwtSecurityToken GetToken(List<Claim> authClaims)
        {
            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddHours(1),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey,SecurityAlgorithms.HmacSha256));
            return token;
        }
    }
}
