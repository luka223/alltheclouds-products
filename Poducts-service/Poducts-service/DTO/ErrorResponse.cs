namespace Poducts_service.DTO
{
    /// <summary>
    /// Class with error details in case error occurs during HTTP request
    /// </summary>
    public class ErrorResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
