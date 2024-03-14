using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Hali.Product.Models
{
    public class ProductService : 
        CrudAppService<Product, ProductDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateProductDto>,
        IProductAppService
    {
        public ProductService(IRepository<Product, Guid> repository) : base(repository)
        {

        }

        public override async Task<ProductDto> CreateAsync(CreateUpdateProductDto input)
        {
            var product = ObjectMapper.Map<CreateUpdateProductDto, Product>(input);
            await Repository.InsertAsync(product);
            await CurrentUnitOfWork.SaveChangesAsync();
            return MapToGetOutputDto(product);
        }
    }
}
