using JWTTokenAuthentication.Commons;
using JWTTokenAuthentication.ViewModels.Register;
using JWTTokenAuthentication.ViewModels.SignIn;
using JWTTokenAuthentication_DAL.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace JWTTokenAuthentication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        
            private readonly UserManager<AppUser> userManager;
            private readonly RoleManager<IdentityRole> roleManager;
            private readonly IConfiguration _configuration;
            private readonly SignInManager<AppUser> signInManager;
            public AuthController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration)
            {
                this.userManager = userManager;
                this.roleManager = roleManager;
                _configuration = configuration;
                this.signInManager = signInManager;
            }
            [HttpPost]
            [Route("Register")]
            public async Task<IActionResult> Register([FromBody] RegisterVM registerVM)
            {
                var IsExist = await userManager.FindByNameAsync(registerVM.Name);
                if (IsExist != null) return StatusCode(StatusCodes.Status500InternalServerError, new Response
                {
                    Status = "Error",
                    Message = "User already exists!"
                });
                AppUser appUser = new AppUser
                {
                    UserName = registerVM.Name,
                    AccountType = registerVM.AccountType,
                    Email = registerVM.Email,
                    PhoneNumber = registerVM.PhoneNo,
                    Password = registerVM.Password,
                    ShopName = registerVM.ShopName,
                    BusinessType = registerVM.BusinessType,
                    UserRole = registerVM.UserRole,
                    IsDeleted = registerVM.IsDeleted
                };
                var result = await userManager.CreateAsync(appUser, registerVM.Password);
                if (!result.Succeeded)
                {
                StringBuilder message = new StringBuilder();
                foreach(var msg in result.Errors)
                {
                    message.AppendLine("Code: " + msg.Code);
                    message.AppendLine("Description: " + msg.Description+ "\n");
                    message.AppendLine();
                }


                return StatusCode(StatusCodes.Status500InternalServerError, new Response
                {
                    Status = "Error",

                    Message = message.ToString()
                }); ;
            }
                
                if (!await roleManager.RoleExistsAsync(registerVM.UserRole)) await roleManager.CreateAsync(new IdentityRole(registerVM.UserRole));
                if (await roleManager.RoleExistsAsync(registerVM.UserRole))
                {
                    await userManager.AddToRoleAsync(appUser, registerVM.UserRole);
                }
                return Ok(new Response
                {
                    Status = "Success",
                    Message = "User created successfully!"
                });
            }
            [HttpPost]
            [Route("Login")]
            public async Task<IActionResult> Login([FromBody] LoginVM loginVM)
            {
                //var user1 = await userManager.FindByIdAsync(loginVM.Id);
                var user = await userManager.FindByNameAsync(loginVM.UserName);
                if (user != null && await userManager.CheckPasswordAsync(user, loginVM.Password))
                {
                    var userRoles = await userManager.GetRolesAsync(user);
                    var authClaims = new List<Claim> {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(ClaimTypes.MobilePhone, user.PhoneNumber),
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                };
                    foreach (var userRole in userRoles)
                    {
                        authClaims.Add(new Claim(ClaimTypes.Role, userRole));
                    }
                    var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JsonWebTokenKeys:IssuerSigningKey"]));
                    var token = new JwtSecurityToken(expires: DateTime.Now.AddHours(3), claims: authClaims, signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256));
                    return Ok(new
                    {
                        api_key = new JwtSecurityTokenHandler().WriteToken(token),
                        expiration = token.ValidTo,
                        user = user,
                        Role = userRoles,
                        status = "User Login Successfully"
                    });
                }
                return Unauthorized();
            }
        }
    }
