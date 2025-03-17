using System.Net;

namespace AspDotNetInDepth.Middlewares
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionHandlingMiddleware> _logger;
        public ExceptionHandlingMiddleware(RequestDelegate next, ILogger<ExceptionHandlingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                // Proceed to the next middleware in the pipline
                await _next(context);
            }
            catch (Exception ex)
            {

                // Handle the exception
                _logger.LogError(ex, "An unexpected error occured!");
                await HandleExceptionAsync(context, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            var response = new
            {
                StatusCode = context.Response.StatusCode,
                Message = "Internal Server Error",
                details = exception.Message // Avoid exposing the exception details in production
            };

            return context.Response.WriteAsJsonAsync(response);
        }
    }
}
