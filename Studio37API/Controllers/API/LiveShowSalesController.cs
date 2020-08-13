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
    public class LiveShowSalesController : ApiController
    {
        private DataBaseModels db = new DataBaseModels();

        // GET: api/LiveShowSales
        public IQueryable<LiveShowSale> GetLiveShowSales()
        {
            return db.LiveShowSales;
        }

        // GET: api/LiveShowSales/5
        [ResponseType(typeof(LiveShowSale))]
        public async Task<IHttpActionResult> GetLiveShowSale(Guid id)
        {
            LiveShowSale liveShowSale = await db.LiveShowSales.FindAsync(id);
            if (liveShowSale == null)
            {
                return NotFound();
            }

            return Ok(liveShowSale);
        }

        // PUT: api/LiveShowSales/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutLiveShowSale(Guid id, LiveShowSale liveShowSale)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != liveShowSale.id)
            {
                return BadRequest();
            }

            db.Entry(liveShowSale).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LiveShowSaleExists(id))
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

        // POST: api/LiveShowSales
        [ResponseType(typeof(LiveShowSale))]
        public async Task<IHttpActionResult> PostLiveShowSale(LiveShowSale liveShowSale)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.LiveShowSales.Add(liveShowSale);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (LiveShowSaleExists(liveShowSale.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = liveShowSale.id }, liveShowSale);
        }

        // DELETE: api/LiveShowSales/5
        [ResponseType(typeof(LiveShowSale))]
        public async Task<IHttpActionResult> DeleteLiveShowSale(Guid id)
        {
            LiveShowSale liveShowSale = await db.LiveShowSales.FindAsync(id);
            if (liveShowSale == null)
            {
                return NotFound();
            }

            db.LiveShowSales.Remove(liveShowSale);
            await db.SaveChangesAsync();

            return Ok(liveShowSale);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LiveShowSaleExists(Guid id)
        {
            return db.LiveShowSales.Count(e => e.id == id) > 0;
        }
    }
}