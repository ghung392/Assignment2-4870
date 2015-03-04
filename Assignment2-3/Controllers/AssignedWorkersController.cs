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
    public class AssignedWorkersController : Controller
    {
        private ClientContext db = new ClientContext();

        // GET: AssignedWorkers
        public async Task<ActionResult> Index()
        {
            return View(await db.AssignedWorkers.ToListAsync());
        }

        // GET: AssignedWorkers/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AssignedWorker assignedWorker = await db.AssignedWorkers.FindAsync(id);
            if (assignedWorker == null)
            {
                return HttpNotFound();
            }
            return View(assignedWorker);
        }

        // GET: AssignedWorkers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AssignedWorkers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "AssignedWorkerId,Worker")] AssignedWorker assignedWorker)
        {
            if (ModelState.IsValid)
            {
                db.AssignedWorkers.Add(assignedWorker);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(assignedWorker);
        }

        // GET: AssignedWorkers/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AssignedWorker assignedWorker = await db.AssignedWorkers.FindAsync(id);
            if (assignedWorker == null)
            {
                return HttpNotFound();
            }
            return View(assignedWorker);
        }

        // POST: AssignedWorkers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "AssignedWorkerId,Worker")] AssignedWorker assignedWorker)
        {
            if (ModelState.IsValid)
            {
                db.Entry(assignedWorker).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(assignedWorker);
        }

        // GET: AssignedWorkers/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AssignedWorker assignedWorker = await db.AssignedWorkers.FindAsync(id);
            if (assignedWorker == null)
            {
                return HttpNotFound();
            }
            return View(assignedWorker);
        }

        // POST: AssignedWorkers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            AssignedWorker assignedWorker = await db.AssignedWorkers.FindAsync(id);
            db.AssignedWorkers.Remove(assignedWorker);
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
