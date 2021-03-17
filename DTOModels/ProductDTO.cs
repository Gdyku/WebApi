using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.DTOModels
{
    public class ProductDTO
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public Guid OwnerID { get; set; }
        //public UserDTO Owner { get; set; }
    }
}
