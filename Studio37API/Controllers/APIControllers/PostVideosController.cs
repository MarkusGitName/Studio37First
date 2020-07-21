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
    public class PostVideosController : ApiController
    {
        private DataModel db = new DataModel();

        // GET: api/PostVideos
        public IQueryable<PostVideo> GetPostVideos()
        {
            return db.PostVideos;
        }

        // GET: api/PostVideos/5
        [ResponseType(typeof(PostVideo))]
        public async Task<IHttpActionResult> GetPostVideo(Guid id)
        {
            PostVideo postVideo = await db.PostVideos.FindAsync(id);
            if (postVideo == null)
            {
                return NotFound();
            }

            return Ok(postVideo);
        }

        // PUT: api/PostVideos/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPostVideo(Guid id, PostVideo postVideo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != postVideo.id)
            {
                return BadRequest();
            }

            db.Entry(postVideo).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PostVideoExists(id))
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

        // POST: api/PostVideos
        [ResponseType(typeof(PostVideo))]
        public async Task<IHttpActionResult> PostPostVideo(PostVideo postVideo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PostVideos.Add(postVideo);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PostVideoExists(postVideo.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = postVideo.id }, postVideo);
        }

        // DELETE: api/PostVideos/5
        [ResponseType(typeof(PostVideo))]
        public async Task<IHttpActionResult> DeletePostVideo(Guid id)
        {
            PostVideo postVideo = await db.PostVideos.FindAsync(id);
            if (postVideo == null)
            {
                return NotFound();
            }

            db.PostVideos.Remove(postVideo);
            await db.SaveChangesAsync();

            return Ok(postVideo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PostVideoExists(Guid id)
        {
            return db.PostVideos.Count(e => e.id == id) > 0;
        }
    }
}