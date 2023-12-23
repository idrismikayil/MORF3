using Domain.Rules;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net;
using System.Text.Json;

namespace Infrastructure.Middleware
{
    public class GlobalExceptionHandler : IMiddleware
    {
        private readonly ILogger<GlobalExceptionHandler> _logger;
        public GlobalExceptionHandler(ILogger<GlobalExceptionHandler> logger)
        {
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            ProblemDetails problem;
            try
            {
                await next(context);
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                if (e is not INonSensitiveException)
                {
                    problem = new()
                    {
                        Status = (int)HttpStatusCode.InternalServerError,
                        Type = "Server error",
                        Title = "Server error",
                        Detail = "An internal server error has occured",
                    };
                }
                else
                {
                    problem = new()
                    {
                        Status = (int)HttpStatusCode.InternalServerError,
                        Type = "Server error",
                        Title = e.GetType().Name,
                        Detail = e.Message,
                    };
                }

                string json = JsonSerializer.Serialize(problem);
                context.Response.ContentType = "application/json";
                await context.Response.WriteAsync(json);
            }
        }
    }
}
