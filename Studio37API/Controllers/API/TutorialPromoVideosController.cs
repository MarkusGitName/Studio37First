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
    public class TutorialPromoVideosController : ApiController
    {
        private DataBaseModels db = new DataBaseModels();

        // GET: api/TutorialPromoVideos
        public IQueryable<TutorialPromoVideo> GetTutorialPromoVideos()
        {
            return db.TutorialPromoVideos;
        }

        // GET: api/TutorialPromoVideos/5
        [ResponseType(typeof(TutorialPromoVideo))]
        public async Task<IHttpActionResult> GetTutorialPromoVideo(Guid id)
        {
            TutorialPromoVideo tutorialPromoVideo = await db.TutorialPromoVideos.FindAsync(id);
            if (tutorialPromoVideo == null)
            {
                return NotFound();
            }

            return Ok(tutorialPromoVideo);
        }

        // PUT: api/TutorialPromoVideos/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutTutorialPromoVideo(Guid id, TutorialPromoVideo tutorialPromoVideo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tutorialPromoVideo.id)
            {
                return BadRequest();
            }

            db.Entry(tutorialPromoVideo).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TutorialPromoVideoExists(id))
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

        // POST: api/TutorialPromoVideos
        [ResponseType(typeof(TutorialPromoVideo))]
        public async Task<IHttpActionResult> PostTutorialPromoVideo(TutorialPromoVideo tutorialPromoVideo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TutorialPromoVideos.Add(tutorialPromoVideo);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TutorialPromoVideoExists(tutorialPromoVideo.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = tutorialPromoVideo.id }, tutorialPromoVideo);
        }

        // DELETE: api/TutorialPromoVideos/5
        [ResponseType(typeof(TutorialPromoVideo))]
        public async Task<IHttpActionResult> DeleteTutorialPromoVideo(Guid id)
        {
            TutorialPromoVideo tutorialPromoVideo = await db.TutorialPromoVideos.FindAsync(id);
            if (tutorialPromoVideo == null)
            {
                return NotFound();
            }

            db.TutorialPromoVideos.Remove(tutorialPromoVideo);
            await db.SaveChangesAsync();

            return Ok(tutorialPromoVideo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TutorialPromoVideoExists(Guid id)
        {
            return db.TutorialPromoVideos.Count(e => e.id == id) > 0;
        }
    }
}