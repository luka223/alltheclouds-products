using AutoMapper;
using Poducts_service.Domain;
using Poducts_service.DTO;

namespace Poducts_service.Mapping
{
    /// <summary>
    /// Mapping profile for mapping for product related model classes.
    /// </summary>
    public class ProductsMappingProfile : Profile
    {
        public ProductsMappingProfile()
        {
            CreateMap<Product, ProductDTO>();
        }
    }
}
