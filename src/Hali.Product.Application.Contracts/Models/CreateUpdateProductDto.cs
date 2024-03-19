using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Hali.Product.Models
{
    public class CreateUpdateProductDto
    {
        public Guid? Id { get; set; }
        [StringLength(128)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; } = DateTime.Now;

        [Required]
        public float Price { get; set; }

        public Guid CategoryId { get; set; }
    }
}
