using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Comment
    {
        public Guid ID { get; set; }
        [Required]
        [StringLength(100)]
        public string Text { get; set; }
        public Guid CommenterID { get; set; }
        public User Commenter { get; set; }
    }
}
