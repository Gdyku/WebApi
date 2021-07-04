using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.DTOModels
{
    public class ProductDTO
    {
        public Guid ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public float Price { get; set; }
        public string Description { get; set; }
        [Required]
        public string Category { get; set; }
        public Guid OwnerID { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
