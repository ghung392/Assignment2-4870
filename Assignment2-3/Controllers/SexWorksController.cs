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
    public class SexWorksController : Controller
    {
        private ClientContext db = new ClientContext();

        // GET: SexWorks
        public async Task<ActionResult> Index()
        {
            return View(await db.SexWorks.ToListAsync());
        }

        // GET: SexWorks/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SexWork sexWork = await db.SexWorks.FindAsync(id);
            if (sexWork == null)
            {
                return HttpNotFound();
            }
            return View(sexWork);
        }

        // GET: SexWorks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SexWorks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "SexWorkId,Description")] SexWork sexWork)
        {
            if (ModelState.IsValid)
            {
                db.SexWorks.Add(sexWork);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(sexWork);
        }

        // GET: SexWorks/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SexWork sexWork = await db.SexWorks.FindAsync(id);
            if (sexWork == null)
            {
                return HttpNotFound();
            }
            return View(sexWork);
        }

        // POST: SexWorks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "SexWorkId,Description")] SexWork sexWork)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sexWork).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(sexWork);
        }

        // GET: SexWorks/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SexWork sexWork = await db.SexWorks.FindAsync(id);
            if (sexWork == null)
            {
                return HttpNotFound();
            }
            return View(sexWork);
        }

        // POST: SexWorks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            SexWork sexWork = await db.SexWorks.FindAsync(id);
            db.SexWorks.Remove(sexWork);
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
