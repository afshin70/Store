using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace Store
{
    public class NotFoundPage_404Error
    {
        private readonly RequestDelegate _next;

        public NotFoundPage_404Error(RequestDelegate next)
        {
            _next = next;
        }

      async  public Task Invoke(HttpContext httpContext)
        {
           await  _next(httpContext);
            if (httpContext.Response.StatusCode == 404)
            {
                httpContext.Response.Redirect("/404");
                //await httpContext.Response.WriteAsync("/Home/PageNotFound");
            }
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class NotFoundPage_404ErrorExtensions
    {
        public static IApplicationBuilder UseNotFoundPage_404Error(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<NotFoundPage_404Error>();
        }
    }
}
