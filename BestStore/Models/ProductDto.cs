using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BestStore.Models
{
    public class ProductDto
    {
        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Required , MaxLength(100)]
        public string Brand { get; set; }

        [Required , MaxLength(100)]
        public string Category { get; set; }

        [Required]
        public string Price { get; set; }

        [Required]
        public string Description { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}
