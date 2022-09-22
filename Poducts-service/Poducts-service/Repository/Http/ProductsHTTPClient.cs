using Poducts_service.Config;
using Poducts_service.Domain;
using System.Text.Json;

namespace Poducts_service.Repository.Http
{
    /// <summary>
    /// Implementation of <see cref="IProductsRepository"/> that retrieves products from All The Clouds Web API.
    /// </summary>
    public class ProductsHTTPClient : IProductsRepository
    {
        private static readonly string HTTP_REQUEST_FAILED_ERROR_MESSAGE = "Http request to All The Clouds products API failed!";
        private static readonly string JSON_DESERIALIZATION_FAILED_ERROR_MESSAGE = "Deserializing products API response failed!";

        private static readonly string PRODUCTS_ENDPOINT = "http://alltheclouds.com.au/api/Products";
        private static readonly string API_KEY_HEADER_NAME = "api-key";

        private readonly HttpClient _httpClient;
        private readonly ProductsHttpAPIConfiguration _httpConfiguration;

        public ProductsHTTPClient(HttpClient httpClient, ProductsHttpAPIConfiguration httpConfiguration)
        {
            _httpClient = httpClient;
            _httpConfiguration = httpConfiguration;
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            using var request = new HttpRequestMessage(HttpMethod.Get, PRODUCTS_ENDPOINT);
            try
            {
                request.Headers.Add(API_KEY_HEADER_NAME, _httpConfiguration.ApiKey);
                HttpResponseMessage response = await _httpClient.SendAsync(request);

                response.EnsureSuccessStatusCode();
                string json = await response.Content.ReadAsStringAsync();

                return JsonSerializer.Deserialize<List<Product>>(json, new JsonSerializerOptions()
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                });
            }
            catch (HttpRequestException ex)
            {
                throw new Exception(HTTP_REQUEST_FAILED_ERROR_MESSAGE, ex);
            }
            catch (JsonException ex)
            {
                throw new Exception(JSON_DESERIALIZATION_FAILED_ERROR_MESSAGE, ex);
            }
        }
    }
}
