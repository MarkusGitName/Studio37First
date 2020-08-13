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

namespace Studio37API.Controllers.API
{
    public class EventGroupsController : ApiController
    {
        private DataBaseModels db = new DataBaseModels();

        // GET: api/EventGroups
        public IQueryable<EventGroup> GetEventGroups()
        {
            return db.EventGroups;
        }

        // GET: api/EventGroups/5
        [ResponseType(typeof(EventGroup))]
        public async Task<IHttpActionResult> GetEventGroup(Guid id)
        {
            EventGroup eventGroup = await db.EventGroups.FindAsync(id);
            if (eventGroup == null)
            {
                return NotFound();
            }

            return Ok(eventGroup);
        }

        // PUT: api/EventGroups/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutEventGroup(Guid id, EventGroup eventGroup)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != eventGroup.id)
            {
                return BadRequest();
            }

            db.Entry(eventGroup).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventGroupExists(id))
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

        // POST: api/EventGroups
        [ResponseType(typeof(EventGroup))]
        public async Task<IHttpActionResult> PostEventGroup(EventGroup eventGroup)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.EventGroups.Add(eventGroup);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EventGroupExists(eventGroup.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = eventGroup.id }, eventGroup);
        }

        // DELETE: api/EventGroups/5
        [ResponseType(typeof(EventGroup))]
        public async Task<IHttpActionResult> DeleteEventGroup(Guid id)
        {
            EventGroup eventGroup = await db.EventGroups.FindAsync(id);
            if (eventGroup == null)
            {
                return NotFound();
            }

            db.EventGroups.Remove(eventGroup);
            await db.SaveChangesAsync();

            return Ok(eventGroup);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EventGroupExists(Guid id)
        {
            return db.EventGroups.Count(e => e.id == id) > 0;
        }
    }
}