using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApi.DTOModels
{
    public class UserDTO
    {
        public Guid ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [StringLength(16)]
        public string Password { get; set; }
        public List<ProductDTO> Product { get; set; }
        public List<CommentDTO> Comment { get; set; }
    }
}
