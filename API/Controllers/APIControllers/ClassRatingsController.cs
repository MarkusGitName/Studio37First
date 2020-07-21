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
    public class ClassRatingsController : ControllerBase
    {
        private readonly AdventureContext _context;

        public ClassRatingsController(AdventureContext context)
        {
            _context = context;
        }

        // GET: api/ClassRatings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClassRatings>>> GetClassRatings()
        {
            return await _context.ClassRatings.ToListAsync();
        }

        // GET: api/ClassRatings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ClassRatings>> GetClassRatings(Guid id)
        {
            var classRatings = await _context.ClassRatings.FindAsync(id);

            if (classRatings == null)
            {
                return NotFound();
            }

            return classRatings;
        }

        // PUT: api/ClassRatings/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClassRatings(Guid id, ClassRatings classRatings)
        {
            if (id != classRatings.Id)
            {
                return BadRequest();
            }

            _context.Entry(classRatings).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClassRatingsExists(id))
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

        // POST: api/ClassRatings
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ClassRatings>> PostClassRatings(ClassRatings classRatings)
        {
            _context.ClassRatings.Add(classRatings);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ClassRatingsExists(classRatings.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetClassRatings", new { id = classRatings.Id }, classRatings);
        }

        // DELETE: api/ClassRatings/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ClassRatings>> DeleteClassRatings(Guid id)
        {
            var classRatings = await _context.ClassRatings.FindAsync(id);
            if (classRatings == null)
            {
                return NotFound();
            }

            _context.ClassRatings.Remove(classRatings);
            await _context.SaveChangesAsync();

            return classRatings;
        }

        private bool ClassRatingsExists(Guid id)
        {
            return _context.ClassRatings.Any(e => e.Id == id);
        }
    }
}
