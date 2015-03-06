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
    [Authorize(Roles = "Administrator")]
    public class ReferredCbvsController : Controller
    {
        private ClientContext db = new ClientContext();

        // GET: ReferredCbvs
        public async Task<ActionResult> Index()
        {
            return View(await db.ReferredCbvses.ToListAsync());
        }

        // GET: ReferredCbvs/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferredCbvs referredCbvs = await db.ReferredCbvses.FindAsync(id);
            if (referredCbvs == null)
            {
                return HttpNotFound();
            }
            return View(referredCbvs);
        }

        // GET: ReferredCbvs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReferredCbvs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ReferredCbvsId,Description")] ReferredCbvs referredCbvs)
        {
            if (ModelState.IsValid)
            {
                db.ReferredCbvses.Add(referredCbvs);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(referredCbvs);
        }

        // GET: ReferredCbvs/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferredCbvs referredCbvs = await db.ReferredCbvses.FindAsync(id);
            if (referredCbvs == null)
            {
                return HttpNotFound();
            }
            return View(referredCbvs);
        }

        // POST: ReferredCbvs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ReferredCbvsId,Description")] ReferredCbvs referredCbvs)
        {
            if (ModelState.IsValid)
            {
                db.Entry(referredCbvs).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(referredCbvs);
        }

        // GET: ReferredCbvs/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferredCbvs referredCbvs = await db.ReferredCbvses.FindAsync(id);
            if (referredCbvs == null)
            {
                return HttpNotFound();
            }
            return View(referredCbvs);
        }

        // POST: ReferredCbvs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            ReferredCbvs referredCbvs = await db.ReferredCbvses.FindAsync(id);
            db.ReferredCbvses.Remove(referredCbvs);
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
