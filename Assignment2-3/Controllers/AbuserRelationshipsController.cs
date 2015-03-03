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
    public class AbuserRelationshipsController : Controller
    {
        private ClientContext db = new ClientContext();

        // GET: AbuserRelationships
        public async Task<ActionResult> Index()
        {
            return View(await db.AbuserRelationships.ToListAsync());
        }

        // GET: AbuserRelationships/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AbuserRelationship abuserRelationship = await db.AbuserRelationships.FindAsync(id);
            if (abuserRelationship == null)
            {
                return HttpNotFound();
            }
            return View(abuserRelationship);
        }

        // GET: AbuserRelationships/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AbuserRelationships/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "AbuserRelationshipId,AbuRelationship")] AbuserRelationship abuserRelationship)
        {
            if (ModelState.IsValid)
            {
                db.AbuserRelationships.Add(abuserRelationship);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(abuserRelationship);
        }

        // GET: AbuserRelationships/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AbuserRelationship abuserRelationship = await db.AbuserRelationships.FindAsync(id);
            if (abuserRelationship == null)
            {
                return HttpNotFound();
            }
            return View(abuserRelationship);
        }

        // POST: AbuserRelationships/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "AbuserRelationshipId,AbuRelationship")] AbuserRelationship abuserRelationship)
        {
            if (ModelState.IsValid)
            {
                db.Entry(abuserRelationship).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(abuserRelationship);
        }

        // GET: AbuserRelationships/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AbuserRelationship abuserRelationship = await db.AbuserRelationships.FindAsync(id);
            if (abuserRelationship == null)
            {
                return HttpNotFound();
            }
            return View(abuserRelationship);
        }

        // POST: AbuserRelationships/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            AbuserRelationship abuserRelationship = await db.AbuserRelationships.FindAsync(id);
            db.AbuserRelationships.Remove(abuserRelationship);
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
