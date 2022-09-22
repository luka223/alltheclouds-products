using Poducts_service.DTO;

namespace Poducts_service.Service
{
    /// <summary>
    /// Product service interface responsible for retrieving list of all products.
    /// </summary>
    public interface IProductsService
    {
        Task<List<ProductDTO>> GetProductsAsync();
    }
}
