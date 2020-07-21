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
    public class ProfesionallsProfilesController : ControllerBase
    {
        private readonly AdventureContext _context;

        public ProfesionallsProfilesController(AdventureContext context)
        {
            _context = context;
        }

        // GET: api/ProfesionallsProfiles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProfesionallsProfile>>> GetProfesionallsProfile()
        {
            return await _context.ProfesionallsProfile.ToListAsync();
        }

        // GET: api/ProfesionallsProfiles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProfesionallsProfile>> GetProfesionallsProfile(string id)
        {
            var profesionallsProfile = await _context.ProfesionallsProfile.FindAsync(id);

            if (profesionallsProfile == null)
            {
                return NotFound();
            }

            return profesionallsProfile;
        }

        // PUT: api/ProfesionallsProfiles/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProfesionallsProfile(string id, ProfesionallsProfile profesionallsProfile)
        {
            if (id != profesionallsProfile.UserId)
            {
                return BadRequest();
            }

            _context.Entry(profesionallsProfile).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProfesionallsProfileExists(id))
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

        // POST: api/ProfesionallsProfiles
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ProfesionallsProfile>> PostProfesionallsProfile(ProfesionallsProfile profesionallsProfile)
        {
            _context.ProfesionallsProfile.Add(profesionallsProfile);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ProfesionallsProfileExists(profesionallsProfile.UserId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetProfesionallsProfile", new { id = profesionallsProfile.UserId }, profesionallsProfile);
        }

        // DELETE: api/ProfesionallsProfiles/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ProfesionallsProfile>> DeleteProfesionallsProfile(string id)
        {
            var profesionallsProfile = await _context.ProfesionallsProfile.FindAsync(id);
            if (profesionallsProfile == null)
            {
                return NotFound();
            }

            _context.ProfesionallsProfile.Remove(profesionallsProfile);
            await _context.SaveChangesAsync();

            return profesionallsProfile;
        }

        private bool ProfesionallsProfileExists(string id)
        {
            return _context.ProfesionallsProfile.Any(e => e.UserId == id);
        }
    }
}
