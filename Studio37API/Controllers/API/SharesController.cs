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
    public class SharesController : ApiController
    {
        private DataBaseModels db = new DataBaseModels();

        // GET: api/Shares
        public List<ShareViewModel> GetShares()
        {
            List<ShareViewModel> ShareList = new List<ShareViewModel>();

            foreach(Share incomingShare in db.Shares)
            {
                ShareList.Add(new ShareViewModel(incomingShare));
            }

            return ShareList;
        }

        // GET: api/Shares/5
        [ResponseType(typeof(Share))]
        public async Task<IHttpActionResult> GetShare(Guid id)
        {
            Share share = await db.Shares.FindAsync(id);
            if (share == null)
            {
                return NotFound();
            }

            return Ok(new ShareViewModel(share));
        }

        // PUT: api/Shares/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutShare(Guid id, Share share)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != share.id)
            {
                return BadRequest();
            }

            db.Entry(share).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShareExists(id))
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

        // POST: api/Shares
        [ResponseType(typeof(Share))]
        public async Task<IHttpActionResult> PostShare(Share share)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Shares.Add(share);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ShareExists(share.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = share.id }, new ShareViewModel(share));
        }

        // DELETE: api/Shares/5
        [ResponseType(typeof(Share))]
        public async Task<IHttpActionResult> DeleteShare(Guid id)
        {
            Share share = await db.Shares.FindAsync(id);
            if (share == null)
            {
                return NotFound();
            }

            db.Shares.Remove(share);
            await db.SaveChangesAsync();

            return Ok(new ShareViewModel(share));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ShareExists(Guid id)
        {
            return db.Shares.Count(e => e.id == id) > 0;
        }
    }
}