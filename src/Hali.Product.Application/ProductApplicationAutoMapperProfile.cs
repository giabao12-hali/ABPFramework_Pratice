using AutoMapper;
using Hali.Product.Models;

namespace Hali.Product;

public class ProductApplicationAutoMapperProfile : Profile
{
    public ProductApplicationAutoMapperProfile()
    {
        CreateMap<Product.Models.Product, ProductDto>();
        CreateMap<Product.Models.Category, CategoryDto>();

        CreateMap<CreateUpdateProductDto, Product.Models.Product>();
        CreateMap<CreateUpdateCategoryDto, Product.Models.Category>();

        CreateMap<Product.Models.Product, ProductDto>()
            .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.CategoryId))
            .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name));
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
