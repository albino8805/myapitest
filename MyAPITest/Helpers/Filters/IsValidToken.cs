using JWT;
using JWT.Algorithms;
using JWT.Serializers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using MyAPITest.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAPITest.Helpers.Filters
{
    /// <summary>
    /// IsValidToken
    /// </summary>
    /// <seealso cref="ActionFilterAttribute" />
    /// <seealso cref="IAsyncActionFilter" />
    public class IsValidToken : ActionFilterAttribute, IAsyncActionFilter
    {
        private const bool TrueValue = true;
        private const string ID = "ID";
        private const string ExpiredToken = "Token expirado";

        /// <summary>
        /// </summary>
        /// <param name="context"></param>
        /// <param name="next"></param>
        /// <inheritdoc />
        public async override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            string token = TokenHelper.GetToken(context.HttpContext.Request);

            string value = TokenHelper.GetValueClaim(token, "Expire");

            DateTime tokenTo = Convert.ToDateTime(TokenHelper.GetValueClaim(token, "Expire"));
            DateTime toDay = DateTime.Today;

            if (toDay.CompareTo(tokenTo) < 0)
                await next();
            else
            {
                context.HttpContext.Response.StatusCode = 401;
                context.HttpContext.Response.ContentType = $"{System.Net.Mime.MediaTypeNames.Application.Json};charset=UTF-8";

                string response = JsonConvert.SerializeObject(new ResultMessage
                {
                    Failure = TrueValue,
                    Message = ExpiredToken
                });
                await context.HttpContext.Response.WriteAsync(response.ToLower());
            }

            return;
        }
    }
}
