using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class User
    {
        public Guid ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [StringLength(16)]
        public string Password { get; set; }
        public List<Product> Product { get; set; }
        public List<Comment> Comment { get; set; }
    }
}
