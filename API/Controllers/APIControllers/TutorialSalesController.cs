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
    public class TutorialSalesController : ControllerBase
    {
        private readonly AdventureContext _context;

        public TutorialSalesController(AdventureContext context)
        {
            _context = context;
        }

        // GET: api/TutorialSales
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TutorialSale>>> GetTutorialSale()
        {
            return await _context.TutorialSale.ToListAsync();
        }

        // GET: api/TutorialSales/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TutorialSale>> GetTutorialSale(Guid id)
        {
            var tutorialSale = await _context.TutorialSale.FindAsync(id);

            if (tutorialSale == null)
            {
                return NotFound();
            }

            return tutorialSale;
        }

        // PUT: api/TutorialSales/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTutorialSale(Guid id, TutorialSale tutorialSale)
        {
            if (id != tutorialSale.Id)
            {
                return BadRequest();
            }

            _context.Entry(tutorialSale).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TutorialSaleExists(id))
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

        // POST: api/TutorialSales
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TutorialSale>> PostTutorialSale(TutorialSale tutorialSale)
        {
            _context.TutorialSale.Add(tutorialSale);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TutorialSaleExists(tutorialSale.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTutorialSale", new { id = tutorialSale.Id }, tutorialSale);
        }

        // DELETE: api/TutorialSales/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TutorialSale>> DeleteTutorialSale(Guid id)
        {
            var tutorialSale = await _context.TutorialSale.FindAsync(id);
            if (tutorialSale == null)
            {
                return NotFound();
            }

            _context.TutorialSale.Remove(tutorialSale);
            await _context.SaveChangesAsync();

            return tutorialSale;
        }

        private bool TutorialSaleExists(Guid id)
        {
            return _context.TutorialSale.Any(e => e.Id == id);
        }
    }
}
