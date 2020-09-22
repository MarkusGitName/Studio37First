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
    public class ClassVideoSalesController : ApiController
    {
        private DataBaseModels db = new DataBaseModels();

        // GET: api/ClassVideoSales
        public List<ClassVideoSaleViewModel> GetClassVideoSales()
        {
            List<ClassVideoSaleViewModel> ClassVideoSaleList = new List<ClassVideoSaleViewModel>;

            foreach(ClassVideoSale incomingClassVideoSale in db.ClassVideoSales)
            {
                ClassVideoSaleList.Add(new ClassVideoSaleViewModel(incomingClassVideoSale));
            }

            return ClassVideoSaleList;
        }

        // GET: api/ClassVideoSales/5
        [ResponseType(typeof(ClassVideoSale))]
        public async Task<IHttpActionResult> GetClassVideoSale(Guid id)
        {
            ClassVideoSale classVideoSale = await db.ClassVideoSales.FindAsync(id);
            if (classVideoSale == null)
            {
                return NotFound();
            }

            return Ok(new ClassRatingViewModel(classVideoSale));
        }

        // PUT: api/ClassVideoSales/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutClassVideoSale(Guid id, ClassVideoSale classVideoSale)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != classVideoSale.id)
            {
                return BadRequest();
            }

            db.Entry(classVideoSale).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClassVideoSaleExists(id))
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

        // POST: api/ClassVideoSales
        [ResponseType(typeof(ClassVideoSale))]
        public async Task<IHttpActionResult> PostClassVideoSale(ClassVideoSale classVideoSale)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ClassVideoSales.Add(classVideoSale);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ClassVideoSaleExists(classVideoSale.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = classVideoSale.id }, new ClassRatingViewModel(classVideoSale));
        }

        // DELETE: api/ClassVideoSales/5
        [ResponseType(typeof(ClassVideoSale))]
        public async Task<IHttpActionResult> DeleteClassVideoSale(Guid id)
        {
            ClassVideoSale classVideoSale = await db.ClassVideoSales.FindAsync(id);
            if (classVideoSale == null)
            {
                return NotFound();
            }

            db.ClassVideoSales.Remove(classVideoSale);
            await db.SaveChangesAsync();

            return Ok(new ClassRatingViewModel(classVideoSale));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ClassVideoSaleExists(Guid id)
        {
            return db.ClassVideoSales.Count(e => e.id == id) > 0;
        }
    }
}