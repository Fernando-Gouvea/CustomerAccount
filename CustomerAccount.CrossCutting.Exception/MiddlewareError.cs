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
            ErrorResponse errorResponse;

            errorResponse = new ErrorResponse(HttpStatusCode.InternalServerError.ToString(),
                                                  $"{ex.Message} {ex?.InnerException?.Message}");

            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            var result = JsonConvert.SerializeObject(errorResponse);
            context.Response.ContentType = "application/json";
            return context.Response.WriteAsync(result);
        }
    }
}

