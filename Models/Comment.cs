using System;

namespace Models
{
    public class Comment
    {
        public Guid ID { get; set; }
        public string Text { get; set; }
        public Guid CommenterID { get; set; }
        public User Commenter { get; set; }
    }
}
