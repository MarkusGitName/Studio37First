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
    public class PostLiveShowsController : ApiController
    {
        private DataBaseModels db = new DataBaseModels();

        // GET: api/PostLiveShows
        public IQueryable<PostLiveShow> GetPostLiveShows()
        {
            return db.PostLiveShows;
        }

        // GET: api/PostLiveShows/5
        [ResponseType(typeof(PostLiveShow))]
        public async Task<IHttpActionResult> GetPostLiveShow(Guid id)
        {
            PostLiveShow postLiveShow = await db.PostLiveShows.FindAsync(id);
            if (postLiveShow == null)
            {
                return NotFound();
            }

            return Ok(postLiveShow);
        }

        // PUT: api/PostLiveShows/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPostLiveShow(Guid id, PostLiveShow postLiveShow)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != postLiveShow.id)
            {
                return BadRequest();
            }

            db.Entry(postLiveShow).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PostLiveShowExists(id))
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

        // POST: api/PostLiveShows
        [ResponseType(typeof(PostLiveShow))]
        public async Task<IHttpActionResult> PostPostLiveShow(PostLiveShow postLiveShow)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PostLiveShows.Add(postLiveShow);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PostLiveShowExists(postLiveShow.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = postLiveShow.id }, postLiveShow);
        }

        // DELETE: api/PostLiveShows/5
        [ResponseType(typeof(PostLiveShow))]
        public async Task<IHttpActionResult> DeletePostLiveShow(Guid id)
        {
            PostLiveShow postLiveShow = await db.PostLiveShows.FindAsync(id);
            if (postLiveShow == null)
            {
                return NotFound();
            }

            db.PostLiveShows.Remove(postLiveShow);
            await db.SaveChangesAsync();

            return Ok(postLiveShow);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PostLiveShowExists(Guid id)
        {
            return db.PostLiveShows.Count(e => e.id == id) > 0;
        }
    }
}