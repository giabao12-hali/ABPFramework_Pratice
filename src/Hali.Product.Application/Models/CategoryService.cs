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
    public class CategoryService :
        CrudAppService<Category, CategoryDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateCategoryDto>
        , ICategoryAppService
    {
        public CategoryService(IRepository<Category, Guid> repository) : base(repository)
        {

        }
    }
}
