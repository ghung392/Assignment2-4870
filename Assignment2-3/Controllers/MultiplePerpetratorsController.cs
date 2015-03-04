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
    public class MultiplePerpetratorsController : Controller
    {
        private ClientContext db = new ClientContext();

        // GET: MultiplePerpetrators
        public async Task<ActionResult> Index()
        {
            return View(await db.MultiplePerpetrators.ToListAsync());
        }

        // GET: MultiplePerpetrators/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MultiplePerpetrators multiplePerpetrators = await db.MultiplePerpetrators.FindAsync(id);
            if (multiplePerpetrators == null)
            {
                return HttpNotFound();
            }
            return View(multiplePerpetrators);
        }

        // GET: MultiplePerpetrators/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MultiplePerpetrators/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "MultiplePerpetratorsId,Description")] MultiplePerpetrators multiplePerpetrators)
        {
            if (ModelState.IsValid)
            {
                db.MultiplePerpetrators.Add(multiplePerpetrators);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(multiplePerpetrators);
        }

        // GET: MultiplePerpetrators/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MultiplePerpetrators multiplePerpetrators = await db.MultiplePerpetrators.FindAsync(id);
            if (multiplePerpetrators == null)
            {
                return HttpNotFound();
            }
            return View(multiplePerpetrators);
        }

        // POST: MultiplePerpetrators/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "MultiplePerpetratorsId,Description")] MultiplePerpetrators multiplePerpetrators)
        {
            if (ModelState.IsValid)
            {
                db.Entry(multiplePerpetrators).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(multiplePerpetrators);
        }

        // GET: MultiplePerpetrators/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MultiplePerpetrators multiplePerpetrators = await db.MultiplePerpetrators.FindAsync(id);
            if (multiplePerpetrators == null)
            {
                return HttpNotFound();
            }
            return View(multiplePerpetrators);
        }

        // POST: MultiplePerpetrators/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            MultiplePerpetrators multiplePerpetrators = await db.MultiplePerpetrators.FindAsync(id);
            db.MultiplePerpetrators.Remove(multiplePerpetrators);
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
