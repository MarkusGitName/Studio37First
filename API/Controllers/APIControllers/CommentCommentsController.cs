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
    public class CommentCommentsController : ControllerBase
    {
        private readonly AdventureContext _context;

        public CommentCommentsController(AdventureContext context)
        {
            _context = context;
        }

        // GET: api/CommentComments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CommentComments>>> GetCommentComments()
        {
            return await _context.CommentComments.ToListAsync();
        }

        // GET: api/CommentComments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CommentComments>> GetCommentComments(Guid id)
        {
            var commentComments = await _context.CommentComments.FindAsync(id);

            if (commentComments == null)
            {
                return NotFound();
            }

            return commentComments;
        }

        // PUT: api/CommentComments/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCommentComments(Guid id, CommentComments commentComments)
        {
            if (id != commentComments.Id)
            {
                return BadRequest();
            }

            _context.Entry(commentComments).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CommentCommentsExists(id))
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

        // POST: api/CommentComments
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CommentComments>> PostCommentComments(CommentComments commentComments)
        {
            _context.CommentComments.Add(commentComments);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CommentCommentsExists(commentComments.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCommentComments", new { id = commentComments.Id }, commentComments);
        }

        // DELETE: api/CommentComments/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CommentComments>> DeleteCommentComments(Guid id)
        {
            var commentComments = await _context.CommentComments.FindAsync(id);
            if (commentComments == null)
            {
                return NotFound();
            }

            _context.CommentComments.Remove(commentComments);
            await _context.SaveChangesAsync();

            return commentComments;
        }

        private bool CommentCommentsExists(Guid id)
        {
            return _context.CommentComments.Any(e => e.Id == id);
        }
    }
}
