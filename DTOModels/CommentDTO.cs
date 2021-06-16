﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.DTOModels
{
    public class CommentDTO
    {
        public Guid ID { get; set; }
        [Required]
        [StringLength(100)]
        public string Text { get; set; }
        public UserDTO Commenter { get; set; }
    }
}
