using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace Hali.Product.Models
{
    public class Category : Entity<Guid>
    {
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
