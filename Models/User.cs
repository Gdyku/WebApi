using System;
using System.Collections.Generic;

namespace Models
{
    public class User
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public List<Product> Product { get; set; }
        public List<Comment> Comment { get; set; }
    }
}
