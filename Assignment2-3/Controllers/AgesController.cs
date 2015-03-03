using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Assignment2_3.Models.Entities;
using Assignment2_3.Models.Lookup;

namespace Assignment2_3.Controllers
{
    public class AgesController : Controller
    {
        private ClientContext db = new ClientContext();

        // GET: Ages
        public async Task<ActionResult> Index()
        {
            return View(await db.Ages.ToListAsync());
        }

        // GET: Ages/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Age age = await db.Ages.FindAsync(id);
            if (age == null)
            {
                return HttpNotFound();
            }
            return View(age);
        }

        // GET: Ages/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "AgeId,Value")] Age age)
        {
            if (ModelState.IsValid)
            {
                db.Ages.Add(age);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(age);
        }

        // GET: Ages/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Age age = await db.Ages.FindAsync(id);
            if (age == null)
            {
                return HttpNotFound();
            }
            return View(age);
        }

        // POST: Ages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "AgeId,Value")] Age age)
        {
            if (ModelState.IsValid)
            {
                db.Entry(age).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(age);
        }

        // GET: Ages/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Age age = await db.Ages.FindAsync(id);
            if (age == null)
            {
                return HttpNotFound();
            }
            return View(age);
        }

        // POST: Ages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Age age = await db.Ages.FindAsync(id);
            db.Ages.Remove(age);
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
