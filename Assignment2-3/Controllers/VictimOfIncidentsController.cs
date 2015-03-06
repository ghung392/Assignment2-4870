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
    public class VictimOfIncidentsController : Controller
    {
        private ClientContext db = new ClientContext();

        // GET: VictimOfIncidents
        public async Task<ActionResult> Index()
        {
            return View(await db.VictimsOfIncident.ToListAsync());
        }

        // GET: VictimOfIncidents/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VictimOfIncident victimOfIncident = await db.VictimsOfIncident.FindAsync(id);
            if (victimOfIncident == null)
            {
                return HttpNotFound();
            }
            return View(victimOfIncident);
        }

        // GET: VictimOfIncidents/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VictimOfIncidents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "VictimOfIncidentId,Description")] VictimOfIncident victimOfIncident)
        {
            if (ModelState.IsValid)
            {
                db.VictimsOfIncident.Add(victimOfIncident);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(victimOfIncident);
        }

        // GET: VictimOfIncidents/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VictimOfIncident victimOfIncident = await db.VictimsOfIncident.FindAsync(id);
            if (victimOfIncident == null)
            {
                return HttpNotFound();
            }
            return View(victimOfIncident);
        }

        // POST: VictimOfIncidents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "VictimOfIncidentId,Description")] VictimOfIncident victimOfIncident)
        {
            if (ModelState.IsValid)
            {
                db.Entry(victimOfIncident).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(victimOfIncident);
        }

        // GET: VictimOfIncidents/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VictimOfIncident victimOfIncident = await db.VictimsOfIncident.FindAsync(id);
            if (victimOfIncident == null)
            {
                return HttpNotFound();
            }
            return View(victimOfIncident);
        }

        // POST: VictimOfIncidents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            VictimOfIncident victimOfIncident = await db.VictimsOfIncident.FindAsync(id);
            db.VictimsOfIncident.Remove(victimOfIncident);
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
