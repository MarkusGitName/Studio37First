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
    public class PostPhotosController : ControllerBase
    {
        private readonly AdventureContext _context;

        public PostPhotosController(AdventureContext context)
        {
            _context = context;
        }

        // GET: api/PostPhotos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PostPhotos>>> GetPostPhotos()
        {
            return await _context.PostPhotos.ToListAsync();
        }

        // GET: api/PostPhotos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PostPhotos>> GetPostPhotos(Guid id)
        {
            var postPhotos = await _context.PostPhotos.FindAsync(id);

            if (postPhotos == null)
            {
                return NotFound();
            }

            return postPhotos;
        }

        // PUT: api/PostPhotos/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPostPhotos(Guid id, PostPhotos postPhotos)
        {
            if (id != postPhotos.Id)
            {
                return BadRequest();
            }

            _context.Entry(postPhotos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PostPhotosExists(id))
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

        // POST: api/PostPhotos
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<PostPhotos>> PostPostPhotos(PostPhotos postPhotos)
        {
            _context.PostPhotos.Add(postPhotos);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PostPhotosExists(postPhotos.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPostPhotos", new { id = postPhotos.Id }, postPhotos);
        }

        // DELETE: api/PostPhotos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PostPhotos>> DeletePostPhotos(Guid id)
        {
            var postPhotos = await _context.PostPhotos.FindAsync(id);
            if (postPhotos == null)
            {
                return NotFound();
            }

            _context.PostPhotos.Remove(postPhotos);
            await _context.SaveChangesAsync();

            return postPhotos;
        }

        private bool PostPhotosExists(Guid id)
        {
            return _context.PostPhotos.Any(e => e.Id == id);
        }
    }
}
