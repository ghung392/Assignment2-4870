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
    public class DrugAssaultsController : Controller
    {
        private ClientContext db = new ClientContext();

        // GET: DrugAssaults
        public async Task<ActionResult> Index()
        {
            return View(await db.DrugAssaults.ToListAsync());
        }

        // GET: DrugAssaults/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DrugAssault drugAssault = await db.DrugAssaults.FindAsync(id);
            if (drugAssault == null)
            {
                return HttpNotFound();
            }
            return View(drugAssault);
        }

        // GET: DrugAssaults/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DrugAssaults/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "DrugAssaultId,Description")] DrugAssault drugAssault)
        {
            if (ModelState.IsValid)
            {
                db.DrugAssaults.Add(drugAssault);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(drugAssault);
        }

        // GET: DrugAssaults/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DrugAssault drugAssault = await db.DrugAssaults.FindAsync(id);
            if (drugAssault == null)
            {
                return HttpNotFound();
            }
            return View(drugAssault);
        }

        // POST: DrugAssaults/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "DrugAssaultId,Description")] DrugAssault drugAssault)
        {
            if (ModelState.IsValid)
            {
                db.Entry(drugAssault).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(drugAssault);
        }

        // GET: DrugAssaults/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DrugAssault drugAssault = await db.DrugAssaults.FindAsync(id);
            if (drugAssault == null)
            {
                return HttpNotFound();
            }
            return View(drugAssault);
        }

        // POST: DrugAssaults/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            DrugAssault drugAssault = await db.DrugAssaults.FindAsync(id);
            db.DrugAssaults.Remove(drugAssault);
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
