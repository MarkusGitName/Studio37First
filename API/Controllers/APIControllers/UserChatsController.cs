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
    public class UserChatsController : ControllerBase
    {
        private readonly AdventureContext _context;

        public UserChatsController(AdventureContext context)
        {
            _context = context;
        }

        // GET: api/UserChats
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserChat>>> GetUserChat()
        {
            return await _context.UserChat.ToListAsync();
        }

        // GET: api/UserChats/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserChat>> GetUserChat(Guid id)
        {
            var userChat = await _context.UserChat.FindAsync(id);

            if (userChat == null)
            {
                return NotFound();
            }

            return userChat;
        }

        // PUT: api/UserChats/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserChat(Guid id, UserChat userChat)
        {
            if (id != userChat.Id)
            {
                return BadRequest();
            }

            _context.Entry(userChat).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserChatExists(id))
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

        // POST: api/UserChats
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<UserChat>> PostUserChat(UserChat userChat)
        {
            _context.UserChat.Add(userChat);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (UserChatExists(userChat.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetUserChat", new { id = userChat.Id }, userChat);
        }

        // DELETE: api/UserChats/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<UserChat>> DeleteUserChat(Guid id)
        {
            var userChat = await _context.UserChat.FindAsync(id);
            if (userChat == null)
            {
                return NotFound();
            }

            _context.UserChat.Remove(userChat);
            await _context.SaveChangesAsync();

            return userChat;
        }

        private bool UserChatExists(Guid id)
        {
            return _context.UserChat.Any(e => e.Id == id);
        }
    }
}
