using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Poducts_service.DTO;
using Poducts_service.Service;

namespace Poducts_service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsService _productsService;

        public ProductsController(IProductsService productsService)
        {
            _productsService = productsService;
        }

        /// <summary>
        /// Gets list of all products avaiable on All The Clouds.
        /// </summary>
        /// <returns>List of products</returns>
        [HttpGet(Name = "GetProducts")]
        public async Task<List<ProductDTO>> GetProducts()
        {
            return await _productsService.GetProductsAsync();
        }
    }
}
