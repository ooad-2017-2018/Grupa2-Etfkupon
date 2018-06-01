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
    public class InteresController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: Interes
        public ActionResult Index()
        {
            return View(db.Interes.ToList());
        }

        // GET: Interes/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Interes interes = db.Interes.Find(id);
            if (interes == null)
            {
                return HttpNotFound();
            }
            return View(interes);
        }

        // GET: Interes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Interes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Naziv")] Interes interes)
        {
            if (ModelState.IsValid)
            {
                db.Interes.Add(interes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(interes);
        }

        // GET: Interes/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Interes interes = db.Interes.Find(id);
            if (interes == null)
            {
                return HttpNotFound();
            }
            return View(interes);
        }

        // POST: Interes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Naziv")] Interes interes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(interes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(interes);
        }

        // GET: Interes/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Interes interes = db.Interes.Find(id);
            if (interes == null)
            {
                return HttpNotFound();
            }
            return View(interes);
        }

        // POST: Interes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Interes interes = db.Interes.Find(id);
            db.Interes.Remove(interes);
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

        public ActionResult SaveRecords(Interes model)
        {
            try
            {
                Interes interes = new Interes();
                interes.Naziv = model.Naziv;
          
                db.Interes.Add(interes);
                db.SaveChanges();
                String lastIntereslId = interes.id;

            }
            catch (Exception e)
            {
                throw e;
            }
            return RedirectToAction("Index");
        }
    }
}
