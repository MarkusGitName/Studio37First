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
    public class TutorialSalesController : ApiController
    {
        private DataBaseModels db = new DataBaseModels();

        // GET: api/TutorialSales
        public IQueryable<TutorialSale> GetTutorialSales()
        {
            return db.TutorialSales;
        }

        // GET: api/TutorialSales/5
        [ResponseType(typeof(TutorialSale))]
        public async Task<IHttpActionResult> GetTutorialSale(Guid id)
        {
            TutorialSale tutorialSale = await db.TutorialSales.FindAsync(id);
            if (tutorialSale == null)
            {
                return NotFound();
            }

            return Ok(tutorialSale);
        }

        // PUT: api/TutorialSales/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutTutorialSale(Guid id, TutorialSale tutorialSale)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tutorialSale.id)
            {
                return BadRequest();
            }

            db.Entry(tutorialSale).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TutorialSaleExists(id))
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

        // POST: api/TutorialSales
        [ResponseType(typeof(TutorialSale))]
        public async Task<IHttpActionResult> PostTutorialSale(TutorialSale tutorialSale)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TutorialSales.Add(tutorialSale);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TutorialSaleExists(tutorialSale.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = tutorialSale.id }, tutorialSale);
        }

        // DELETE: api/TutorialSales/5
        [ResponseType(typeof(TutorialSale))]
        public async Task<IHttpActionResult> DeleteTutorialSale(Guid id)
        {
            TutorialSale tutorialSale = await db.TutorialSales.FindAsync(id);
            if (tutorialSale == null)
            {
                return NotFound();
            }

            db.TutorialSales.Remove(tutorialSale);
            await db.SaveChangesAsync();

            return Ok(tutorialSale);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TutorialSaleExists(Guid id)
        {
            return db.TutorialSales.Count(e => e.id == id) > 0;
        }
    }
}