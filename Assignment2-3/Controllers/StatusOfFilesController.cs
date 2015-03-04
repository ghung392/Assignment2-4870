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
    public class StatusOfFilesController : Controller
    {
        private ClientContext db = new ClientContext();

        // GET: StatusOfFiles
        public async Task<ActionResult> Index()
        {
            return View(await db.StatusOfFiles.ToListAsync());
        }

        // GET: StatusOfFiles/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StatusOfFile statusOfFile = await db.StatusOfFiles.FindAsync(id);
            if (statusOfFile == null)
            {
                return HttpNotFound();
            }
            return View(statusOfFile);
        }

        // GET: StatusOfFiles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StatusOfFiles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "StatusOfFileId,Status")] StatusOfFile statusOfFile)
        {
            if (ModelState.IsValid)
            {
                db.StatusOfFiles.Add(statusOfFile);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(statusOfFile);
        }

        // GET: StatusOfFiles/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StatusOfFile statusOfFile = await db.StatusOfFiles.FindAsync(id);
            if (statusOfFile == null)
            {
                return HttpNotFound();
            }
            return View(statusOfFile);
        }

        // POST: StatusOfFiles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "StatusOfFileId,Status")] StatusOfFile statusOfFile)
        {
            if (ModelState.IsValid)
            {
                db.Entry(statusOfFile).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(statusOfFile);
        }

        // GET: StatusOfFiles/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StatusOfFile statusOfFile = await db.StatusOfFiles.FindAsync(id);
            if (statusOfFile == null)
            {
                return HttpNotFound();
            }
            return View(statusOfFile);
        }

        // POST: StatusOfFiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            StatusOfFile statusOfFile = await db.StatusOfFiles.FindAsync(id);
            db.StatusOfFiles.Remove(statusOfFile);
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
