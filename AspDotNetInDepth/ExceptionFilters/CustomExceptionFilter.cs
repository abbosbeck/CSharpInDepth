using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AspDotNetInDepth.ExceptionFilters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        private readonly ILogger<CustomExceptionFilter> _logger;
        public CustomExceptionFilter(ILogger<CustomExceptionFilter> logger)
        {
            _logger = logger;
        }

        public void OnException(ExceptionContext context)
        {
            _logger.LogError(context.Exception, "Exception caught in filter!");

            var response = new
            {
                status = StatusCodes.Status500InternalServerError,
                message = "Something went wrong!",
                details = context.Exception.Message // Avoid exposing in production 
            };

            context.Result = new ObjectResult(response)
            {
                StatusCode = StatusCodes.Status500InternalServerError
            };

            context.ExceptionHandled = true;
        }
    }
}
