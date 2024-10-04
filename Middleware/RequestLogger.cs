namespace ADayInTheZoo.Middleware;

public class RequestLoggerMiddleware(RequestDelegate next)
{
    private readonly RequestDelegate _next = next;

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

public static class RequestLoggerMiddlewareExtensions
{
    public static IApplicationBuilder UseRequestLoggerMiddleware(
        this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<RequestLoggerMiddleware>();
    }
}