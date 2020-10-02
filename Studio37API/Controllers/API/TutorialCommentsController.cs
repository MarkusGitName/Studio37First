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
    public class TutorialCommentsController : ApiController
    {
        private DataBaseModels db = new DataBaseModels();

        // GET: api/TutorialComments
        public List<TutorialCommentViewModel> GetTutorialComments()
        {
            List<TutorialCommentViewModel> TutorialCommentList = new List<TutorialCommentViewModel>();

            foreach(TutorialComment incomingTutorialComment in db.TutorialComments)
            {
                TutorialCommentList.Add(new TutorialCommentViewModel(incomingTutorialComment));
            }

            return TutorialCommentList;
        }

        // GET: api/TutorialComments/5
        [ResponseType(typeof(TutorialCommentViewModel))]
        public async Task<IHttpActionResult> GetTutorialComment(Guid id)
        {
            TutorialComment tutorialComment = await db.TutorialComments.FindAsync(id);
            if (tutorialComment == null)
            {
                return NotFound();
            }

            return Ok(new TutorialCommentViewModel(tutorialComment));
        }

        // PUT: api/TutorialComments/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutTutorialComment(Guid id, TutorialComment tutorialComment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tutorialComment.id)
            {
                return BadRequest();
            }

            db.Entry(tutorialComment).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TutorialCommentExists(id))
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

        // POST: api/TutorialComments
        [ResponseType(typeof(TutorialCommentViewModel))]
        public async Task<IHttpActionResult> PostTutorialComment(TutorialComment tutorialComment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TutorialComments.Add(tutorialComment);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TutorialCommentExists(tutorialComment.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = tutorialComment.id }, new TutorialCommentViewModel(tutorialComment));
        }

        // DELETE: api/TutorialComments/5
        [ResponseType(typeof(TutorialCommentViewModel))]
        public async Task<IHttpActionResult> DeleteTutorialComment(Guid id)
        {
            TutorialComment tutorialComment = await db.TutorialComments.FindAsync(id);
            if (tutorialComment == null)
            {
                return NotFound();
            }

            db.TutorialComments.Remove(tutorialComment);
            await db.SaveChangesAsync();

            return Ok(new TutorialCommentViewModel(tutorialComment));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TutorialCommentExists(Guid id)
        {
            return db.TutorialComments.Count(e => e.id == id) > 0;
        }
    }
}