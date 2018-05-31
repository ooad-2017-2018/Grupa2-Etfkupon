using System;
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
    public class KorpaController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: Korpa
        public ActionResult Index()
        {
            return View(db.Korpa.ToList());
        }

        // GET: Korpa/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Korpa korpa = db.Korpa.Find(id);
            if (korpa == null)
            {
                return HttpNotFound();
            }
            return View(korpa);
        }

        // GET: Korpa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Korpa/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,idKupac,idArtikal")] Korpa korpa)
        {
            if (ModelState.IsValid)
            {
                db.Korpa.Add(korpa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(korpa);
        }

        // GET: Korpa/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Korpa korpa = db.Korpa.Find(id);
            if (korpa == null)
            {
                return HttpNotFound();
            }
            return View(korpa);
        }

        // POST: Korpa/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,idKupac,idArtikal")] Korpa korpa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(korpa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(korpa);
        }

        // GET: Korpa/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Korpa korpa = db.Korpa.Find(id);
            if (korpa == null)
            {
                return HttpNotFound();
            }
            return View(korpa);
        }

        // POST: Korpa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Korpa korpa = db.Korpa.Find(id);
            db.Korpa.Remove(korpa);
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
