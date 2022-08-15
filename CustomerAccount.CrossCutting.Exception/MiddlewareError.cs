using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Net;
namespace CustomerAccount.CrossCutting.Exceptions
{
    public class MiddlewareError
    {
        private readonly RequestDelegate next;

        public MiddlewareError(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            context.Response.StatusCode = ExceptionFilter(ex);

            var errorResponse = new ErrorResponse(ex.Message);

            var result = JsonConvert.SerializeObject(errorResponse);

            context.Response.ContentType = "application/json";

            return context.Response.WriteAsync(result);
        }

        private int ExceptionFilter(Exception ex)
        {
            switch (ex.Message)
            {
                case "NotFound":
                    return (int)HttpStatusCode.NotFound;

                case "UnprocessableEntity":
                    return (int)HttpStatusCode.UnprocessableEntity;

                case "BadRequest":
                    return (int)HttpStatusCode.BadRequest;

                default:
                    return (int)HttpStatusCode.InternalServerError;
            }
        }
    }
}

