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
    public class EventGroupsController : ControllerBase
    {
        private readonly AdventureContext _context;

        public EventGroupsController(AdventureContext context)
        {
            _context = context;
        }

        // GET: api/EventGroups
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EventGroups>>> GetEventGroups()
        {
            return await _context.EventGroups.ToListAsync();
        }

        // GET: api/EventGroups/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EventGroups>> GetEventGroups(Guid id)
        {
            var eventGroups = await _context.EventGroups.FindAsync(id);

            if (eventGroups == null)
            {
                return NotFound();
            }

            return eventGroups;
        }

        // PUT: api/EventGroups/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEventGroups(Guid id, EventGroups eventGroups)
        {
            if (id != eventGroups.Id)
            {
                return BadRequest();
            }

            _context.Entry(eventGroups).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventGroupsExists(id))
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

        // POST: api/EventGroups
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EventGroups>> PostEventGroups(EventGroups eventGroups)
        {
            _context.EventGroups.Add(eventGroups);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EventGroupsExists(eventGroups.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEventGroups", new { id = eventGroups.Id }, eventGroups);
        }

        // DELETE: api/EventGroups/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EventGroups>> DeleteEventGroups(Guid id)
        {
            var eventGroups = await _context.EventGroups.FindAsync(id);
            if (eventGroups == null)
            {
                return NotFound();
            }

            _context.EventGroups.Remove(eventGroups);
            await _context.SaveChangesAsync();

            return eventGroups;
        }

        private bool EventGroupsExists(Guid id)
        {
            return _context.EventGroups.Any(e => e.Id == id);
        }
    }
}
