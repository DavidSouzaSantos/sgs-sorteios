using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Domain.Models;

namespace WebApiSGSorteios.Services
{
    public static class TokenService
    {
        public static string GenerateToken(IConfiguration pConfig, User pUser)
        {
            var tokenHandler = new JwtSecurityTokenHandler();

            var key = new SymmetricSecurityKey(Encoding.ASCII
                .GetBytes(pConfig.GetSection("AppSettings:Token").Value));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, pUser.Id.ToString()),
                new Claim(ClaimTypes.Name, pUser.Username),
                new Claim(ClaimTypes.Role, pUser.Role.ToString())
            };

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddMinutes(60),
                SigningCredentials = creds
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
