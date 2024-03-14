using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Hali.Product.Models
{
    public class CategoryDto :  EntityDto<Guid>
    {
        public string Name { get; set; }
    }
}
