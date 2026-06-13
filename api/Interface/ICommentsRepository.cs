using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Helps;
using api.Models;

namespace api.Interface
{
    public interface ICommentsRepository
    {
        Task<List<Comment>> GetAllComments(CommentQueryObject queryObject);
        Task<Comment> GetCommentById(int id);
        Task<Comment> AddComment(Comment comment);
        Task<Comment> DeleteComment(int id);
        Task<Comment?> UpdateComment(int id, Comment comment);
    }
}