using Microsoft.IdentityModel.Tokens;
using MyMorApi.DBModel;
using MyMorApi.Interface;
using MyMorApi.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MyMorApi.Service
{
    public class JWTManagerService : IJWTManagerService
    {
        private readonly IConfiguration iconfiguration;
        public JWTManagerService(IConfiguration iconfiguration)
        {
            this.iconfiguration = iconfiguration;
        }
        public Tokens Authenticate(Login login)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.UTF8.GetBytes(iconfiguration["Jwt:Key"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
              {
                    new Claim(JwtRegisteredClaimNames.Sub, login.LoginID),
                    new Claim(JwtRegisteredClaimNames.Aud, iconfiguration["Jwt:Audience"]),
                    new Claim(JwtRegisteredClaimNames.Iss, iconfiguration["Jwt:Issuer"]),
              }),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return new Tokens { Token = tokenHandler.WriteToken(token) };

        }
    }
}
