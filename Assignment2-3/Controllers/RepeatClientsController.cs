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
    public class RepeatClientsController : Controller
    {
        private ClientContext db = new ClientContext();

        // GET: RepeatClients
        public async Task<ActionResult> Index()
        {
            return View(await db.RepeatClients.ToListAsync());
        }

        // GET: RepeatClients/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RepeatClient repeatClient = await db.RepeatClients.FindAsync(id);
            if (repeatClient == null)
            {
                return HttpNotFound();
            }
            return View(repeatClient);
        }

        // GET: RepeatClients/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RepeatClients/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "RepeatClientId,Value")] RepeatClient repeatClient)
        {
            if (ModelState.IsValid)
            {
                db.RepeatClients.Add(repeatClient);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(repeatClient);
        }

        // GET: RepeatClients/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RepeatClient repeatClient = await db.RepeatClients.FindAsync(id);
            if (repeatClient == null)
            {
                return HttpNotFound();
            }
            return View(repeatClient);
        }

        // POST: RepeatClients/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "RepeatClientId,Value")] RepeatClient repeatClient)
        {
            if (ModelState.IsValid)
            {
                db.Entry(repeatClient).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(repeatClient);
        }

        // GET: RepeatClients/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RepeatClient repeatClient = await db.RepeatClients.FindAsync(id);
            if (repeatClient == null)
            {
                return HttpNotFound();
            }
            return View(repeatClient);
        }

        // POST: RepeatClients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            RepeatClient repeatClient = await db.RepeatClients.FindAsync(id);
            db.RepeatClients.Remove(repeatClient);
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
