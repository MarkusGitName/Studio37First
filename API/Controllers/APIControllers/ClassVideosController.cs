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
    public class ClassVideosController : ControllerBase
    {
        private readonly AdventureContext _context;

        public ClassVideosController(AdventureContext context)
        {
            _context = context;
        }

        // GET: api/ClassVideos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClassVideo>>> GetClassVideo()
        {
            return await _context.ClassVideo.ToListAsync();
        }

        // GET: api/ClassVideos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ClassVideo>> GetClassVideo(Guid id)
        {
            var classVideo = await _context.ClassVideo.FindAsync(id);

            if (classVideo == null)
            {
                return NotFound();
            }

            return classVideo;
        }

        // PUT: api/ClassVideos/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClassVideo(Guid id, ClassVideo classVideo)
        {
            if (id != classVideo.Id)
            {
                return BadRequest();
            }

            _context.Entry(classVideo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClassVideoExists(id))
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

        // POST: api/ClassVideos
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ClassVideo>> PostClassVideo(ClassVideo classVideo)
        {
            _context.ClassVideo.Add(classVideo);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ClassVideoExists(classVideo.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetClassVideo", new { id = classVideo.Id }, classVideo);
        }

        // DELETE: api/ClassVideos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ClassVideo>> DeleteClassVideo(Guid id)
        {
            var classVideo = await _context.ClassVideo.FindAsync(id);
            if (classVideo == null)
            {
                return NotFound();
            }

            _context.ClassVideo.Remove(classVideo);
            await _context.SaveChangesAsync();

            return classVideo;
        }

        private bool ClassVideoExists(Guid id)
        {
            return _context.ClassVideo.Any(e => e.Id == id);
        }
    }
}
