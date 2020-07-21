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
    public class ProfesionalsDocumentsController : ControllerBase
    {
        private readonly AdventureContext _context;

        public ProfesionalsDocumentsController(AdventureContext context)
        {
            _context = context;
        }

        // GET: api/ProfesionalsDocuments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProfesionalsDocuments>>> GetProfesionalsDocuments()
        {
            return await _context.ProfesionalsDocuments.ToListAsync();
        }

        // GET: api/ProfesionalsDocuments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProfesionalsDocuments>> GetProfesionalsDocuments(Guid id)
        {
            var profesionalsDocuments = await _context.ProfesionalsDocuments.FindAsync(id);

            if (profesionalsDocuments == null)
            {
                return NotFound();
            }

            return profesionalsDocuments;
        }

        // PUT: api/ProfesionalsDocuments/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProfesionalsDocuments(Guid id, ProfesionalsDocuments profesionalsDocuments)
        {
            if (id != profesionalsDocuments.Id)
            {
                return BadRequest();
            }

            _context.Entry(profesionalsDocuments).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProfesionalsDocumentsExists(id))
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

        // POST: api/ProfesionalsDocuments
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ProfesionalsDocuments>> PostProfesionalsDocuments(ProfesionalsDocuments profesionalsDocuments)
        {
            _context.ProfesionalsDocuments.Add(profesionalsDocuments);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ProfesionalsDocumentsExists(profesionalsDocuments.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetProfesionalsDocuments", new { id = profesionalsDocuments.Id }, profesionalsDocuments);
        }

        // DELETE: api/ProfesionalsDocuments/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ProfesionalsDocuments>> DeleteProfesionalsDocuments(Guid id)
        {
            var profesionalsDocuments = await _context.ProfesionalsDocuments.FindAsync(id);
            if (profesionalsDocuments == null)
            {
                return NotFound();
            }

            _context.ProfesionalsDocuments.Remove(profesionalsDocuments);
            await _context.SaveChangesAsync();

            return profesionalsDocuments;
        }

        private bool ProfesionalsDocumentsExists(Guid id)
        {
            return _context.ProfesionalsDocuments.Any(e => e.Id == id);
        }
    }
}
