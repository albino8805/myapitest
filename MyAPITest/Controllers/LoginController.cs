using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using MyAPITest.ViewModels;

namespace MyAPITest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private const string UserID = "1";
        private IConfiguration _config;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginController"/> class.
        /// </summary>
        /// <param name="config">The configuration.</param>
        public LoginController(IConfiguration config)
        {
            _config = config;
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login([FromBody] LoginViewModel login)
        {
            try
            {
                IActionResult response = Unauthorized();

                if (login != null)
                {
                    var tokenString = GenerateJSONWebToken(login);
                    response = Ok(new
                    {
                        tokenString,
                        expirationDate = DateTime.Now.AddMinutes(5)
                    });
                }
                else
                {
                    throw new System.ArgumentException("El correo o la contraseña no son correctos", "Original");
                }

                return response;
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        private string GenerateJSONWebToken(LoginViewModel login)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var expireDate = DateTime.Now.AddDays(15);

            var claims = new[] {
                new Claim("ID", UserID),
                new Claim("CustomerEmail", login.Email),
                new Claim("Expire", expireDate.ToString()),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
                _config["Jwt:Issuer"],
                claims,
                expires: expireDate,
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
