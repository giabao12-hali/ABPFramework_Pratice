using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace Hali.Product.Models
{
    public class Product : Entity<Guid>
    {
        public string Name { get; set; }
        public DateTime PublishDate { get; set; }
        public float Price { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
