namespace Poducts_service.Config
{
    public class HttpConfiguration
    {
        public string ApiKey { get; private set; }

        public HttpConfiguration(IConfiguration configuration)
        {
            ApiKey = configuration.GetSection("HttpConfiguration").GetValue(typeof(string), "ApiKey").ToString();
        }
    }
}
