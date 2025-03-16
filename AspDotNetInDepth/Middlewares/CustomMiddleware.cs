namespace AspDotNetInDepth.Middlewares
{
    public class CustomMiddleware
    {
        private readonly RequestDelegate _next;
        public CustomMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            Console.WriteLine("Custom Middleware: Before Request");
            await _next(context); //calls the next middleware
            Console.WriteLine("Custom MIddleware: After Response");
        }
    }
}
