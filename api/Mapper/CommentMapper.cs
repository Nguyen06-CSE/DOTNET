using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Comment;
using api.Models;

namespace api.Mapper
{
    public static class CommentMapper
    {
        public static CommentDTO ToCommentDTO(this Comment commentModel)
        {
            return new CommentDTO
            {
                Id = commentModel.Id,
                Title = commentModel.Title,
                Content = commentModel.Content,
                CreatedOn = commentModel.CreatedOn,
                Createby = commentModel.Createby,
                StockId = commentModel.StockId
            };
        }
        public static Comment ToCommentFromCreateDTO(this CreateCommentRequestDTO createCommentRequestDTO, int stockId)
        {
            return new Comment
            {
                Title = createCommentRequestDTO.Title,
                Content = createCommentRequestDTO.Content,
                StockId = stockId
            };
        }

        public static Comment ToCommentFromUpdateDTO(this UpdateCommentRequestDTO updateCommentRequestDTO, int stockId)
        {
            return new Comment
            {
                Title = updateCommentRequestDTO.Title,
                Content = updateCommentRequestDTO.Content,
                StockId = stockId
            };
        }
    }
}