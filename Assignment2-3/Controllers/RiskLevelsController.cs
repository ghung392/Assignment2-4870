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
    public class RiskLevelsController : Controller
    {
        private ClientContext db = new ClientContext();

        // GET: RiskLevels
        public async Task<ActionResult> Index()
        {
            return View(await db.RiskLevels.ToListAsync());
        }

        // GET: RiskLevels/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RiskLevel riskLevel = await db.RiskLevels.FindAsync(id);
            if (riskLevel == null)
            {
                return HttpNotFound();
            }
            return View(riskLevel);
        }

        // GET: RiskLevels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RiskLevels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "RiskLevelId,Level")] RiskLevel riskLevel)
        {
            if (ModelState.IsValid)
            {
                db.RiskLevels.Add(riskLevel);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(riskLevel);
        }

        // GET: RiskLevels/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RiskLevel riskLevel = await db.RiskLevels.FindAsync(id);
            if (riskLevel == null)
            {
                return HttpNotFound();
            }
            return View(riskLevel);
        }

        // POST: RiskLevels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "RiskLevelId,Level")] RiskLevel riskLevel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(riskLevel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(riskLevel);
        }

        // GET: RiskLevels/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RiskLevel riskLevel = await db.RiskLevels.FindAsync(id);
            if (riskLevel == null)
            {
                return HttpNotFound();
            }
            return View(riskLevel);
        }

        // POST: RiskLevels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            RiskLevel riskLevel = await db.RiskLevels.FindAsync(id);
            db.RiskLevels.Remove(riskLevel);
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
