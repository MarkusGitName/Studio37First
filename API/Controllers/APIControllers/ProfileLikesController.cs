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
    public class ProfileLikesController : ControllerBase
    {
        private readonly AdventureContext _context;

        public ProfileLikesController(AdventureContext context)
        {
            _context = context;
        }

        // GET: api/ProfileLikes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProfileLikes>>> GetProfileLikes()
        {
            return await _context.ProfileLikes.ToListAsync();
        }

        // GET: api/ProfileLikes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProfileLikes>> GetProfileLikes(string id)
        {
            var profileLikes = await _context.ProfileLikes.FindAsync(id);

            if (profileLikes == null)
            {
                return NotFound();
            }

            return profileLikes;
        }

        // PUT: api/ProfileLikes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProfileLikes(string id, ProfileLikes profileLikes)
        {
            if (id != profileLikes.UserId)
            {
                return BadRequest();
            }

            _context.Entry(profileLikes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProfileLikesExists(id))
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

        // POST: api/ProfileLikes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ProfileLikes>> PostProfileLikes(ProfileLikes profileLikes)
        {
            _context.ProfileLikes.Add(profileLikes);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ProfileLikesExists(profileLikes.UserId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetProfileLikes", new { id = profileLikes.UserId }, profileLikes);
        }

        // DELETE: api/ProfileLikes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ProfileLikes>> DeleteProfileLikes(string id)
        {
            var profileLikes = await _context.ProfileLikes.FindAsync(id);
            if (profileLikes == null)
            {
                return NotFound();
            }

            _context.ProfileLikes.Remove(profileLikes);
            await _context.SaveChangesAsync();

            return profileLikes;
        }

        private bool ProfileLikesExists(string id)
        {
            return _context.ProfileLikes.Any(e => e.UserId == id);
        }
    }
}
