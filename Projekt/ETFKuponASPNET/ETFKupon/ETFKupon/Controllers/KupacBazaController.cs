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
    public class KupacBazaController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: KupacBaza
        public ActionResult Index()
        {
            return View(db.KupacBaza.ToList());
        }

        // GET: KupacBaza/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KupacBaza kupacBaza = db.KupacBaza.Find(id);
            if (kupacBaza == null)
            {
                return HttpNotFound();
            }
            return View(kupacBaza);
        }

        // GET: KupacBaza/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KupacBaza/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Ime,Prezime,Username,Password,Email,Adresa,BrojKartice,StanjeRacuna")] KupacBaza kupacBaza)
        {
            if (ModelState.IsValid)
            {
                db.KupacBaza.Add(kupacBaza);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kupacBaza);
        }

        // GET: KupacBaza/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KupacBaza kupacBaza = db.KupacBaza.Find(id);
            if (kupacBaza == null)
            {
                return HttpNotFound();
            }
            return View(kupacBaza);
        }

        // POST: KupacBaza/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Ime,Prezime,Username,Password,Email,Adresa,BrojKartice,StanjeRacuna")] KupacBaza kupacBaza)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kupacBaza).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kupacBaza);
        }

        // GET: KupacBaza/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KupacBaza kupacBaza = db.KupacBaza.Find(id);
            if (kupacBaza == null)
            {
                return HttpNotFound();
            }
            return View(kupacBaza);
        }

        // POST: KupacBaza/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            KupacBaza kupacBaza = db.KupacBaza.Find(id);
            db.KupacBaza.Remove(kupacBaza);
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
