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
    public class PoliceReportedsController : Controller
    {
        private ClientContext db = new ClientContext();

        // GET: PoliceReporteds
        public async Task<ActionResult> Index()
        {
            return View(await db.PolicesReported.ToListAsync());
        }

        // GET: PoliceReporteds/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PoliceReported policeReported = await db.PolicesReported.FindAsync(id);
            if (policeReported == null)
            {
                return HttpNotFound();
            }
            return View(policeReported);
        }

        // GET: PoliceReporteds/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PoliceReporteds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "PoliceReportedId,Description")] PoliceReported policeReported)
        {
            if (ModelState.IsValid)
            {
                db.PolicesReported.Add(policeReported);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(policeReported);
        }

        // GET: PoliceReporteds/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PoliceReported policeReported = await db.PolicesReported.FindAsync(id);
            if (policeReported == null)
            {
                return HttpNotFound();
            }
            return View(policeReported);
        }

        // POST: PoliceReporteds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "PoliceReportedId,Description")] PoliceReported policeReported)
        {
            if (ModelState.IsValid)
            {
                db.Entry(policeReported).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(policeReported);
        }

        // GET: PoliceReporteds/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PoliceReported policeReported = await db.PolicesReported.FindAsync(id);
            if (policeReported == null)
            {
                return HttpNotFound();
            }
            return View(policeReported);
        }

        // POST: PoliceReporteds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            PoliceReported policeReported = await db.PolicesReported.FindAsync(id);
            db.PolicesReported.Remove(policeReported);
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
