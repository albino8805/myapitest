using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MyAPITest.Helpers
{
    /// <summary>
    /// TokenHelper
    /// </summary>
    public class TokenHelper
    {
        /// <summary>
        /// Decodes the specified token.
        /// </summary>
        /// <param name="Token">The token.</param>
        /// <returns></returns>
        public static JwtSecurityToken Decode(string Token)
        {
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            return tokenHandler.ReadJwtToken(Token);
        }

        /// <summary>
        /// Gets the token.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        /// <exception cref="UnauthorizedAccessException">
        /// </exception>
        public static string GetToken(HttpRequest request)
        {
            string token = request.Headers[nameof(Authorization)].ToString();
            string[] items = token.Split(" ");
            token = items.Length > 1 ? items[1] : items[0];
            token = token.Replace("Bearer", "").Replace("bearer", "").Trim();

            if (string.IsNullOrEmpty(token))
                throw new UnauthorizedAccessException();

            try
            {
                JwtSecurityToken jwtSecurityToken = Decode(token);
            }
            catch (Exception e)
            {
                throw new UnauthorizedAccessException();
            }
            return token;
        }

        /// <summary>
        /// Gets the value claim.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <param name="claimName">Name of the claim.</param>
        /// <returns></returns>
        public static string GetValueClaim(string token, string claimName)
        {
            string value = string.Empty;
            JwtSecurityToken jwtSecurityToken = TokenHelper.Decode(token);
            Claim claim = jwtSecurityToken.Claims.FirstOrDefault(c => c.Type == claimName);
            value = claim?.Value;
            return value;
        }
    }
}
