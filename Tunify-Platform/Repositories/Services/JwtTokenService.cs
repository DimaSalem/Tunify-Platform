using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace Tunify_Platform.Repositories.Services
{
    public class JwtTokenService
    {
        public static TokenValidationParameters ValidateToken(IConfiguration configuration)
        {
            return new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = GetSecurityKey(configuration),
                ValidateIssuer = false,
                ValidateAudience = false
            };

        }

        public static SecurityKey GetSecurityKey(IConfiguration configuration)
        {
            var secretKey = configuration["JWT:SecretKey"];
            if (secretKey == null)
            {
                throw new InvalidOperationException("Jwt Secret key is not exsist");
            }

            var secretBytes = Encoding.UTF8.GetBytes(secretKey);

            return new SymmetricSecurityKey(secretBytes);
        }

    }
}
