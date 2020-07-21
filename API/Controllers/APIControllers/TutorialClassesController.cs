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
    public class TutorialClassesController : ControllerBase
    {
        private readonly AdventureContext _context;

        public TutorialClassesController(AdventureContext context)
        {
            _context = context;
        }

        // GET: api/TutorialClasses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TutorialClasses>>> GetTutorialClasses()
        {
            return await _context.TutorialClasses.ToListAsync();
        }

        // GET: api/TutorialClasses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TutorialClasses>> GetTutorialClasses(Guid id)
        {
            var tutorialClasses = await _context.TutorialClasses.FindAsync(id);

            if (tutorialClasses == null)
            {
                return NotFound();
            }

            return tutorialClasses;
        }

        // PUT: api/TutorialClasses/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTutorialClasses(Guid id, TutorialClasses tutorialClasses)
        {
            if (id != tutorialClasses.Id)
            {
                return BadRequest();
            }

            _context.Entry(tutorialClasses).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TutorialClassesExists(id))
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

        // POST: api/TutorialClasses
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TutorialClasses>> PostTutorialClasses(TutorialClasses tutorialClasses)
        {
            _context.TutorialClasses.Add(tutorialClasses);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TutorialClassesExists(tutorialClasses.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTutorialClasses", new { id = tutorialClasses.Id }, tutorialClasses);
        }

        // DELETE: api/TutorialClasses/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TutorialClasses>> DeleteTutorialClasses(Guid id)
        {
            var tutorialClasses = await _context.TutorialClasses.FindAsync(id);
            if (tutorialClasses == null)
            {
                return NotFound();
            }

            _context.TutorialClasses.Remove(tutorialClasses);
            await _context.SaveChangesAsync();

            return tutorialClasses;
        }

        private bool TutorialClassesExists(Guid id)
        {
            return _context.TutorialClasses.Any(e => e.Id == id);
        }
    }
}
