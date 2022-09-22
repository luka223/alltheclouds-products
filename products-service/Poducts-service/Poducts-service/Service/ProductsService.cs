using AutoMapper;
using Poducts_service.Domain;
using Poducts_service.DTO;
using Poducts_service.Repository;

namespace Poducts_service.Service
{
    public class ProductsService : IProductsService
    {
        private static readonly double PRICE_INCREASE = 1.2;

        private readonly IProductsRepository _productsRepository;
        private readonly IMapper _mapper;

        public ProductsService(IProductsRepository productsRepository, IMapper mapper)
        {
            _productsRepository = productsRepository;
            _mapper = mapper;
        }

        public async Task<List<ProductDTO>> GetProductsAsync()
        {
            List<Product> products = await _productsRepository.GetProductsAsync();

            // Prices are increased 20% because of the business requirement
            foreach (Product product in products)
            {
                product.UnitPrice = product.UnitPrice * PRICE_INCREASE;
            }

            return _mapper.Map<List<ProductDTO>>(products);
        }
    }
}
