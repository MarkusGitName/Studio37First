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
    public class TutorialRatingsController : ControllerBase
    {
        private readonly AdventureContext _context;

        public TutorialRatingsController(AdventureContext context)
        {
            _context = context;
        }

        // GET: api/TutorialRatings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TutorialRating>>> GetTutorialRating()
        {
            return await _context.TutorialRating.ToListAsync();
        }

        // GET: api/TutorialRatings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TutorialRating>> GetTutorialRating(Guid id)
        {
            var tutorialRating = await _context.TutorialRating.FindAsync(id);

            if (tutorialRating == null)
            {
                return NotFound();
            }

            return tutorialRating;
        }

        // PUT: api/TutorialRatings/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTutorialRating(Guid id, TutorialRating tutorialRating)
        {
            if (id != tutorialRating.Id)
            {
                return BadRequest();
            }

            _context.Entry(tutorialRating).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TutorialRatingExists(id))
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

        // POST: api/TutorialRatings
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TutorialRating>> PostTutorialRating(TutorialRating tutorialRating)
        {
            _context.TutorialRating.Add(tutorialRating);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TutorialRatingExists(tutorialRating.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTutorialRating", new { id = tutorialRating.Id }, tutorialRating);
        }

        // DELETE: api/TutorialRatings/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TutorialRating>> DeleteTutorialRating(Guid id)
        {
            var tutorialRating = await _context.TutorialRating.FindAsync(id);
            if (tutorialRating == null)
            {
                return NotFound();
            }

            _context.TutorialRating.Remove(tutorialRating);
            await _context.SaveChangesAsync();

            return tutorialRating;
        }

        private bool TutorialRatingExists(Guid id)
        {
            return _context.TutorialRating.Any(e => e.Id == id);
        }
    }
}
