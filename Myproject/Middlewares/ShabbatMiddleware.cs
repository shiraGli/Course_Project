namespace Myproject.Middlewares
{
    public class ShabbatMiddleware
    {
        private readonly RequestDelegate _next;
        public ShabbatMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task invoke(HttpContext context)
        {
            
            var shabbat = true;
            if (shabbat = false)
                context.Response.StatusCode = StatusCodes.Status400BadRequest;
            else
                await _next(context);
        }
    }   
}
