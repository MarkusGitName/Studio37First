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
    public class GoupMediaLinksController : ControllerBase
    {
        private readonly AdventureContext _context;

        public GoupMediaLinksController(AdventureContext context)
        {
            _context = context;
        }

        // GET: api/GoupMediaLinks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GoupMediaLink>>> GetGoupMediaLink()
        {
            return await _context.GoupMediaLink.ToListAsync();
        }

        // GET: api/GoupMediaLinks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GoupMediaLink>> GetGoupMediaLink(Guid id)
        {
            var goupMediaLink = await _context.GoupMediaLink.FindAsync(id);

            if (goupMediaLink == null)
            {
                return NotFound();
            }

            return goupMediaLink;
        }

        // PUT: api/GoupMediaLinks/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGoupMediaLink(Guid id, GoupMediaLink goupMediaLink)
        {
            if (id != goupMediaLink.Id)
            {
                return BadRequest();
            }

            _context.Entry(goupMediaLink).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GoupMediaLinkExists(id))
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

        // POST: api/GoupMediaLinks
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<GoupMediaLink>> PostGoupMediaLink(GoupMediaLink goupMediaLink)
        {
            _context.GoupMediaLink.Add(goupMediaLink);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (GoupMediaLinkExists(goupMediaLink.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetGoupMediaLink", new { id = goupMediaLink.Id }, goupMediaLink);
        }

        // DELETE: api/GoupMediaLinks/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<GoupMediaLink>> DeleteGoupMediaLink(Guid id)
        {
            var goupMediaLink = await _context.GoupMediaLink.FindAsync(id);
            if (goupMediaLink == null)
            {
                return NotFound();
            }

            _context.GoupMediaLink.Remove(goupMediaLink);
            await _context.SaveChangesAsync();

            return goupMediaLink;
        }

        private bool GoupMediaLinkExists(Guid id)
        {
            return _context.GoupMediaLink.Any(e => e.Id == id);
        }
    }
}
