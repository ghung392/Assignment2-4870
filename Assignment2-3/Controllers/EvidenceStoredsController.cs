﻿using System;
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
    public class EvidenceStoredsController : Controller
    {
        private ClientContext db = new ClientContext();

        // GET: EvidenceStoreds
        public async Task<ActionResult> Index()
        {
            return View(await db.EvidencesStored.ToListAsync());
        }

        // GET: EvidenceStoreds/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EvidenceStored evidenceStored = await db.EvidencesStored.FindAsync(id);
            if (evidenceStored == null)
            {
                return HttpNotFound();
            }
            return View(evidenceStored);
        }

        // GET: EvidenceStoreds/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EvidenceStoreds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "EvidenceStoredId,Description")] EvidenceStored evidenceStored)
        {
            if (ModelState.IsValid)
            {
                db.EvidencesStored.Add(evidenceStored);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(evidenceStored);
        }

        // GET: EvidenceStoreds/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EvidenceStored evidenceStored = await db.EvidencesStored.FindAsync(id);
            if (evidenceStored == null)
            {
                return HttpNotFound();
            }
            return View(evidenceStored);
        }

        // POST: EvidenceStoreds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "EvidenceStoredId,Description")] EvidenceStored evidenceStored)
        {
            if (ModelState.IsValid)
            {
                db.Entry(evidenceStored).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(evidenceStored);
        }

        // GET: EvidenceStoreds/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EvidenceStored evidenceStored = await db.EvidencesStored.FindAsync(id);
            if (evidenceStored == null)
            {
                return HttpNotFound();
            }
            return View(evidenceStored);
        }

        // POST: EvidenceStoreds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            EvidenceStored evidenceStored = await db.EvidencesStored.FindAsync(id);
            db.EvidencesStored.Remove(evidenceStored);
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
