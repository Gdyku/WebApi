using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Product
    {
        public Guid ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Price { get; set; }
        public string Description { get; set; }
        [Required]
        public string Category { get; set; }
        public Guid OwnerID { get; set; }
        public User Owner { get; set; }
    }
}
