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
    public class LiveShowCommentsController : ApiController
    {
        private DataBaseModels db = new DataBaseModels();

        // GET: api/LiveShowComments
        public List<LiveShowCommentViewModel> GetLiveShowComments()
        {
            List<LiveShowCommentViewModel> LiveShowCommentList = new List<LiveShowCommentViewModel>

            foreach(LiveShowComment incomingLiveShowComment in db.LiveShowComments)
            {
                LiveShowCommentList.Add(new LiveShowCommentViewModel(incomingLiveShowComment));
            }


            return LiveShowCommentList;
        }

        // GET: api/LiveShowComments/5
        [ResponseType(typeof(LiveShowComment))]
        public async Task<IHttpActionResult> GetLiveShowComment(Guid id)
        {
            LiveShowComment liveShowComment = await db.LiveShowComments.FindAsync(id);
            if (liveShowComment == null)
            {
                return NotFound();
            }

            return Ok(new LiveShowCommentViewModel(liveShowComment));
        }

        // PUT: api/LiveShowComments/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutLiveShowComment(Guid id, LiveShowComment liveShowComment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != liveShowComment.id)
            {
                return BadRequest();
            }

            db.Entry(liveShowComment).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LiveShowCommentExists(id))
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

        // POST: api/LiveShowComments
        [ResponseType(typeof(LiveShowComment))]
        public async Task<IHttpActionResult> PostLiveShowComment(LiveShowComment liveShowComment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.LiveShowComments.Add(liveShowComment);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (LiveShowCommentExists(liveShowComment.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = liveShowComment.id }, new LiveShowCommentViewModel(liveShowComment));
        }

        // DELETE: api/LiveShowComments/5
        [ResponseType(typeof(LiveShowComment))]
        public async Task<IHttpActionResult> DeleteLiveShowComment(Guid id)
        {
            LiveShowComment liveShowComment = await db.LiveShowComments.FindAsync(id);
            if (liveShowComment == null)
            {
                return NotFound();
            }

            db.LiveShowComments.Remove(liveShowComment);
            await db.SaveChangesAsync();

            return Ok(new LiveShowCommentViewModel(liveShowComment));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LiveShowCommentExists(Guid id)
        {
            return db.LiveShowComments.Count(e => e.id == id) > 0;
        }
    }
}