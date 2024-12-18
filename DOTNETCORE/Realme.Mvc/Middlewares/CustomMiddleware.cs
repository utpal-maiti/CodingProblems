namespace Realme.Mvc.Middlewares
{
    public class CustomMiddleware
    {
        private readonly RequestDelegate _next;

        public CustomMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // Perform some action before the next middleware is called
            Console.WriteLine("Before processing request");

            // Call the next middleware in the pipeline
            await _next(context);

            // Perform some action after the next middleware is called
            Console.WriteLine("After processing request");
        }
    }

}
