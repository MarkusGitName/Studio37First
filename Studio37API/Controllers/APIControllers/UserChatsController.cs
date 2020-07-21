using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Studio37API.Models.DataBaseMdels;

namespace Studio37API.Controllers.APIControllers
{
    public class UserChatsController : ApiController
    {
        private DataModel db = new DataModel();

        // GET: api/UserChats
        public IQueryable<UserChat> GetUserChats()
        {
            return db.UserChats;
        }

        // GET: api/UserChats/5
        [ResponseType(typeof(UserChat))]
        public async Task<IHttpActionResult> GetUserChat(Guid id)
        {
            UserChat userChat = await db.UserChats.FindAsync(id);
            if (userChat == null)
            {
                return NotFound();
            }

            return Ok(userChat);
        }

        // PUT: api/UserChats/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutUserChat(Guid id, UserChat userChat)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != userChat.id)
            {
                return BadRequest();
            }

            db.Entry(userChat).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
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

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/UserChats
        [ResponseType(typeof(UserChat))]
        public async Task<IHttpActionResult> PostUserChat(UserChat userChat)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.UserChats.Add(userChat);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (UserChatExists(userChat.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = userChat.id }, userChat);
        }

        // DELETE: api/UserChats/5
        [ResponseType(typeof(UserChat))]
        public async Task<IHttpActionResult> DeleteUserChat(Guid id)
        {
            UserChat userChat = await db.UserChats.FindAsync(id);
            if (userChat == null)
            {
                return NotFound();
            }

            db.UserChats.Remove(userChat);
            await db.SaveChangesAsync();

            return Ok(userChat);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UserChatExists(Guid id)
        {
            return db.UserChats.Count(e => e.id == id) > 0;
        }
    }
}