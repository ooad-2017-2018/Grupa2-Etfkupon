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
    public class KuponController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: Kupon
        public ActionResult Index()
        {
            return View(db.Kupon.ToList());
        }

        // GET: Kupon/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kupon kupon = db.Kupon.Find(id);
            if (kupon == null)
            {
                return HttpNotFound();
            }
            return View(kupon);
        }

        // GET: Kupon/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Kupon/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Postotak,Kolicina,idFirma")] Kupon kupon)
        {
            if (ModelState.IsValid)
            {
                db.Kupon.Add(kupon);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kupon);
        }

        // GET: Kupon/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kupon kupon = db.Kupon.Find(id);
            if (kupon == null)
            {
                return HttpNotFound();
            }
            return View(kupon);
        }

        // POST: Kupon/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Postotak,Kolicina,idFirma")] Kupon kupon)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kupon).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kupon);
        }

        // GET: Kupon/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kupon kupon = db.Kupon.Find(id);
            if (kupon == null)
            {
                return HttpNotFound();
            }
            return View(kupon);
        }

        // POST: Kupon/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Kupon kupon = db.Kupon.Find(id);
            db.Kupon.Remove(kupon);
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
