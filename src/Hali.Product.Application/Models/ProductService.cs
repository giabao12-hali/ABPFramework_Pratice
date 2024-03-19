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

        public async Task<ProductDto> UpdateAsync(Guid Id, CreateUpdateProductDto input)
        {
            var existingProduct = await Repository.FindAsync(input.Id.Value);

            if (existingProduct == null)
            {
                throw new Exception("Không tìm thấy Product");
            }

            existingProduct.Name = input.Name;
            existingProduct.PublishDate = input.PublishDate;
            existingProduct.Price = input.Price;
            existingProduct.CategoryId = input.CategoryId;

            await Repository.UpdateAsync(existingProduct);
            await CurrentUnitOfWork.SaveChangesAsync();

            return MapToGetOutputDto(existingProduct);
        }
    }
}
