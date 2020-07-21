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
    public class TutorialCattegoriesController : ControllerBase
    {
        private readonly AdventureContext _context;

        public TutorialCattegoriesController(AdventureContext context)
        {
            _context = context;
        }

        // GET: api/TutorialCattegories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TutorialCattegory>>> GetTutorialCattegory()
        {
            return await _context.TutorialCattegory.ToListAsync();
        }

        // GET: api/TutorialCattegories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TutorialCattegory>> GetTutorialCattegory(Guid id)
        {
            var tutorialCattegory = await _context.TutorialCattegory.FindAsync(id);

            if (tutorialCattegory == null)
            {
                return NotFound();
            }

            return tutorialCattegory;
        }

        // PUT: api/TutorialCattegories/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTutorialCattegory(Guid id, TutorialCattegory tutorialCattegory)
        {
            if (id != tutorialCattegory.Id)
            {
                return BadRequest();
            }

            _context.Entry(tutorialCattegory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TutorialCattegoryExists(id))
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

        // POST: api/TutorialCattegories
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TutorialCattegory>> PostTutorialCattegory(TutorialCattegory tutorialCattegory)
        {
            _context.TutorialCattegory.Add(tutorialCattegory);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TutorialCattegoryExists(tutorialCattegory.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTutorialCattegory", new { id = tutorialCattegory.Id }, tutorialCattegory);
        }

        // DELETE: api/TutorialCattegories/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TutorialCattegory>> DeleteTutorialCattegory(Guid id)
        {
            var tutorialCattegory = await _context.TutorialCattegory.FindAsync(id);
            if (tutorialCattegory == null)
            {
                return NotFound();
            }

            _context.TutorialCattegory.Remove(tutorialCattegory);
            await _context.SaveChangesAsync();

            return tutorialCattegory;
        }

        private bool TutorialCattegoryExists(Guid id)
        {
            return _context.TutorialCattegory.Any(e => e.Id == id);
        }
    }
}
