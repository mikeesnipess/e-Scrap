using System.Diagnostics;

namespace eScrap.Middleware
{
    public class RequestLoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<RequestLoggingMiddleware> _logger;

        public RequestLoggingMiddleware(RequestDelegate next, ILogger<RequestLoggingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var stopwatch = Stopwatch.StartNew();
            try
            {
                _logger.LogInformation("Handling request: {Method} {Path}", context.Request.Method, context.Request.Path);

                await _next(context);

                stopwatch.Stop();
                _logger.LogInformation("Request handled successfully in {ElapsedMilliseconds} ms", stopwatch.ElapsedMilliseconds);
            }
            catch (Exception ex)
            {
                stopwatch.Stop();
                _logger.LogError(ex, "An error occurred while processing the request in {ElapsedMilliseconds} ms", stopwatch.ElapsedMilliseconds);
                throw; // Re-throw the exception after logging it
            }
        }
    }
}
