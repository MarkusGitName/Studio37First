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
    public class TutorialPromoPhotoesController : ControllerBase
    {
        private readonly AdventureContext _context;

        public TutorialPromoPhotoesController(AdventureContext context)
        {
            _context = context;
        }

        // GET: api/TutorialPromoPhotoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TutorialPromoPhoto>>> GetTutorialPromoPhoto()
        {
            return await _context.TutorialPromoPhoto.ToListAsync();
        }

        // GET: api/TutorialPromoPhotoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TutorialPromoPhoto>> GetTutorialPromoPhoto(Guid id)
        {
            var tutorialPromoPhoto = await _context.TutorialPromoPhoto.FindAsync(id);

            if (tutorialPromoPhoto == null)
            {
                return NotFound();
            }

            return tutorialPromoPhoto;
        }

        // PUT: api/TutorialPromoPhotoes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTutorialPromoPhoto(Guid id, TutorialPromoPhoto tutorialPromoPhoto)
        {
            if (id != tutorialPromoPhoto.Id)
            {
                return BadRequest();
            }

            _context.Entry(tutorialPromoPhoto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TutorialPromoPhotoExists(id))
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

        // POST: api/TutorialPromoPhotoes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TutorialPromoPhoto>> PostTutorialPromoPhoto(TutorialPromoPhoto tutorialPromoPhoto)
        {
            _context.TutorialPromoPhoto.Add(tutorialPromoPhoto);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TutorialPromoPhotoExists(tutorialPromoPhoto.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTutorialPromoPhoto", new { id = tutorialPromoPhoto.Id }, tutorialPromoPhoto);
        }

        // DELETE: api/TutorialPromoPhotoes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TutorialPromoPhoto>> DeleteTutorialPromoPhoto(Guid id)
        {
            var tutorialPromoPhoto = await _context.TutorialPromoPhoto.FindAsync(id);
            if (tutorialPromoPhoto == null)
            {
                return NotFound();
            }

            _context.TutorialPromoPhoto.Remove(tutorialPromoPhoto);
            await _context.SaveChangesAsync();

            return tutorialPromoPhoto;
        }

        private bool TutorialPromoPhotoExists(Guid id)
        {
            return _context.TutorialPromoPhoto.Any(e => e.Id == id);
        }
    }
}
