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
    public class ReferralSourcesController : Controller
    {
        private ClientContext db = new ClientContext();

        // GET: ReferralSources
        public async Task<ActionResult> Index()
        {
            return View(await db.ReferralSources.ToListAsync());
        }

        // GET: ReferralSources/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferralSource referralSource = await db.ReferralSources.FindAsync(id);
            if (referralSource == null)
            {
                return HttpNotFound();
            }
            return View(referralSource);
        }

        // GET: ReferralSources/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReferralSources/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ReferralSourceId,Source")] ReferralSource referralSource)
        {
            if (ModelState.IsValid)
            {
                db.ReferralSources.Add(referralSource);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(referralSource);
        }

        // GET: ReferralSources/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferralSource referralSource = await db.ReferralSources.FindAsync(id);
            if (referralSource == null)
            {
                return HttpNotFound();
            }
            return View(referralSource);
        }

        // POST: ReferralSources/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ReferralSourceId,Source")] ReferralSource referralSource)
        {
            if (ModelState.IsValid)
            {
                db.Entry(referralSource).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(referralSource);
        }

        // GET: ReferralSources/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferralSource referralSource = await db.ReferralSources.FindAsync(id);
            if (referralSource == null)
            {
                return HttpNotFound();
            }
            return View(referralSource);
        }

        // POST: ReferralSources/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            ReferralSource referralSource = await db.ReferralSources.FindAsync(id);
            db.ReferralSources.Remove(referralSource);
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
