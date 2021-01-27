using System;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using Client.API.APAC.eSKU.Client.API.Errors;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Client.API.APAC.eSKU.Client.API.MiddlewareException
{
    public class ExceptionMiddleware
    {
         private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionMiddleware> _logger;
        private readonly IHostEnvironment _env;

        public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger,
         IHostEnvironment env)
        {
            _env = env;
            _logger = logger;
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                context.Response.ContentType = "application/json";
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                var response = _env.IsDevelopment()
                ? new APIException(context.Response.StatusCode, ex.Message, ex.StackTrace?.ToString())
                : new APIException(context.Response.StatusCode, "Internal Server Error");

                var options = new JsonSerializerOptions { PropertyNamingPolicy = null};
                var json = JsonSerializer.Serialize(response, options);
                await context.Response.WriteAsJsonAsync(json);
            }

        }
    }}
