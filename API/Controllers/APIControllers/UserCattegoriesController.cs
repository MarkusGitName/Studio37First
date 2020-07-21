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
    public class UserCattegoriesController : ControllerBase
    {
        private readonly AdventureContext _context;

        public UserCattegoriesController(AdventureContext context)
        {
            _context = context;
        }

        // GET: api/UserCattegories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserCattegory>>> GetUserCattegory()
        {
            return await _context.UserCattegory.ToListAsync();
        }

        // GET: api/UserCattegories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserCattegory>> GetUserCattegory(Guid id)
        {
            var userCattegory = await _context.UserCattegory.FindAsync(id);

            if (userCattegory == null)
            {
                return NotFound();
            }

            return userCattegory;
        }

        // PUT: api/UserCattegories/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserCattegory(Guid id, UserCattegory userCattegory)
        {
            if (id != userCattegory.Id)
            {
                return BadRequest();
            }

            _context.Entry(userCattegory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserCattegoryExists(id))
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

        // POST: api/UserCattegories
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<UserCattegory>> PostUserCattegory(UserCattegory userCattegory)
        {
            _context.UserCattegory.Add(userCattegory);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (UserCattegoryExists(userCattegory.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetUserCattegory", new { id = userCattegory.Id }, userCattegory);
        }

        // DELETE: api/UserCattegories/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<UserCattegory>> DeleteUserCattegory(Guid id)
        {
            var userCattegory = await _context.UserCattegory.FindAsync(id);
            if (userCattegory == null)
            {
                return NotFound();
            }

            _context.UserCattegory.Remove(userCattegory);
            await _context.SaveChangesAsync();

            return userCattegory;
        }

        private bool UserCattegoryExists(Guid id)
        {
            return _context.UserCattegory.Any(e => e.Id == id);
        }
    }
}
