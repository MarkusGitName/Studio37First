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
    public class PostCattegoriesController : ControllerBase
    {
        private readonly AdventureContext _context;

        public PostCattegoriesController(AdventureContext context)
        {
            _context = context;
        }

        // GET: api/PostCattegories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PostCattegory>>> GetPostCattegory()
        {
            return await _context.PostCattegory.ToListAsync();
        }

        // GET: api/PostCattegories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PostCattegory>> GetPostCattegory(Guid id)
        {
            var postCattegory = await _context.PostCattegory.FindAsync(id);

            if (postCattegory == null)
            {
                return NotFound();
            }

            return postCattegory;
        }

        // PUT: api/PostCattegories/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPostCattegory(Guid id, PostCattegory postCattegory)
        {
            if (id != postCattegory.Id)
            {
                return BadRequest();
            }

            _context.Entry(postCattegory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PostCattegoryExists(id))
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

        // POST: api/PostCattegories
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<PostCattegory>> PostPostCattegory(PostCattegory postCattegory)
        {
            _context.PostCattegory.Add(postCattegory);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PostCattegoryExists(postCattegory.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPostCattegory", new { id = postCattegory.Id }, postCattegory);
        }

        // DELETE: api/PostCattegories/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PostCattegory>> DeletePostCattegory(Guid id)
        {
            var postCattegory = await _context.PostCattegory.FindAsync(id);
            if (postCattegory == null)
            {
                return NotFound();
            }

            _context.PostCattegory.Remove(postCattegory);
            await _context.SaveChangesAsync();

            return postCattegory;
        }

        private bool PostCattegoryExists(Guid id)
        {
            return _context.PostCattegory.Any(e => e.Id == id);
        }
    }
}
