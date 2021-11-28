using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TimeTracker.Services.Interfaces.Services.Utils;

namespace TimeTracker.Services.Services.Utils
{
    public class TokenGeneratorService : ITokenGeneratorService
    {
        private string tokenKey = "this is my custom Secret key for authnetication";

        public string GenerateToken(int userId)
        {
            var token = new JwtSecurityToken(
                claims: new Claim[] { new Claim(ClaimTypes.NameIdentifier, userId.ToString()) },
                notBefore: new DateTimeOffset(DateTime.Now).DateTime,
                expires: new DateTimeOffset(DateTime.Now.AddMinutes(5)).DateTime,
                signingCredentials: new SigningCredentials(
                     new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenKey)),
                    SecurityAlgorithms.HmacSha256));

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
