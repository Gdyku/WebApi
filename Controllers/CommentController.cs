using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.DTOModels;
using WebApi.Logic;
using WebApi.Interfaces;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentLogic _commentLogic;
        public CommentController(ICommentLogic commentLogic)
        {
            _commentLogic = commentLogic;
        }

        [HttpGet("getcomments")]
        public async Task<List<CommentDTO>> GetCommentsAsync()
        {
            return await _commentLogic.GetComments();
        }

        [HttpPost]
        public async Task CreateCommentAsync(CommentDTO comment)
        {
            await _commentLogic.CreateComment(comment);
        }

        [HttpPut]
        public async Task EditCommentAsync(Guid ID, CommentDTO comment)
        {
            await _commentLogic.EditComment(ID, comment);
        }

        [HttpDelete]
        public async Task DeleteCommentAsync(Guid ID)
        {
            await _commentLogic.DeleteComment(ID);
        }
    }
}