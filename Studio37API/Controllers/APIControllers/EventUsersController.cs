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
    public class EventUsersController : ApiController
    {
        private DataModel db = new DataModel();

        // GET: api/EventUsers
        public IQueryable<EventUser> GetEventUsers()
        {
            return db.EventUsers;
        }

        // GET: api/EventUsers/5
        [ResponseType(typeof(EventUser))]
        public async Task<IHttpActionResult> GetEventUser(Guid id)
        {
            EventUser eventUser = await db.EventUsers.FindAsync(id);
            if (eventUser == null)
            {
                return NotFound();
            }

            return Ok(eventUser);
        }

        // PUT: api/EventUsers/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutEventUser(Guid id, EventUser eventUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != eventUser.id)
            {
                return BadRequest();
            }

            db.Entry(eventUser).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventUserExists(id))
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

        // POST: api/EventUsers
        [ResponseType(typeof(EventUser))]
        public async Task<IHttpActionResult> PostEventUser(EventUser eventUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.EventUsers.Add(eventUser);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EventUserExists(eventUser.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = eventUser.id }, eventUser);
        }

        // DELETE: api/EventUsers/5
        [ResponseType(typeof(EventUser))]
        public async Task<IHttpActionResult> DeleteEventUser(Guid id)
        {
            EventUser eventUser = await db.EventUsers.FindAsync(id);
            if (eventUser == null)
            {
                return NotFound();
            }

            db.EventUsers.Remove(eventUser);
            await db.SaveChangesAsync();

            return Ok(eventUser);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EventUserExists(Guid id)
        {
            return db.EventUsers.Count(e => e.id == id) > 0;
        }
    }
}