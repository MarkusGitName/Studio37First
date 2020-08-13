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
    public class PostEventsController : ApiController
    {
        private DataBaseModels db = new DataBaseModels();

        // GET: api/PostEvents
        public IQueryable<PostEvent> GetPostEvents()
        {
            return db.PostEvents;
        }

        // GET: api/PostEvents/5
        [ResponseType(typeof(PostEvent))]
        public async Task<IHttpActionResult> GetPostEvent(Guid id)
        {
            PostEvent postEvent = await db.PostEvents.FindAsync(id);
            if (postEvent == null)
            {
                return NotFound();
            }

            return Ok(postEvent);
        }

        // PUT: api/PostEvents/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPostEvent(Guid id, PostEvent postEvent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != postEvent.id)
            {
                return BadRequest();
            }

            db.Entry(postEvent).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PostEventExists(id))
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

        // POST: api/PostEvents
        [ResponseType(typeof(PostEvent))]
        public async Task<IHttpActionResult> PostPostEvent(PostEvent postEvent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PostEvents.Add(postEvent);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PostEventExists(postEvent.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = postEvent.id }, postEvent);
        }

        // DELETE: api/PostEvents/5
        [ResponseType(typeof(PostEvent))]
        public async Task<IHttpActionResult> DeletePostEvent(Guid id)
        {
            PostEvent postEvent = await db.PostEvents.FindAsync(id);
            if (postEvent == null)
            {
                return NotFound();
            }

            db.PostEvents.Remove(postEvent);
            await db.SaveChangesAsync();

            return Ok(postEvent);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PostEventExists(Guid id)
        {
            return db.PostEvents.Count(e => e.id == id) > 0;
        }
    }
}