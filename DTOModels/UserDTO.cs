using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.DTOModels
{
    public class UserDTO
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public List<ProductDTO> Product { get; set; }
        public List<CommentDTO> Comment { get; set; }
    }
}
