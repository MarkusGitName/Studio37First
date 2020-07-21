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
    public class UserSocialMediaLinksController : ControllerBase
    {
        private readonly AdventureContext _context;

        public UserSocialMediaLinksController(AdventureContext context)
        {
            _context = context;
        }

        // GET: api/UserSocialMediaLinks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserSocialMediaLinks>>> GetUserSocialMediaLinks()
        {
            return await _context.UserSocialMediaLinks.ToListAsync();
        }

        // GET: api/UserSocialMediaLinks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserSocialMediaLinks>> GetUserSocialMediaLinks(Guid id)
        {
            var userSocialMediaLinks = await _context.UserSocialMediaLinks.FindAsync(id);

            if (userSocialMediaLinks == null)
            {
                return NotFound();
            }

            return userSocialMediaLinks;
        }

        // PUT: api/UserSocialMediaLinks/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserSocialMediaLinks(Guid id, UserSocialMediaLinks userSocialMediaLinks)
        {
            if (id != userSocialMediaLinks.Id)
            {
                return BadRequest();
            }

            _context.Entry(userSocialMediaLinks).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserSocialMediaLinksExists(id))
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

        // POST: api/UserSocialMediaLinks
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<UserSocialMediaLinks>> PostUserSocialMediaLinks(UserSocialMediaLinks userSocialMediaLinks)
        {
            _context.UserSocialMediaLinks.Add(userSocialMediaLinks);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (UserSocialMediaLinksExists(userSocialMediaLinks.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetUserSocialMediaLinks", new { id = userSocialMediaLinks.Id }, userSocialMediaLinks);
        }

        // DELETE: api/UserSocialMediaLinks/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<UserSocialMediaLinks>> DeleteUserSocialMediaLinks(Guid id)
        {
            var userSocialMediaLinks = await _context.UserSocialMediaLinks.FindAsync(id);
            if (userSocialMediaLinks == null)
            {
                return NotFound();
            }

            _context.UserSocialMediaLinks.Remove(userSocialMediaLinks);
            await _context.SaveChangesAsync();

            return userSocialMediaLinks;
        }

        private bool UserSocialMediaLinksExists(Guid id)
        {
            return _context.UserSocialMediaLinks.Any(e => e.Id == id);
        }
    }
}
