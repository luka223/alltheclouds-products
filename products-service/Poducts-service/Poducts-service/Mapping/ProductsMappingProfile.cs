using AutoMapper;
using Poducts_service.Domain;
using Poducts_service.DTO;

namespace Poducts_service.Mapping
{
    /// <summary>
    /// Mapping profile for mapping <see cref="Product"/> to <see cref="ProductDTO"/>.
    /// Does the field mapping and price increase because of the business requirement.
    /// </summary>
    public class ProductsMappingProfile : Profile
    {
        public ProductsMappingProfile()
        {
            CreateMap<Product, ProductDTO>();
        }
    }
}
