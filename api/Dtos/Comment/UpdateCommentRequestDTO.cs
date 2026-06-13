using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Comment
{
    public class UpdateCommentRequestDTO
    {
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Title must be between 2 and 100 characters.")]
        public string Title { get; set; } = string.Empty;
        [Required]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "Content must be between 2 and 200 characters.")]
        public string Content { get; set; } = string.Empty;
    }
}