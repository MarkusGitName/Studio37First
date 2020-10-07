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
    public class LikesController : ApiController
    {
        private DataBaseModels db = new DataBaseModels();

        // GET: api/Likes
        public List<LikeViewModel> GetLikes()
        {
            List<LikeViewModel> LikeList = new List<LikeViewModel>();

            foreach(Like incomingLike in db.Likes)
            {
                LikeList.Add(new LikeViewModel(incomingLike));

            }

            return LikeList;
        }

        // GET: api/Likes/5
        [ResponseType(typeof(LikeViewModel))]
        public async Task<IHttpActionResult> GetLike(Guid id)
        {
            Like like = await db.Likes.FindAsync(id);
            if (like == null)
            {
                return NotFound();
            }

            return Ok(new LikeViewModel(like));
        }

        // PUT: api/Likes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutLike(Guid id, Like like)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != like.id)
            {
                return BadRequest();
            }

            db.Entry(like).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LikeExists(id))
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

        // POST: api/Likes
        [ResponseType(typeof(LikeViewModel))]
        public async Task<IHttpActionResult> PostLike(Like like)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Likes.Add(like);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (LikeExists(like.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = like.id }, new LikeViewModel(like));
        }

        // DELETE: api/Likes/5
        [ResponseType(typeof(LikeViewModel))]
        public async Task<IHttpActionResult> DeleteLike(Guid id)
        {
            Like like = await db.Likes.FindAsync(id);
            if (like == null)
            {
                return NotFound();
            }

            db.Likes.Remove(like);
            await db.SaveChangesAsync();

            return Ok(new LikeViewModel(like));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LikeExists(Guid id)
        {
            return db.Likes.Count(e => e.id == id) > 0;
        }
    }
}