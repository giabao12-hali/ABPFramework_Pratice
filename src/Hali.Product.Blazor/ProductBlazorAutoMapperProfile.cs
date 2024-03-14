using AutoMapper;
using Hali.Product.Models;

namespace Hali.Product.Blazor;

public class ProductBlazorAutoMapperProfile : Profile
{
    public ProductBlazorAutoMapperProfile()
    {
        CreateMap<ProductDto, CreateUpdateProductDto>();
        CreateMap<CategoryDto, CreateUpdateCategoryDto>();

        //Define your AutoMapper configuration here for the Blazor project.
    }
}
