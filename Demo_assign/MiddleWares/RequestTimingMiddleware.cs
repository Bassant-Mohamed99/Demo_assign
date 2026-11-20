using System.Diagnostics;

namespace Demo_assign.MiddleWares
{
    //rules
    //request delegate
    //method name invoke / invokeasync[http context]
    //call await next(context
    //register with app.usemiddleware<requesttimingmiddleware>()
    public class RequestTimingMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestTimingMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            var watch = Stopwatch.StartNew();
            await _next(context);
            watch.Stop();
            Console.WriteLine($"{context.Request.Path} , {watch.ElapsedMilliseconds} ms");
        }
    }
}
