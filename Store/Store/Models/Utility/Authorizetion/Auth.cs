using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Store.Models.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Store.Models.Utility.Authorizetion
{
    public class Auth : AuthorizeAttribute, IAuthorizationFilter
    {
        private IUserService userService;
        public Auth(string role)
        {

        }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            userService = (IUserService)context.HttpContext.RequestServices.GetService(typeof(IUserService));
            if (context.HttpContext.User.Identity.IsAuthenticated)
            {
                string _role = context.HttpContext.User.FindFirst(ClaimTypes.Role).Value;
                string _username = context.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
                string _token = context.HttpContext.User.FindFirst("Token").Value;

                if (!(userService.CheckUserPasswordChange(_username,_token)&&userService.CheckUserRole(_username,_role)))
                    context.Result = new RedirectResult("/login");
            }
            else
            {
                context.Result = new RedirectResult("/login");
            }
        }
    }
}
