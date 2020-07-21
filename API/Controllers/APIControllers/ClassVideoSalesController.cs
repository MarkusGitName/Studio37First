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
    public class ClassVideoSalesController : ControllerBase
    {
        private readonly AdventureContext _context;

        public ClassVideoSalesController(AdventureContext context)
        {
            _context = context;
        }

        // GET: api/ClassVideoSales
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClassVideoSale>>> GetClassVideoSale()
        {
            return await _context.ClassVideoSale.ToListAsync();
        }

        // GET: api/ClassVideoSales/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ClassVideoSale>> GetClassVideoSale(Guid id)
        {
            var classVideoSale = await _context.ClassVideoSale.FindAsync(id);

            if (classVideoSale == null)
            {
                return NotFound();
            }

            return classVideoSale;
        }

        // PUT: api/ClassVideoSales/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClassVideoSale(Guid id, ClassVideoSale classVideoSale)
        {
            if (id != classVideoSale.Id)
            {
                return BadRequest();
            }

            _context.Entry(classVideoSale).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClassVideoSaleExists(id))
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

        // POST: api/ClassVideoSales
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ClassVideoSale>> PostClassVideoSale(ClassVideoSale classVideoSale)
        {
            _context.ClassVideoSale.Add(classVideoSale);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ClassVideoSaleExists(classVideoSale.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetClassVideoSale", new { id = classVideoSale.Id }, classVideoSale);
        }

        // DELETE: api/ClassVideoSales/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ClassVideoSale>> DeleteClassVideoSale(Guid id)
        {
            var classVideoSale = await _context.ClassVideoSale.FindAsync(id);
            if (classVideoSale == null)
            {
                return NotFound();
            }

            _context.ClassVideoSale.Remove(classVideoSale);
            await _context.SaveChangesAsync();

            return classVideoSale;
        }

        private bool ClassVideoSaleExists(Guid id)
        {
            return _context.ClassVideoSale.Any(e => e.Id == id);
        }
    }
}
