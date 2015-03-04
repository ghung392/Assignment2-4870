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
    public class RiskStatusController : Controller
    {
        private ClientContext db = new ClientContext();

        // GET: RiskStatus
        public async Task<ActionResult> Index()
        {
            return View(await db.RiskStatuses.ToListAsync());
        }

        // GET: RiskStatus/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RiskStatus riskStatus = await db.RiskStatuses.FindAsync(id);
            if (riskStatus == null)
            {
                return HttpNotFound();
            }
            return View(riskStatus);
        }

        // GET: RiskStatus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RiskStatus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "RiskStatusId,Status")] RiskStatus riskStatus)
        {
            if (ModelState.IsValid)
            {
                db.RiskStatuses.Add(riskStatus);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(riskStatus);
        }

        // GET: RiskStatus/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RiskStatus riskStatus = await db.RiskStatuses.FindAsync(id);
            if (riskStatus == null)
            {
                return HttpNotFound();
            }
            return View(riskStatus);
        }

        // POST: RiskStatus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "RiskStatusId,Status")] RiskStatus riskStatus)
        {
            if (ModelState.IsValid)
            {
                db.Entry(riskStatus).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(riskStatus);
        }

        // GET: RiskStatus/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RiskStatus riskStatus = await db.RiskStatuses.FindAsync(id);
            if (riskStatus == null)
            {
                return HttpNotFound();
            }
            return View(riskStatus);
        }

        // POST: RiskStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            RiskStatus riskStatus = await db.RiskStatuses.FindAsync(id);
            db.RiskStatuses.Remove(riskStatus);
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
