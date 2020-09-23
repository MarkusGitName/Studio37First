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
    public class SalesController : ApiController
    {
        private DataBaseModels db = new DataBaseModels();

        // GET: api/Sales
        public List<SaleViewModel> GetSales()
        {
            List<SaleViewModel> SaleList = new List<SaleViewModel>();

            foreach(Sale incomingSale in db.Sales)
            {
                SaleList.Add(new SaleViewModel(incomingSale));
            }

            return SaleList;
        }

        // GET: api/Sales/5
        [ResponseType(typeof(SaleViewModel))]
        public async Task<IHttpActionResult> GetSale(Guid id)
        {
            Sale sale = await db.Sales.FindAsync(id);
            if (sale == null)
            {
                return NotFound();
            }

            return Ok(new SaleViewModel(sale));
        }

        // PUT: api/Sales/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutSale(Guid id, Sale sale)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sale.id)
            {
                return BadRequest();
            }

            db.Entry(sale).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SaleExists(id))
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

        // POST: api/Sales
        [ResponseType(typeof(SaleViewModel))]
        public async Task<IHttpActionResult> PostSale(Sale sale)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Sales.Add(sale);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SaleExists(sale.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = sale.id }, new SaleViewModel(sale));
        }

        // DELETE: api/Sales/5
        [ResponseType(typeof(SaleViewModel))]
        public async Task<IHttpActionResult> DeleteSale(Guid id)
        {
            Sale sale = await db.Sales.FindAsync(id);
            if (sale == null)
            {
                return NotFound();
            }

            db.Sales.Remove(sale);
            await db.SaveChangesAsync();

            return Ok(new SaleViewModel(sale));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SaleExists(Guid id)
        {
            return db.Sales.Count(e => e.id == id) > 0;
        }
    }
}