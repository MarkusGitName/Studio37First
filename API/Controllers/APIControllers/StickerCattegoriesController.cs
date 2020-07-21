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
    public class StickerCattegoriesController : ControllerBase
    {
        private readonly AdventureContext _context;

        public StickerCattegoriesController(AdventureContext context)
        {
            _context = context;
        }

        // GET: api/StickerCattegories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StickerCattegory>>> GetStickerCattegory()
        {
            return await _context.StickerCattegory.ToListAsync();
        }

        // GET: api/StickerCattegories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StickerCattegory>> GetStickerCattegory(Guid id)
        {
            var stickerCattegory = await _context.StickerCattegory.FindAsync(id);

            if (stickerCattegory == null)
            {
                return NotFound();
            }

            return stickerCattegory;
        }

        // PUT: api/StickerCattegories/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStickerCattegory(Guid id, StickerCattegory stickerCattegory)
        {
            if (id != stickerCattegory.Id)
            {
                return BadRequest();
            }

            _context.Entry(stickerCattegory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StickerCattegoryExists(id))
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

        // POST: api/StickerCattegories
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<StickerCattegory>> PostStickerCattegory(StickerCattegory stickerCattegory)
        {
            _context.StickerCattegory.Add(stickerCattegory);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (StickerCattegoryExists(stickerCattegory.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetStickerCattegory", new { id = stickerCattegory.Id }, stickerCattegory);
        }

        // DELETE: api/StickerCattegories/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<StickerCattegory>> DeleteStickerCattegory(Guid id)
        {
            var stickerCattegory = await _context.StickerCattegory.FindAsync(id);
            if (stickerCattegory == null)
            {
                return NotFound();
            }

            _context.StickerCattegory.Remove(stickerCattegory);
            await _context.SaveChangesAsync();

            return stickerCattegory;
        }

        private bool StickerCattegoryExists(Guid id)
        {
            return _context.StickerCattegory.Any(e => e.Id == id);
        }
    }
}
