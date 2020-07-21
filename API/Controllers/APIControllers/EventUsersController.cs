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
    public class EventUsersController : ControllerBase
    {
        private readonly AdventureContext _context;

        public EventUsersController(AdventureContext context)
        {
            _context = context;
        }

        // GET: api/EventUsers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EventUsers>>> GetEventUsers()
        {
            return await _context.EventUsers.ToListAsync();
        }

        // GET: api/EventUsers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EventUsers>> GetEventUsers(Guid id)
        {
            var eventUsers = await _context.EventUsers.FindAsync(id);

            if (eventUsers == null)
            {
                return NotFound();
            }

            return eventUsers;
        }

        // PUT: api/EventUsers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEventUsers(Guid id, EventUsers eventUsers)
        {
            if (id != eventUsers.Id)
            {
                return BadRequest();
            }

            _context.Entry(eventUsers).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventUsersExists(id))
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

        // POST: api/EventUsers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EventUsers>> PostEventUsers(EventUsers eventUsers)
        {
            _context.EventUsers.Add(eventUsers);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EventUsersExists(eventUsers.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEventUsers", new { id = eventUsers.Id }, eventUsers);
        }

        // DELETE: api/EventUsers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EventUsers>> DeleteEventUsers(Guid id)
        {
            var eventUsers = await _context.EventUsers.FindAsync(id);
            if (eventUsers == null)
            {
                return NotFound();
            }

            _context.EventUsers.Remove(eventUsers);
            await _context.SaveChangesAsync();

            return eventUsers;
        }

        private bool EventUsersExists(Guid id)
        {
            return _context.EventUsers.Any(e => e.Id == id);
        }
    }
}
