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
    public class DuplicateFilesController : Controller
    {
        private ClientContext db = new ClientContext();

        // GET: DuplicateFiles
        public async Task<ActionResult> Index()
        {
            return View(await db.DuplicateFiles.ToListAsync());
        }

        // GET: DuplicateFiles/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DuplicateFile duplicateFile = await db.DuplicateFiles.FindAsync(id);
            if (duplicateFile == null)
            {
                return HttpNotFound();
            }
            return View(duplicateFile);
        }

        // GET: DuplicateFiles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DuplicateFiles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "DuplicateFileId,Value")] DuplicateFile duplicateFile)
        {
            if (ModelState.IsValid)
            {
                db.DuplicateFiles.Add(duplicateFile);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(duplicateFile);
        }

        // GET: DuplicateFiles/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DuplicateFile duplicateFile = await db.DuplicateFiles.FindAsync(id);
            if (duplicateFile == null)
            {
                return HttpNotFound();
            }
            return View(duplicateFile);
        }

        // POST: DuplicateFiles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "DuplicateFileId,Value")] DuplicateFile duplicateFile)
        {
            if (ModelState.IsValid)
            {
                db.Entry(duplicateFile).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(duplicateFile);
        }

        // GET: DuplicateFiles/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DuplicateFile duplicateFile = await db.DuplicateFiles.FindAsync(id);
            if (duplicateFile == null)
            {
                return HttpNotFound();
            }
            return View(duplicateFile);
        }

        // POST: DuplicateFiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            DuplicateFile duplicateFile = await db.DuplicateFiles.FindAsync(id);
            db.DuplicateFiles.Remove(duplicateFile);
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
