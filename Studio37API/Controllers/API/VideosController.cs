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
    public class VideosController : ApiController
    {
        private DataBaseModels db = new DataBaseModels();

        // GET: api/Videos
        public IQueryable<Video> GetVideos()
        {
            return db.Videos;
        }

        // GET: api/Videos/5
        [ResponseType(typeof(Video))]
        public async Task<IHttpActionResult> GetVideo(Guid id)
        {
            Video video = await db.Videos.FindAsync(id);
            if (video == null)
            {
                return NotFound();
            }

            return Ok(video);
        }

        // PUT: api/Videos/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutVideo(Guid id, Video video)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != video.id)
            {
                return BadRequest();
            }

            db.Entry(video).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VideoExists(id))
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

        // POST: api/Videos
        [ResponseType(typeof(Video))]
        public async Task<IHttpActionResult> PostVideo(Video video)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Videos.Add(video);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (VideoExists(video.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = video.id }, video);
        }

        // DELETE: api/Videos/5
        [ResponseType(typeof(Video))]
        public async Task<IHttpActionResult> DeleteVideo(Guid id)
        {
            Video video = await db.Videos.FindAsync(id);
            if (video == null)
            {
                return NotFound();
            }

            db.Videos.Remove(video);
            await db.SaveChangesAsync();

            return Ok(video);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VideoExists(Guid id)
        {
            return db.Videos.Count(e => e.id == id) > 0;
        }
    }
}