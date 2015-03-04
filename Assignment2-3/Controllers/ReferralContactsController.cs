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
    public class ReferralContactsController : Controller
    {
        private ClientContext db = new ClientContext();

        // GET: ReferralContacts
        public async Task<ActionResult> Index()
        {
            return View(await db.ReferralContacts.ToListAsync());
        }

        // GET: ReferralContacts/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferralContact referralContact = await db.ReferralContacts.FindAsync(id);
            if (referralContact == null)
            {
                return HttpNotFound();
            }
            return View(referralContact);
        }

        // GET: ReferralContacts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReferralContacts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ReferralContactId,Contact")] ReferralContact referralContact)
        {
            if (ModelState.IsValid)
            {
                db.ReferralContacts.Add(referralContact);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(referralContact);
        }

        // GET: ReferralContacts/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferralContact referralContact = await db.ReferralContacts.FindAsync(id);
            if (referralContact == null)
            {
                return HttpNotFound();
            }
            return View(referralContact);
        }

        // POST: ReferralContacts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ReferralContactId,Contact")] ReferralContact referralContact)
        {
            if (ModelState.IsValid)
            {
                db.Entry(referralContact).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(referralContact);
        }

        // GET: ReferralContacts/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferralContact referralContact = await db.ReferralContacts.FindAsync(id);
            if (referralContact == null)
            {
                return HttpNotFound();
            }
            return View(referralContact);
        }

        // POST: ReferralContacts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            ReferralContact referralContact = await db.ReferralContacts.FindAsync(id);
            db.ReferralContacts.Remove(referralContact);
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
