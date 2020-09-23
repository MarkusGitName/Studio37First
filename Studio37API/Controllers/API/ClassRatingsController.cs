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
    public class ClassRatingsController : ApiController
    {
        private DataBaseModels db = new DataBaseModels();

        // GET: api/ClassRatings
        public List<ClassRatingViewModel> GetClassRatings()
        {
            List<ClassRatingViewModel> ClassRatingList = new List<ClassRatingViewModel>();

            foreach(ClassRating incomingClassRating in db.ClassRatings)
            {
                ClassRatingList.Add(new ClassRatingViewModel(incomingClassRating));
            }
            return ClassRatingList;
        }

        // GET: api/ClassRatings/5
        [ResponseType(typeof(ClassRatingViewModel))]
        public async Task<IHttpActionResult> GetClassRating(Guid id)
        {
            ClassRating classRating = await db.ClassRatings.FindAsync(id);
            if (classRating == null)
            {
                return NotFound();
            }

            return Ok(new ClassRatingViewModel(ClassRating));
        }

        // PUT: api/ClassRatings/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutClassRating(Guid id, ClassRating classRating)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != classRating.id)
            {
                return BadRequest();
            }

            db.Entry(classRating).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClassRatingExists(id))
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

        // POST: api/ClassRatings
        [ResponseType(typeof(ClassRatingViewModel))]
        public async Task<IHttpActionResult> PostClassRating(ClassRating classRating)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ClassRatings.Add(classRating);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ClassRatingExists(classRating.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = classRating.id }, new ClassRatingViewModel(ClassRating));
        }

        // DELETE: api/ClassRatings/5
        [ResponseType(typeof(ClassRatingViewModel))]
        public async Task<IHttpActionResult> DeleteClassRating(Guid id)
        {
            ClassRating classRating = await db.ClassRatings.FindAsync(id);
            if (classRating == null)
            {
                return NotFound();
            }

            db.ClassRatings.Remove(classRating);
            await db.SaveChangesAsync();

            return Ok(new ClassRatingViewModel(ClassRating));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ClassRatingExists(Guid id)
        {
            return db.ClassRatings.Count(e => e.id == id) > 0;
        }
    }
}