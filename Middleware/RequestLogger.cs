namespace ADayInTheZoo.Middleware;

public class RequestLoggerMiddleware
{
    private readonly RequestDelegate _next;

    // Constructor with RequestDelegate parameter
    public RequestLoggerMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    // The InvokeAsync method (required)
    public async Task InvokeAsync(HttpContext context)
    {
        // Custom logic before the next middleware
        Console.WriteLine("Request logger executing. Request method is " + context.Request.Method);

        // Call the next middleware in the pipeline
        await _next(context);

        // Custom logic after the next middleware
        Console.WriteLine("Request logger finished");
    }
}
