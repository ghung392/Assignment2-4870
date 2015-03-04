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
    public class FiscalYearsController : Controller
    {
        private ClientContext db = new ClientContext();

        // GET: FiscalYears
        public async Task<ActionResult> Index()
        {
            return View(await db.FiscalYears.ToListAsync());
        }

        // GET: FiscalYears/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FiscalYear fiscalYear = await db.FiscalYears.FindAsync(id);
            if (fiscalYear == null)
            {
                return HttpNotFound();
            }
            return View(fiscalYear);
        }

        // GET: FiscalYears/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FiscalYears/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "FiscalYearId,Year")] FiscalYear fiscalYear)
        {
            if (ModelState.IsValid)
            {
                db.FiscalYears.Add(fiscalYear);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(fiscalYear);
        }

        // GET: FiscalYears/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FiscalYear fiscalYear = await db.FiscalYears.FindAsync(id);
            if (fiscalYear == null)
            {
                return HttpNotFound();
            }
            return View(fiscalYear);
        }

        // POST: FiscalYears/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "FiscalYearId,Year")] FiscalYear fiscalYear)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fiscalYear).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(fiscalYear);
        }

        // GET: FiscalYears/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FiscalYear fiscalYear = await db.FiscalYears.FindAsync(id);
            if (fiscalYear == null)
            {
                return HttpNotFound();
            }
            return View(fiscalYear);
        }

        // POST: FiscalYears/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            FiscalYear fiscalYear = await db.FiscalYears.FindAsync(id);
            db.FiscalYears.Remove(fiscalYear);
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
