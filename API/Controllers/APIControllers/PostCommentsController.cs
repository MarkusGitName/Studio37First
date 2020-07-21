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
    public class PostCommentsController : ControllerBase
    {
        private readonly AdventureContext _context;

        public PostCommentsController(AdventureContext context)
        {
            _context = context;
        }

        // GET: api/PostComments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PostComments>>> GetPostComments()
        {
            return await _context.PostComments.ToListAsync();
        }

        // GET: api/PostComments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PostComments>> GetPostComments(Guid id)
        {
            var postComments = await _context.PostComments.FindAsync(id);

            if (postComments == null)
            {
                return NotFound();
            }

            return postComments;
        }

        // PUT: api/PostComments/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPostComments(Guid id, PostComments postComments)
        {
            if (id != postComments.Id)
            {
                return BadRequest();
            }

            _context.Entry(postComments).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PostCommentsExists(id))
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

        // POST: api/PostComments
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<PostComments>> PostPostComments(PostComments postComments)
        {
            _context.PostComments.Add(postComments);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PostCommentsExists(postComments.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPostComments", new { id = postComments.Id }, postComments);
        }

        // DELETE: api/PostComments/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PostComments>> DeletePostComments(Guid id)
        {
            var postComments = await _context.PostComments.FindAsync(id);
            if (postComments == null)
            {
                return NotFound();
            }

            _context.PostComments.Remove(postComments);
            await _context.SaveChangesAsync();

            return postComments;
        }

        private bool PostCommentsExists(Guid id)
        {
            return _context.PostComments.Any(e => e.Id == id);
        }
    }
}
