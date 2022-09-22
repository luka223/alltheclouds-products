using Poducts_service.DTO;
using System.Net;
using System.Text.Json;

namespace Poducts_service.Middleware
{
    /// <summary>
    /// Exception handling middleware which will handle all of the runtime errors during API requests
    /// </summary>
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionHandlingMiddleware> _logger;

        public ExceptionHandlingMiddleware(RequestDelegate next, ILogger<ExceptionHandlingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(httpContext, ex);
            }
        }

        /// <summary>
        /// Handles exception and logs error with reference number for easier tracking of the error
        /// </summary>
        /// <param name="context">HTTP context</param>
        /// <param name="exception">Exception that occured</param>
        /// <returns></returns>
        private async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";
            var response = context.Response;

            string guid = Guid.NewGuid().ToString();

            var errorResponse = new ErrorResponse
            {
                Success = false,
                Message = string.Format("Internal server error! Reference number {0}", guid)
            };

            response.StatusCode = (int)HttpStatusCode.InternalServerError;

            _logger.LogError(string.Format("Reference number: {0}, Error message: {1}\n{2}", guid, exception.Message, exception.ToString()));
            var result = JsonSerializer.Serialize(errorResponse);
            await context.Response.WriteAsync(result);
        }
    }
}
