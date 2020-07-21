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
    public class PostLikesController : ControllerBase
    {
        private readonly AdventureContext _context;

        public PostLikesController(AdventureContext context)
        {
            _context = context;
        }

        // GET: api/PostLikes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PostLike>>> GetPostLike()
        {
            return await _context.PostLike.ToListAsync();
        }

        // GET: api/PostLikes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PostLike>> GetPostLike(Guid id)
        {
            var postLike = await _context.PostLike.FindAsync(id);

            if (postLike == null)
            {
                return NotFound();
            }

            return postLike;
        }

        // PUT: api/PostLikes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPostLike(Guid id, PostLike postLike)
        {
            if (id != postLike.PostId)
            {
                return BadRequest();
            }

            _context.Entry(postLike).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PostLikeExists(id))
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

        // POST: api/PostLikes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<PostLike>> PostPostLike(PostLike postLike)
        {
            _context.PostLike.Add(postLike);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PostLikeExists(postLike.PostId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPostLike", new { id = postLike.PostId }, postLike);
        }

        // DELETE: api/PostLikes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PostLike>> DeletePostLike(Guid id)
        {
            var postLike = await _context.PostLike.FindAsync(id);
            if (postLike == null)
            {
                return NotFound();
            }

            _context.PostLike.Remove(postLike);
            await _context.SaveChangesAsync();

            return postLike;
        }

        private bool PostLikeExists(Guid id)
        {
            return _context.PostLike.Any(e => e.PostId == id);
        }
    }
}
