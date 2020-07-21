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
    public class PostVideosController : ControllerBase
    {
        private readonly AdventureContext _context;

        public PostVideosController(AdventureContext context)
        {
            _context = context;
        }

        // GET: api/PostVideos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PostVideo>>> GetPostVideo()
        {
            return await _context.PostVideo.ToListAsync();
        }

        // GET: api/PostVideos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PostVideo>> GetPostVideo(Guid id)
        {
            var postVideo = await _context.PostVideo.FindAsync(id);

            if (postVideo == null)
            {
                return NotFound();
            }

            return postVideo;
        }

        // PUT: api/PostVideos/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPostVideo(Guid id, PostVideo postVideo)
        {
            if (id != postVideo.Id)
            {
                return BadRequest();
            }

            _context.Entry(postVideo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PostVideoExists(id))
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

        // POST: api/PostVideos
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<PostVideo>> PostPostVideo(PostVideo postVideo)
        {
            _context.PostVideo.Add(postVideo);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PostVideoExists(postVideo.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPostVideo", new { id = postVideo.Id }, postVideo);
        }

        // DELETE: api/PostVideos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PostVideo>> DeletePostVideo(Guid id)
        {
            var postVideo = await _context.PostVideo.FindAsync(id);
            if (postVideo == null)
            {
                return NotFound();
            }

            _context.PostVideo.Remove(postVideo);
            await _context.SaveChangesAsync();

            return postVideo;
        }

        private bool PostVideoExists(Guid id)
        {
            return _context.PostVideo.Any(e => e.Id == id);
        }
    }
}
