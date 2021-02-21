using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;
using WebApi.DTOModels;
using AutoMapper;

namespace WebApi.Logic
{
    public class CommentLogic
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;
        public CommentLogic(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<CommentDTO>> GetComments()
        {
            var comments = await _context.Comments.ToListAsync();
            var mappedComments = _mapper.Map<List<Comment>, List<CommentDTO>>(comments);

            return mappedComments;
        }

        public async Task CreateComment(CommentDTO comment)
        {
            var mappedComment = _mapper.Map<CommentDTO, Comment>(comment);

            _context.Comments.Add(mappedComment);
            await _context.SaveChangesAsync();
        }

        public async Task EditComment(Guid ID, CommentDTO updateComment)
        {
            var comment = await _context.Comments.FirstOrDefaultAsync(c => c.ID == ID);

            if (comment == null)
                throw new Exception("Couldn't find comment");

            comment.Text = updateComment.Text ?? comment.Text;

            await _context.SaveChangesAsync();
        }

        public async Task DeleteComment(Guid ID)
        {
            var comment = await _context.Comments.FirstOrDefaultAsync(c => c.ID == ID);

            if (comment == null)
                throw new Exception("Couldn't find comment");

            _context.Remove(comment);
            await _context.SaveChangesAsync();
        }
    }
}