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
    public class PostVideosController : ApiController
    {
        private DataBaseModels db = new DataBaseModels();

        // GET: api/PostVideos
        public List<PostVideoViewModel> GetPostVideos()
        {
            List<PostVideoViewModel> PostVideoList = new List<PostVideoViewModel>();
            
            foreach(PostVideo incomingPostVideo in db.PostVideos)
            {
                PostVideoList.Add(new PostVideoViewModel(incomingPostVideo));
            }

            return PostVideoList;
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

            return Ok(new PostVideoViewModel(postVideo));
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

            return CreatedAtRoute("DefaultApi", new { id = postVideo.id }, new PostVideoViewModel(postVideo));
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

            return Ok(new PostVideoViewModel(postVideo));
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