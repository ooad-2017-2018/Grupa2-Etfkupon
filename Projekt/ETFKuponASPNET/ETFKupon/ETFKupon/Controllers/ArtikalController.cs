using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ETFKupon.Models;

namespace ETFKupon.Controllers
{
    public class ArtikalController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: Artikal
        public ActionResult Index()
        {
            return View(db.Artikal.ToList());
        }

        // GET: Artikal/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artikal artikal = db.Artikal.Find(id);
            if (artikal == null)
            {
                return HttpNotFound();
            }
            return View(artikal);
        }

        // GET: Artikal/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Artikal/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Naziv,Kolicina,Cijena,idKupon,idFirma")] Artikal artikal)
        {
            if (ModelState.IsValid)
            {
                db.Artikal.Add(artikal);
                try
                {
                    db.SaveChanges();
                }
                catch (DbEntityValidationException e)
                {
                    foreach (var eve in e.EntityValidationErrors)
                    {
                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                ve.PropertyName, ve.ErrorMessage);
                        }
                    }
                }
                return RedirectToAction("Index");
            }

            return View(artikal);
        }

        // GET: Artikal/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artikal artikal = db.Artikal.Find(id);
            if (artikal == null)
            {
                return HttpNotFound();
            }
            return View(artikal);
        }

        // POST: Artikal/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Naziv,Kolicina,Cijena,idKupon,idFirma")] Artikal artikal)
        {
            if (ModelState.IsValid)
            {
                db.Entry(artikal).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(artikal);
        }

        // GET: Artikal/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artikal artikal = db.Artikal.Find(id);
            if (artikal == null)
            {
                return HttpNotFound();
            }
            return View(artikal);
        }

        // POST: Artikal/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Artikal artikal = db.Artikal.Find(id);
            db.Artikal.Remove(artikal);
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
