using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Model;

namespace API.Controllers.APIControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentLikesController : ControllerBase
    {
        private readonly AdventureContext _context;

        public CommentLikesController(AdventureContext context)
        {
            _context = context;
        }

        // GET: api/CommentLikes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CommentLikes>>> GetCommentLikes()
        {
            return await _context.CommentLikes.ToListAsync();
        }

        // GET: api/CommentLikes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CommentLikes>> GetCommentLikes(Guid id)
        {
            var commentLikes = await _context.CommentLikes.FindAsync(id);

            if (commentLikes == null)
            {
                return NotFound();
            }

            return commentLikes;
        }

        // PUT: api/CommentLikes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCommentLikes(Guid id, CommentLikes commentLikes)
        {
            if (id != commentLikes.CommentId)
            {
                return BadRequest();
            }

            _context.Entry(commentLikes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CommentLikesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/CommentLikes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CommentLikes>> PostCommentLikes(CommentLikes commentLikes)
        {
            _context.CommentLikes.Add(commentLikes);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CommentLikesExists(commentLikes.CommentId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCommentLikes", new { id = commentLikes.CommentId }, commentLikes);
        }

        // DELETE: api/CommentLikes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CommentLikes>> DeleteCommentLikes(Guid id)
        {
            var commentLikes = await _context.CommentLikes.FindAsync(id);
            if (commentLikes == null)
            {
                return NotFound();
            }

            _context.CommentLikes.Remove(commentLikes);
            await _context.SaveChangesAsync();

            return commentLikes;
        }

        private bool CommentLikesExists(Guid id)
        {
            return _context.CommentLikes.Any(e => e.CommentId == id);
        }
    }
}
