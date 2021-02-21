using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.DTOModels;
using System;

namespace WebApi.Interfaces
{
    public interface ICommentLogic
    {
        Task<List<CommentDTO>> GetComments();
        Task CreateComment(CommentDTO comment);
        Task EditComment(Guid ID, CommentDTO updateComment);
        Task DeleteComment(Guid ID);
    }
}