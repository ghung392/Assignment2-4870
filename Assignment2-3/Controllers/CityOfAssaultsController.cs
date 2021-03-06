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
    public class CityOfAssaultsController : Controller
    {
        private ClientContext db = new ClientContext();

        // GET: CityOfAssaults
        public async Task<ActionResult> Index()
        {
            return View(await db.CityOfAssaults.ToListAsync());
        }

        // GET: CityOfAssaults/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CityOfAssault cityOfAssault = await db.CityOfAssaults.FindAsync(id);
            if (cityOfAssault == null)
            {
                return HttpNotFound();
            }
            return View(cityOfAssault);
        }

        // GET: CityOfAssaults/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CityOfAssaults/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "CityOfAssaultId,Description")] CityOfAssault cityOfAssault)
        {
            if (ModelState.IsValid)
            {
                db.CityOfAssaults.Add(cityOfAssault);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(cityOfAssault);
        }

        // GET: CityOfAssaults/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CityOfAssault cityOfAssault = await db.CityOfAssaults.FindAsync(id);
            if (cityOfAssault == null)
            {
                return HttpNotFound();
            }
            return View(cityOfAssault);
        }

        // POST: CityOfAssaults/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "CityOfAssaultId,Description")] CityOfAssault cityOfAssault)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cityOfAssault).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(cityOfAssault);
        }

        // GET: CityOfAssaults/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CityOfAssault cityOfAssault = await db.CityOfAssaults.FindAsync(id);
            if (cityOfAssault == null)
            {
                return HttpNotFound();
            }
            return View(cityOfAssault);
        }

        // POST: CityOfAssaults/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            CityOfAssault cityOfAssault = await db.CityOfAssaults.FindAsync(id);
            db.CityOfAssaults.Remove(cityOfAssault);
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
