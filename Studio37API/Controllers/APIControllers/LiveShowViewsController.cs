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
    public class LiveShowViewsController : ApiController
    {
        private DataModel db = new DataModel();

        // GET: api/LiveShowViews
        public IQueryable<LiveShowView> GetLiveShowViews()
        {
            return db.LiveShowViews;
        }

        // GET: api/LiveShowViews/5
        [ResponseType(typeof(LiveShowView))]
        public async Task<IHttpActionResult> GetLiveShowView(Guid id)
        {
            LiveShowView liveShowView = await db.LiveShowViews.FindAsync(id);
            if (liveShowView == null)
            {
                return NotFound();
            }

            return Ok(liveShowView);
        }

        // PUT: api/LiveShowViews/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutLiveShowView(Guid id, LiveShowView liveShowView)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != liveShowView.id)
            {
                return BadRequest();
            }

            db.Entry(liveShowView).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LiveShowViewExists(id))
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

        // POST: api/LiveShowViews
        [ResponseType(typeof(LiveShowView))]
        public async Task<IHttpActionResult> PostLiveShowView(LiveShowView liveShowView)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.LiveShowViews.Add(liveShowView);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (LiveShowViewExists(liveShowView.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = liveShowView.id }, liveShowView);
        }

        // DELETE: api/LiveShowViews/5
        [ResponseType(typeof(LiveShowView))]
        public async Task<IHttpActionResult> DeleteLiveShowView(Guid id)
        {
            LiveShowView liveShowView = await db.LiveShowViews.FindAsync(id);
            if (liveShowView == null)
            {
                return NotFound();
            }

            db.LiveShowViews.Remove(liveShowView);
            await db.SaveChangesAsync();

            return Ok(liveShowView);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LiveShowViewExists(Guid id)
        {
            return db.LiveShowViews.Count(e => e.id == id) > 0;
        }
    }
}