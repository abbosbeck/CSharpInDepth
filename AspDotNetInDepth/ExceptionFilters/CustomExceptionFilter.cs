using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AspDotNetInDepth.ExceptionFilters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        private readonly ILogger<CustomExceptionFilter> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public CustomExceptionFilter(ILogger<CustomExceptionFilter> logger, IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            _webHostEnvironment = webHostEnvironment;
        }

        public void OnException(ExceptionContext context)
        {
            _logger.LogError(context.Exception, "Exception caught in filter!");

            var (statusCode, message) = context.Exception switch
            {
                ArgumentException => (400, "Invalid request"),
                UnauthorizedAccessException => (401, "Unauthorized"),
                _ => (500, "Something went wrong!")
            };

            var response = new
            {
                status = statusCode,
                message,
                details = _webHostEnvironment.IsDevelopment() ? context.Exception.StackTrace : null
                //details = context.Exception.Message  -- If the environment is in production mode, do not expose this
            };

            context.Result = new ObjectResult(response)
            {
                StatusCode = statusCode
            };

            context.ExceptionHandled = true;
        }
    }
}
