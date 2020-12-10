using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace aspnetcoreapp.Middleware
{
    public class GroupAuthenticationMiddleware
    {
        private readonly RequestDelegate _next;

        public GroupAuthenticationMiddleware(RequestDelegate next)
        {
            _next = next;
        }
    }
}