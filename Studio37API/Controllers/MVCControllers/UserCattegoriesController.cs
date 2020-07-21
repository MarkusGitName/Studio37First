using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Studio37API.Models.DataBaseMdels;

namespace Studio37API.Controllers.MVCControllers
{
    public class UserCattegoriesController : Controller
    {
        private DataModel db = new DataModel();

        // GET: UserCattegories
        public async Task<ActionResult> Index()
        {
            var userCattegories = db.UserCattegories.Include(u => u.Category).Include(u => u.Profile);
            return View(await userCattegories.ToListAsync());
        }

        // GET: UserCattegories/Details/5
        public async Task<ActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserCattegory userCattegory = await db.UserCattegories.FindAsync(id);
            if (userCattegory == null)
            {
                return HttpNotFound();
            }
            return View(userCattegory);
        }

        // GET: UserCattegories/Create
        public ActionResult Create()
        {
            ViewBag.CattegorryID = new SelectList(db.Categories, "id", "Category1");
            ViewBag.UserID = new SelectList(db.Profiles, "UserID", "FirstName");
            return View();
        }

        // POST: UserCattegories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "id,UserID,CattegorryID")] UserCattegory userCattegory)
        {
            if (ModelState.IsValid)
            {
                userCattegory.id = Guid.NewGuid();
                db.UserCattegories.Add(userCattegory);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.CattegorryID = new SelectList(db.Categories, "id", "Category1", userCattegory.CattegorryID);
            ViewBag.UserID = new SelectList(db.Profiles, "UserID", "FirstName", userCattegory.UserID);
            return View(userCattegory);
        }

        // GET: UserCattegories/Edit/5
        public async Task<ActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserCattegory userCattegory = await db.UserCattegories.FindAsync(id);
            if (userCattegory == null)
            {
                return HttpNotFound();
            }
            ViewBag.CattegorryID = new SelectList(db.Categories, "id", "Category1", userCattegory.CattegorryID);
            ViewBag.UserID = new SelectList(db.Profiles, "UserID", "FirstName", userCattegory.UserID);
            return View(userCattegory);
        }

        // POST: UserCattegories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "id,UserID,CattegorryID")] UserCattegory userCattegory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userCattegory).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.CattegorryID = new SelectList(db.Categories, "id", "Category1", userCattegory.CattegorryID);
            ViewBag.UserID = new SelectList(db.Profiles, "UserID", "FirstName", userCattegory.UserID);
            return View(userCattegory);
        }

        // GET: UserCattegories/Delete/5
        public async Task<ActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserCattegory userCattegory = await db.UserCattegories.FindAsync(id);
            if (userCattegory == null)
            {
                return HttpNotFound();
            }
            return View(userCattegory);
        }

        // POST: UserCattegories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(Guid id)
        {
            UserCattegory userCattegory = await db.UserCattegories.FindAsync(id);
            db.UserCattegories.Remove(userCattegory);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
