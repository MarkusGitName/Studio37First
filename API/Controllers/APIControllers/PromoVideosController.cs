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
    public class PromoVideosController : ControllerBase
    {
        private readonly AdventureContext _context;

        public PromoVideosController(AdventureContext context)
        {
            _context = context;
        }

        // GET: api/PromoVideos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PromoVideos>>> GetPromoVideos()
        {
            return await _context.PromoVideos.ToListAsync();
        }

        // GET: api/PromoVideos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PromoVideos>> GetPromoVideos(Guid id)
        {
            var promoVideos = await _context.PromoVideos.FindAsync(id);

            if (promoVideos == null)
            {
                return NotFound();
            }

            return promoVideos;
        }

        // PUT: api/PromoVideos/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPromoVideos(Guid id, PromoVideos promoVideos)
        {
            if (id != promoVideos.Id)
            {
                return BadRequest();
            }

            _context.Entry(promoVideos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PromoVideosExists(id))
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

        // POST: api/PromoVideos
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<PromoVideos>> PostPromoVideos(PromoVideos promoVideos)
        {
            _context.PromoVideos.Add(promoVideos);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PromoVideosExists(promoVideos.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPromoVideos", new { id = promoVideos.Id }, promoVideos);
        }

        // DELETE: api/PromoVideos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PromoVideos>> DeletePromoVideos(Guid id)
        {
            var promoVideos = await _context.PromoVideos.FindAsync(id);
            if (promoVideos == null)
            {
                return NotFound();
            }

            _context.PromoVideos.Remove(promoVideos);
            await _context.SaveChangesAsync();

            return promoVideos;
        }

        private bool PromoVideosExists(Guid id)
        {
            return _context.PromoVideos.Any(e => e.Id == id);
        }
    }
}
