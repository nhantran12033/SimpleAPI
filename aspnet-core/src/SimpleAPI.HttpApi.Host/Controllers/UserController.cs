
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System;
using Microsoft.Extensions.Configuration;
using SimpleAPI.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using SimpleAPI.Models;


namespace SimpleAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IConfiguration _configuration;

        public UserController( IConfiguration configuration)
        {

            _configuration = configuration;
        }

        [AllowAnonymous]
        [Route("Authenticate")]
        [HttpPost]
        public IActionResult Authenticate(string username, string password)
        {
            if (username == "user" && password == "user123") {
                var tokenKey = Encoding.UTF8.GetBytes(_configuration["AuthResponse:Token"]);

                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                    new Claim(ClaimTypes.Name, "User"),
                    }),
                    Expires = DateTime.Now.AddMinutes(60),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256)
                };
                var token = tokenHandler.CreateToken(tokenDescriptor);
                var finalToken = tokenHandler.WriteToken(token);
                return Ok(new { Token = finalToken });
            }
            else
            {
                return Unauthorized();
            }
            
        }
    }
}