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
    public class ShareLikesController : ControllerBase
    {
        private readonly AdventureContext _context;

        public ShareLikesController(AdventureContext context)
        {
            _context = context;
        }

        // GET: api/ShareLikes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ShareLikes>>> GetShareLikes()
        {
            return await _context.ShareLikes.ToListAsync();
        }

        // GET: api/ShareLikes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ShareLikes>> GetShareLikes(Guid id)
        {
            var shareLikes = await _context.ShareLikes.FindAsync(id);

            if (shareLikes == null)
            {
                return NotFound();
            }

            return shareLikes;
        }

        // PUT: api/ShareLikes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutShareLikes(Guid id, ShareLikes shareLikes)
        {
            if (id != shareLikes.ShareId)
            {
                return BadRequest();
            }

            _context.Entry(shareLikes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShareLikesExists(id))
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

        // POST: api/ShareLikes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ShareLikes>> PostShareLikes(ShareLikes shareLikes)
        {
            _context.ShareLikes.Add(shareLikes);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ShareLikesExists(shareLikes.ShareId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetShareLikes", new { id = shareLikes.ShareId }, shareLikes);
        }

        // DELETE: api/ShareLikes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ShareLikes>> DeleteShareLikes(Guid id)
        {
            var shareLikes = await _context.ShareLikes.FindAsync(id);
            if (shareLikes == null)
            {
                return NotFound();
            }

            _context.ShareLikes.Remove(shareLikes);
            await _context.SaveChangesAsync();

            return shareLikes;
        }

        private bool ShareLikesExists(Guid id)
        {
            return _context.ShareLikes.Any(e => e.ShareId == id);
        }
    }
}
