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
    public class StickerCattegoriesController : ApiController
    {
        private DataBaseModels db = new DataBaseModels();

        // GET: api/StickerCattegories
        public List<StickerCattegoryViewModel> GetStickerCattegories()
        {
            List<StickerCattegoryViewModel> StickerCategoryList = new List<StickerCattegoryViewModel>();

            foreach(StickerCattegory incomingStickerCategory in db.StickerCattegories)
            {
                StickerCategoryList.Add(new StickerCattegoryViewModel(incomingStickerCategory));
            }

            return StickerCategoryList;
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

            return Ok(new StickerCattegoryViewModel(stickerCattegory));
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

            return CreatedAtRoute("DefaultApi", new { id = stickerCattegory.id }, new StickerCattegoryViewModel(stickerCattegory));
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

            return Ok(new StickerCattegoryViewModel(stickerCattegory));
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