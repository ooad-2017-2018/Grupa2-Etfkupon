﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ETFKupon.Models;

namespace ETFKupon.Controllers
{
    public class FirmaBazaController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: FirmaBaza
        public ActionResult Index()
        {
            return View(db.FirmaBaza.ToList());
        }

        // GET: FirmaBaza/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FirmaBaza firmaBaza = db.FirmaBaza.Find(id);
            if (firmaBaza == null)
            {
                return HttpNotFound();
            }
            return View(firmaBaza);
        }

        // GET: FirmaBaza/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FirmaBaza/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Naziv,Username,Password,Email,StanjeRacuna")] FirmaBaza firmaBaza)
        {
            if (ModelState.IsValid)
            {
                db.FirmaBaza.Add(firmaBaza);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(firmaBaza);
        }

        // GET: FirmaBaza/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FirmaBaza firmaBaza = db.FirmaBaza.Find(id);
            if (firmaBaza == null)
            {
                return HttpNotFound();
            }
            return View(firmaBaza);
        }

        // POST: FirmaBaza/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Naziv,Username,Password,Email,StanjeRacuna")] FirmaBaza firmaBaza)
        {
            if (ModelState.IsValid)
            {
                db.Entry(firmaBaza).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(firmaBaza);
        }

        // GET: FirmaBaza/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FirmaBaza firmaBaza = db.FirmaBaza.Find(id);
            if (firmaBaza == null)
            {
                return HttpNotFound();
            }
            return View(firmaBaza);
        }

        // POST: FirmaBaza/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            FirmaBaza firmaBaza = db.FirmaBaza.Find(id);
            db.FirmaBaza.Remove(firmaBaza);
            db.SaveChanges();
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
