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
    public class GoupMediaLinksController : ApiController
    {
        private DataBaseModels db = new DataBaseModels();

        // GET: api/GoupMediaLinks
        public IQueryable<GoupMediaLink> GetGoupMediaLinks()
        {
            return db.GoupMediaLinks;
        }

        // GET: api/GoupMediaLinks/5
        [ResponseType(typeof(GoupMediaLink))]
        public async Task<IHttpActionResult> GetGoupMediaLink(Guid id)
        {
            GoupMediaLink goupMediaLink = await db.GoupMediaLinks.FindAsync(id);
            if (goupMediaLink == null)
            {
                return NotFound();
            }

            return Ok(goupMediaLink);
        }

        // PUT: api/GoupMediaLinks/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutGoupMediaLink(Guid id, GoupMediaLink goupMediaLink)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != goupMediaLink.id)
            {
                return BadRequest();
            }

            db.Entry(goupMediaLink).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GoupMediaLinkExists(id))
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

        // POST: api/GoupMediaLinks
        [ResponseType(typeof(GoupMediaLink))]
        public async Task<IHttpActionResult> PostGoupMediaLink(GoupMediaLink goupMediaLink)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.GoupMediaLinks.Add(goupMediaLink);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (GoupMediaLinkExists(goupMediaLink.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = goupMediaLink.id }, goupMediaLink);
        }

        // DELETE: api/GoupMediaLinks/5
        [ResponseType(typeof(GoupMediaLink))]
        public async Task<IHttpActionResult> DeleteGoupMediaLink(Guid id)
        {
            GoupMediaLink goupMediaLink = await db.GoupMediaLinks.FindAsync(id);
            if (goupMediaLink == null)
            {
                return NotFound();
            }

            db.GoupMediaLinks.Remove(goupMediaLink);
            await db.SaveChangesAsync();

            return Ok(goupMediaLink);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool GoupMediaLinkExists(Guid id)
        {
            return db.GoupMediaLinks.Count(e => e.id == id) > 0;
        }
    }
}