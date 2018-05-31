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
    public class InteresKupcaController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: InteresKupca
        public ActionResult Index()
        {
            return View(db.InteresKupca.ToList());
        }

        // GET: InteresKupca/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InteresKupca interesKupca = db.InteresKupca.Find(id);
            if (interesKupca == null)
            {
                return HttpNotFound();
            }
            return View(interesKupca);
        }

        // GET: InteresKupca/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InteresKupca/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,idKupac,idInteres")] InteresKupca interesKupca)
        {
            if (ModelState.IsValid)
            {
                db.InteresKupca.Add(interesKupca);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(interesKupca);
        }

        // GET: InteresKupca/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InteresKupca interesKupca = db.InteresKupca.Find(id);
            if (interesKupca == null)
            {
                return HttpNotFound();
            }
            return View(interesKupca);
        }

        // POST: InteresKupca/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,idKupac,idInteres")] InteresKupca interesKupca)
        {
            if (ModelState.IsValid)
            {
                db.Entry(interesKupca).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(interesKupca);
        }

        // GET: InteresKupca/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InteresKupca interesKupca = db.InteresKupca.Find(id);
            if (interesKupca == null)
            {
                return HttpNotFound();
            }
            return View(interesKupca);
        }

        // POST: InteresKupca/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            InteresKupca interesKupca = db.InteresKupca.Find(id);
            db.InteresKupca.Remove(interesKupca);
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
