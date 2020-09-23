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
using Studio37API.Models.ViewModels;

namespace Studio37API.Controllers.API
{
    public class UserChatsController : ApiController
    {
        private DataBaseModels db = new DataBaseModels();

        // GET: api/UserChats
        public List<UserChatViewModel> GetUserChats()
        {
            List<UserChatViewModel> UserChatList = new List<UserChatViewModel>();

            foreach(UserChat incomingUserChat in db.UserChats)
            {
                UserChatList.Add(new UserChatViewModel(incomingUserChat));
            }

            return UserChatList;
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

            return Ok(new UserChatViewModel(userChat));
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

            return CreatedAtRoute("DefaultApi", new { id = userChat.id }, new UserChatViewModel(userChat));
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

            return Ok(new UserChatViewModel(userChat));
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