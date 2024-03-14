using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Hali.Product.Models
{
    public class ProductDto : EntityDto<Guid>
    {
        public string Name { get; set; }
        public DateTime PublishDate { get; set; }
        public float Price { get; set; }
        public Guid CategoryId { get; set; }
        public CategoryDto Category { get; set; }
        public string CategoryName { get; set; }
    }
}
