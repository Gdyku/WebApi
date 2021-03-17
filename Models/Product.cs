using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Product
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public Guid OwnerID { get; set; }
        public User Owner { get; set; }
    }
}
