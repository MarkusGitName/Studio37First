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
    public class ProfesionallsProfilesController : ApiController
    {
        private DataBaseModels db = new DataBaseModels();

        // GET: api/ProfesionallsProfiles
        public List<ProfesionallsProfileViewModel> GetProfesionallsProfiles()
        {
            List<ProfesionallsProfileViewModel> ProfessionalProfileList = new List<ProfesionallsProfileViewModel>();

            foreach(ProfesionallsProfile incomingProfessionalProfile in db.ProfesionallsProfiles)
            {
                ProfessionalProfileList.Add(new ProfesionallsProfileViewModel(incomingProfessionalProfile));
            }

            return ProfessionalProfileList;
        }

        // GET: api/ProfesionallsProfiles/5
        [ResponseType(typeof(ProfesionallsProfile))]
        public async Task<IHttpActionResult> GetProfesionallsProfile(string id)
        {
            ProfesionallsProfile profesionallsProfile = await db.ProfesionallsProfiles.FindAsync(id);
            if (profesionallsProfile == null)
            {
                return NotFound();
            }

            return Ok(new ProfesionallsProfileViewModel(profesionallsProfile));
        }

        // PUT: api/ProfesionallsProfiles/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutProfesionallsProfile(string id, ProfesionallsProfile profesionallsProfile)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != profesionallsProfile.UserID)
            {
                return BadRequest();
            }

            db.Entry(profesionallsProfile).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProfesionallsProfileExists(id))
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

        // POST: api/ProfesionallsProfiles
        [ResponseType(typeof(ProfesionallsProfile))]
        public async Task<IHttpActionResult> PostProfesionallsProfile(ProfesionallsProfile profesionallsProfile)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ProfesionallsProfiles.Add(profesionallsProfile);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ProfesionallsProfileExists(profesionallsProfile.UserID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = profesionallsProfile.UserID }, new ProfesionallsProfileViewModel(profesionallsProfile));
        }

        // DELETE: api/ProfesionallsProfiles/5
        [ResponseType(typeof(ProfesionallsProfile))]
        public async Task<IHttpActionResult> DeleteProfesionallsProfile(string id)
        {
            ProfesionallsProfile profesionallsProfile = await db.ProfesionallsProfiles.FindAsync(id);
            if (profesionallsProfile == null)
            {
                return NotFound();
            }

            db.ProfesionallsProfiles.Remove(profesionallsProfile);
            await db.SaveChangesAsync();

            return Ok(new ProfesionallsProfileViewModel(profesionallsProfile));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProfesionallsProfileExists(string id)
        {
            return db.ProfesionallsProfiles.Count(e => e.UserID == id) > 0;
        }
    }
}