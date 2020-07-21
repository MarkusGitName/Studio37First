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
    public class StickerCattegoriesController : ApiController
    {
        private DataModel db = new DataModel();

        // GET: api/StickerCattegories
        public IQueryable<StickerCattegory> GetStickerCattegories()
        {
            return db.StickerCattegories;
        }

        // GET: api/StickerCattegories/5
        [ResponseType(typeof(StickerCattegory))]
        public async Task<IHttpActionResult> GetStickerCattegory(Guid id)
        {
            StickerCattegory stickerCattegory = await db.StickerCattegories.FindAsync(id);
            if (stickerCattegory == null)
            {
                return NotFound();
            }

            return Ok(stickerCattegory);
        }

        // PUT: api/StickerCattegories/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutStickerCattegory(Guid id, StickerCattegory stickerCattegory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != stickerCattegory.id)
            {
                return BadRequest();
            }

            db.Entry(stickerCattegory).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StickerCattegoryExists(id))
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

        // POST: api/StickerCattegories
        [ResponseType(typeof(StickerCattegory))]
        public async Task<IHttpActionResult> PostStickerCattegory(StickerCattegory stickerCattegory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.StickerCattegories.Add(stickerCattegory);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (StickerCattegoryExists(stickerCattegory.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = stickerCattegory.id }, stickerCattegory);
        }

        // DELETE: api/StickerCattegories/5
        [ResponseType(typeof(StickerCattegory))]
        public async Task<IHttpActionResult> DeleteStickerCattegory(Guid id)
        {
            StickerCattegory stickerCattegory = await db.StickerCattegories.FindAsync(id);
            if (stickerCattegory == null)
            {
                return NotFound();
            }

            db.StickerCattegories.Remove(stickerCattegory);
            await db.SaveChangesAsync();

            return Ok(stickerCattegory);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool StickerCattegoryExists(Guid id)
        {
            return db.StickerCattegories.Count(e => e.id == id) > 0;
        }
    }
}