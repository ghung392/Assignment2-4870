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
    public class FamilyViolenceFilesController : Controller
    {
        private ClientContext db = new ClientContext();

        // GET: FamilyViolenceFiles
        public async Task<ActionResult> Index()
        {
            return View(await db.FamilyViolencesFiles.ToListAsync());
        }

        // GET: FamilyViolenceFiles/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FamilyViolenceFile familyViolenceFile = await db.FamilyViolencesFiles.FindAsync(id);
            if (familyViolenceFile == null)
            {
                return HttpNotFound();
            }
            return View(familyViolenceFile);
        }

        // GET: FamilyViolenceFiles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FamilyViolenceFiles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "FamilyViolenceFileId,Value")] FamilyViolenceFile familyViolenceFile)
        {
            if (ModelState.IsValid)
            {
                db.FamilyViolencesFiles.Add(familyViolenceFile);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(familyViolenceFile);
        }

        // GET: FamilyViolenceFiles/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FamilyViolenceFile familyViolenceFile = await db.FamilyViolencesFiles.FindAsync(id);
            if (familyViolenceFile == null)
            {
                return HttpNotFound();
            }
            return View(familyViolenceFile);
        }

        // POST: FamilyViolenceFiles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "FamilyViolenceFileId,Value")] FamilyViolenceFile familyViolenceFile)
        {
            if (ModelState.IsValid)
            {
                db.Entry(familyViolenceFile).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(familyViolenceFile);
        }

        // GET: FamilyViolenceFiles/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FamilyViolenceFile familyViolenceFile = await db.FamilyViolencesFiles.FindAsync(id);
            if (familyViolenceFile == null)
            {
                return HttpNotFound();
            }
            return View(familyViolenceFile);
        }

        // POST: FamilyViolenceFiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            FamilyViolenceFile familyViolenceFile = await db.FamilyViolencesFiles.FindAsync(id);
            db.FamilyViolencesFiles.Remove(familyViolenceFile);
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
