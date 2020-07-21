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
    public class StickersController : ControllerBase
    {
        private readonly AdventureContext _context;

        public StickersController(AdventureContext context)
        {
            _context = context;
        }

        // GET: api/Stickers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Stickers>>> GetStickers()
        {
            return await _context.Stickers.ToListAsync();
        }

        // GET: api/Stickers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Stickers>> GetStickers(Guid id)
        {
            var stickers = await _context.Stickers.FindAsync(id);

            if (stickers == null)
            {
                return NotFound();
            }

            return stickers;
        }

        // PUT: api/Stickers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStickers(Guid id, Stickers stickers)
        {
            if (id != stickers.Id)
            {
                return BadRequest();
            }

            _context.Entry(stickers).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StickersExists(id))
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

        // POST: api/Stickers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Stickers>> PostStickers(Stickers stickers)
        {
            _context.Stickers.Add(stickers);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (StickersExists(stickers.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetStickers", new { id = stickers.Id }, stickers);
        }

        // DELETE: api/Stickers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Stickers>> DeleteStickers(Guid id)
        {
            var stickers = await _context.Stickers.FindAsync(id);
            if (stickers == null)
            {
                return NotFound();
            }

            _context.Stickers.Remove(stickers);
            await _context.SaveChangesAsync();

            return stickers;
        }

        private bool StickersExists(Guid id)
        {
            return _context.Stickers.Any(e => e.Id == id);
        }
    }
}
