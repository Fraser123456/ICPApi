using ICPApi.Extensions;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Net;

namespace ICPApi.Filters
{
    public class ExceptionHandler : ExceptionFilterAttribute
    {

        public override void OnException(ExceptionContext context)
        {

            Exception exception = context.Exception;

            Type ExceptionType = exception.GetType();

            if (ExceptionType.Name == "CoreException")
            {
                context.ReturnContext(HttpStatusCode.Conflict, "E", exception.Message);
            }
            else
            {
                context.ReturnContext(HttpStatusCode.InternalServerError, "E", "An error occurred. Please contact to the system admin.");
            }

        }
    }
}
