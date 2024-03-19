using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Hali.Product.Models
{
    public interface IProductAppService :
        ICrudAppService<ProductDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateProductDto>
    {
        //Task<ProductDto> GetAsync(Guid id, CreateUpdateProductDto input);
        Task<ProductDto> UpdateAsync(Guid id, CreateUpdateProductDto input);
    }
}
