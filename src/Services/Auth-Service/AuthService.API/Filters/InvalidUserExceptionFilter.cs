using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newsboard.Services.AuthService.API.Error;

namespace AuthService.API.Filters
{
    public class InvalidUserExceptionFilter: ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            if( context.ExceptionHandled)
            {
                return;
            }
            if( context.Exception is InvalidUserException)
            {
                context.HttpContext.Response.StatusCode = 400;
                context.Result = new JsonResult("Invalid Credencials submitted");
                context.ExceptionHandled = true;
            }
        }
        
    }
}