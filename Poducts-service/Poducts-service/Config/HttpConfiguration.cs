namespace Poducts_service.Config
{
    /// <summary>
    /// Configuration class that holds all related properties for
    /// HTTP products API configuration
    /// </summary>
    public class ProductsHttpAPIConfiguration
    {
        public string ApiKey { get; private set; }

        public ProductsHttpAPIConfiguration(IConfiguration configuration)
        {
            ApiKey = configuration.GetSection("HttpConfiguration").GetValue(typeof(string), "ApiKey").ToString();
        }
    }
}
