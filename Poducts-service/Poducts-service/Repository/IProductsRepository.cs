using Poducts_service.Domain;

namespace Poducts_service.Repository
{
    /// <summary>
    /// Product repository interface responsible for retrieving products from remote location.
    /// </summary>
    public interface IProductsRepository
    {
        Task<List<Product>> GetProductsAsync();
    }
}
