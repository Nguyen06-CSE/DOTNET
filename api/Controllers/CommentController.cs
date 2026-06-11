using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos.Comment;
using api.Interface;
using api.Mapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ILogger<CommentController> _logger;
        private readonly ApplicationDBContext _context;
        private readonly ICommentsRepository _commentsRepository;

        public CommentController(ILogger<CommentController> logger, ApplicationDBContext context, ICommentsRepository commentsRepository)
        {
            _logger = logger;
            _context = context;
            _commentsRepository = commentsRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll ()
        {
            var comments = await _commentsRepository.GetAllComments();
            var commentDTOs = comments.Select(c => c.ToCommentDTO());
            return Ok(comments);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var comment = await _commentsRepository.GetCommentById(id);
            if (comment == null)
            {
                return NotFound();
            }
            return Ok(comment);
        }

        [HttpPost]
        public async Task<IActionResult>     Create([FromBody] CreateCommentRequestDTO createCommentRequestDTO)
        {
            var comment = createCommentRequestDTO.ToCommentFromCreateDTO();
            await _commentsRepository.AddComment(comment);
            return CreatedAtAction(nameof(GetById), new { id = comment.Id }, comment);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var comment = await _commentsRepository.DeleteComment(id);
            if (comment == null)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}