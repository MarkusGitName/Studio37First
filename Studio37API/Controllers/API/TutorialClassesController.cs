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
    public class TutorialClassesController : ApiController
    {
        private DataBaseModels db = new DataBaseModels();

        // GET: api/TutorialClasses
        public List<TutorialClassViewModel> GetTutorialClasses()
        {
            List<TutorialClassViewModel> TutorialClassList = new List<TutorialClassViewModel>:

            foreach(TutorialClass incomingTutoriaClass in db.TutorialClasses)
            {
                TutorialClassList.Add(new TutorialClassViewModel(incomingTutoriaClass));
            }

            return TutorialClassList;
        }

        // GET: api/TutorialClasses/5
        [ResponseType(typeof(TutorialClass))]
        public async Task<IHttpActionResult> GetTutorialClass(Guid id)
        {
            TutorialClass tutorialClass = await db.TutorialClasses.FindAsync(id);
            if (tutorialClass == null)
            {
                return NotFound();
            }

            return Ok(new TutorialClassViewModel(tutorialClass));
        }

        // PUT: api/TutorialClasses/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutTutorialClass(Guid id, TutorialClass tutorialClass)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tutorialClass.id)
            {
                return BadRequest();
            }

            db.Entry(tutorialClass).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TutorialClassExists(id))
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

        // POST: api/TutorialClasses
        [ResponseType(typeof(TutorialClass))]
        public async Task<IHttpActionResult> PostTutorialClass(TutorialClass tutorialClass)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TutorialClasses.Add(tutorialClass);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TutorialClassExists(tutorialClass.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = tutorialClass.id }, new TutorialClassViewModel(tutorialClass));
        }

        // DELETE: api/TutorialClasses/5
        [ResponseType(typeof(TutorialClass))]
        public async Task<IHttpActionResult> DeleteTutorialClass(Guid id)
        {
            TutorialClass tutorialClass = await db.TutorialClasses.FindAsync(id);
            if (tutorialClass == null)
            {
                return NotFound();
            }

            db.TutorialClasses.Remove(tutorialClass);
            await db.SaveChangesAsync();

            return Ok(new TutorialClassViewModel(tutorialClass));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TutorialClassExists(Guid id)
        {
            return db.TutorialClasses.Count(e => e.id == id) > 0;
        }
    }
}