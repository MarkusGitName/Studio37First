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
    public class LiveShowCattegoriesController : ApiController
    {
        private DataModel db = new DataModel();

        // GET: api/LiveShowCattegories
        public IQueryable<LiveShowCattegory> GetLiveShowCattegories()
        {
            return db.LiveShowCattegories;
        }

        // GET: api/LiveShowCattegories/5
        [ResponseType(typeof(LiveShowCattegory))]
        public async Task<IHttpActionResult> GetLiveShowCattegory(Guid id)
        {
            LiveShowCattegory liveShowCattegory = await db.LiveShowCattegories.FindAsync(id);
            if (liveShowCattegory == null)
            {
                return NotFound();
            }

            return Ok(liveShowCattegory);
        }

        // PUT: api/LiveShowCattegories/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutLiveShowCattegory(Guid id, LiveShowCattegory liveShowCattegory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != liveShowCattegory.id)
            {
                return BadRequest();
            }

            db.Entry(liveShowCattegory).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LiveShowCattegoryExists(id))
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

        // POST: api/LiveShowCattegories
        [ResponseType(typeof(LiveShowCattegory))]
        public async Task<IHttpActionResult> PostLiveShowCattegory(LiveShowCattegory liveShowCattegory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.LiveShowCattegories.Add(liveShowCattegory);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (LiveShowCattegoryExists(liveShowCattegory.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = liveShowCattegory.id }, liveShowCattegory);
        }

        // DELETE: api/LiveShowCattegories/5
        [ResponseType(typeof(LiveShowCattegory))]
        public async Task<IHttpActionResult> DeleteLiveShowCattegory(Guid id)
        {
            LiveShowCattegory liveShowCattegory = await db.LiveShowCattegories.FindAsync(id);
            if (liveShowCattegory == null)
            {
                return NotFound();
            }

            db.LiveShowCattegories.Remove(liveShowCattegory);
            await db.SaveChangesAsync();

            return Ok(liveShowCattegory);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LiveShowCattegoryExists(Guid id)
        {
            return db.LiveShowCattegories.Count(e => e.id == id) > 0;
        }
    }
}