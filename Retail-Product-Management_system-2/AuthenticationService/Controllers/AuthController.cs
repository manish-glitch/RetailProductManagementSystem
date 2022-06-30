using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private string GenerateJWT(string userName, string role, string key)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new[] { new Claim(ClaimTypes.Name, userName), new Claim(ClaimTypes.Role, role) };

            var token = new JwtSecurityToken(issuer: "https://www.mmshingare.com", audience: "https://www.mmshingare.com", expires: DateTime.Now.AddMinutes(15), signingCredentials: credentials, claims: claims);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        [HttpGet]
        public ActionResult GetToken(string userName, string role, string key)
        {
            string token = GenerateJWT(userName, role, key);
            return Ok(token);
        }
    }
}
