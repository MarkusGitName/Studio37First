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
    public class TutorialPromoVideosController : ControllerBase
    {
        private readonly AdventureContext _context;

        public TutorialPromoVideosController(AdventureContext context)
        {
            _context = context;
        }

        // GET: api/TutorialPromoVideos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TutorialPromoVideo>>> GetTutorialPromoVideo()
        {
            return await _context.TutorialPromoVideo.ToListAsync();
        }

        // GET: api/TutorialPromoVideos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TutorialPromoVideo>> GetTutorialPromoVideo(Guid id)
        {
            var tutorialPromoVideo = await _context.TutorialPromoVideo.FindAsync(id);

            if (tutorialPromoVideo == null)
            {
                return NotFound();
            }

            return tutorialPromoVideo;
        }

        // PUT: api/TutorialPromoVideos/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTutorialPromoVideo(Guid id, TutorialPromoVideo tutorialPromoVideo)
        {
            if (id != tutorialPromoVideo.Id)
            {
                return BadRequest();
            }

            _context.Entry(tutorialPromoVideo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TutorialPromoVideoExists(id))
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

        // POST: api/TutorialPromoVideos
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TutorialPromoVideo>> PostTutorialPromoVideo(TutorialPromoVideo tutorialPromoVideo)
        {
            _context.TutorialPromoVideo.Add(tutorialPromoVideo);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TutorialPromoVideoExists(tutorialPromoVideo.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTutorialPromoVideo", new { id = tutorialPromoVideo.Id }, tutorialPromoVideo);
        }

        // DELETE: api/TutorialPromoVideos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TutorialPromoVideo>> DeleteTutorialPromoVideo(Guid id)
        {
            var tutorialPromoVideo = await _context.TutorialPromoVideo.FindAsync(id);
            if (tutorialPromoVideo == null)
            {
                return NotFound();
            }

            _context.TutorialPromoVideo.Remove(tutorialPromoVideo);
            await _context.SaveChangesAsync();

            return tutorialPromoVideo;
        }

        private bool TutorialPromoVideoExists(Guid id)
        {
            return _context.TutorialPromoVideo.Any(e => e.Id == id);
        }
    }
}
