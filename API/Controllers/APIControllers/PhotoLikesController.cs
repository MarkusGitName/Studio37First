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
    public class PhotoLikesController : ControllerBase
    {
        private readonly AdventureContext _context;

        public PhotoLikesController(AdventureContext context)
        {
            _context = context;
        }

        // GET: api/PhotoLikes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PhotoLike>>> GetPhotoLike()
        {
            return await _context.PhotoLike.ToListAsync();
        }

        // GET: api/PhotoLikes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PhotoLike>> GetPhotoLike(Guid id)
        {
            var photoLike = await _context.PhotoLike.FindAsync(id);

            if (photoLike == null)
            {
                return NotFound();
            }

            return photoLike;
        }

        // PUT: api/PhotoLikes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPhotoLike(Guid id, PhotoLike photoLike)
        {
            if (id != photoLike.PhotoId)
            {
                return BadRequest();
            }

            _context.Entry(photoLike).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PhotoLikeExists(id))
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

        // POST: api/PhotoLikes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<PhotoLike>> PostPhotoLike(PhotoLike photoLike)
        {
            _context.PhotoLike.Add(photoLike);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PhotoLikeExists(photoLike.PhotoId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPhotoLike", new { id = photoLike.PhotoId }, photoLike);
        }

        // DELETE: api/PhotoLikes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PhotoLike>> DeletePhotoLike(Guid id)
        {
            var photoLike = await _context.PhotoLike.FindAsync(id);
            if (photoLike == null)
            {
                return NotFound();
            }

            _context.PhotoLike.Remove(photoLike);
            await _context.SaveChangesAsync();

            return photoLike;
        }

        private bool PhotoLikeExists(Guid id)
        {
            return _context.PhotoLike.Any(e => e.PhotoId == id);
        }
    }
}
