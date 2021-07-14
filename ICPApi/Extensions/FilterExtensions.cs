using ICPApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;

namespace ICPApi.Extensions
{
    public static class FilterExtentions
    {
        public static ActionExecutingContext ReturnContext(this ActionExecutingContext context, HttpStatusCode statusCode, string Type, string Message)
        {
            context.HttpContext.Response.StatusCode = (int)statusCode;
            context.Result = new JsonResult(new BaseResponseServiceModel
            {
                Message = Message,
                Type = Type
            });

            return context;
        }

        public static ExceptionContext ReturnContext(this ExceptionContext context, HttpStatusCode statusCode, string Type, string Message)
        {
            context.ExceptionHandled = true;
            context.HttpContext.Response.StatusCode = (int)statusCode;
            context.Result = new JsonResult(new BaseResponseServiceModel
            {
                Message = Message,
                Type = Type
            });

            return context;
        }
    }
}
