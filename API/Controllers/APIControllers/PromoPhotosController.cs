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
    public class PromoPhotosController : ControllerBase
    {
        private readonly AdventureContext _context;

        public PromoPhotosController(AdventureContext context)
        {
            _context = context;
        }

        // GET: api/PromoPhotos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PromoPhotos>>> GetPromoPhotos()
        {
            return await _context.PromoPhotos.ToListAsync();
        }

        // GET: api/PromoPhotos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PromoPhotos>> GetPromoPhotos(Guid id)
        {
            var promoPhotos = await _context.PromoPhotos.FindAsync(id);

            if (promoPhotos == null)
            {
                return NotFound();
            }

            return promoPhotos;
        }

        // PUT: api/PromoPhotos/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPromoPhotos(Guid id, PromoPhotos promoPhotos)
        {
            if (id != promoPhotos.Id)
            {
                return BadRequest();
            }

            _context.Entry(promoPhotos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PromoPhotosExists(id))
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

        // POST: api/PromoPhotos
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<PromoPhotos>> PostPromoPhotos(PromoPhotos promoPhotos)
        {
            _context.PromoPhotos.Add(promoPhotos);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PromoPhotosExists(promoPhotos.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPromoPhotos", new { id = promoPhotos.Id }, promoPhotos);
        }

        // DELETE: api/PromoPhotos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PromoPhotos>> DeletePromoPhotos(Guid id)
        {
            var promoPhotos = await _context.PromoPhotos.FindAsync(id);
            if (promoPhotos == null)
            {
                return NotFound();
            }

            _context.PromoPhotos.Remove(promoPhotos);
            await _context.SaveChangesAsync();

            return promoPhotos;
        }

        private bool PromoPhotosExists(Guid id)
        {
            return _context.PromoPhotos.Any(e => e.Id == id);
        }
    }
}
