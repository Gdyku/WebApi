using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.DTOModels
{
    public class CommentDTO
    {
        public Guid ID { get; set; }
        public string Text { get; set; }
        public UserDTO Commenter { get; set; }
    }
}
