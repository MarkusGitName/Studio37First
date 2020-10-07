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
    public class ClassVideoCommentsController : ApiController
    {
        private DataBaseModels db = new DataBaseModels();

        // GET: api/ClassVideoComments
        public List<ClassVideoCommentViewModel> GetClassVideoComments()
        {
            List<ClassVideoCommentViewModel> ClassVideoCommentList = new List<ClassVideoCommentViewModel>();

            foreach(ClassVideoComment incomingClassVideoComment in db.ClassVideoComments)
            {
                ClassVideoCommentList.Add(new ClassVideoCommentViewModel(incomingClassVideoComment));
            }

            return ClassVideoCommentList;
        }

        // GET: api/ClassVideoComments/5
        [ResponseType(typeof(ClassVideoCommentViewModel))]
        public async Task<IHttpActionResult> GetClassVideoComment(Guid id)
        {
            ClassVideoComment classVideoComment = await db.ClassVideoComments.FindAsync(id);
            if (classVideoComment == null)
            {
                return NotFound();
            }

            return Ok(new ClassVideoCommentViewModel(classVideoComment));
        }

        // PUT: api/ClassVideoComments/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutClassVideoComment(Guid id, ClassVideoComment classVideoComment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != classVideoComment.id)
            {
                return BadRequest();
            }

            db.Entry(classVideoComment).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClassVideoCommentExists(id))
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

        // POST: api/ClassVideoComments
        [ResponseType(typeof(ClassVideoCommentViewModel))]
        public async Task<IHttpActionResult> PostClassVideoComment(ClassVideoComment classVideoComment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ClassVideoComments.Add(classVideoComment);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ClassVideoCommentExists(classVideoComment.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = classVideoComment.id }, new ClassVideoCommentViewModel(classVideoComment));
        }

        // DELETE: api/ClassVideoComments/5
        [ResponseType(typeof(ClassVideoCommentViewModel))]
        public async Task<IHttpActionResult> DeleteClassVideoComment(Guid id)
        {
            ClassVideoComment classVideoComment = await db.ClassVideoComments.FindAsync(id);
            if (classVideoComment == null)
            {
                return NotFound();
            }

            db.ClassVideoComments.Remove(classVideoComment);
            await db.SaveChangesAsync();

            return Ok(new ClassVideoCommentViewModel(classVideoComment));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ClassVideoCommentExists(Guid id)
        {
            return db.ClassVideoComments.Count(e => e.id == id) > 0;
        }
    }
}