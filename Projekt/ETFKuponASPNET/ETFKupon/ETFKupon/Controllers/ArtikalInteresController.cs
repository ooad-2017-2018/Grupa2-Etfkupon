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
    public class ArtikalInteresController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: ArtikalInteres
        public ActionResult Index()
        {
            List<object> lista = new List<object>();
            List<Artikal> listaArtikala = new List<Artikal>();
            listaArtikala = db.Artikal.ToList();
            List<Artikal> vracamArtikal = new List<Artikal>();
            foreach (Artikal item in listaArtikala)
                if (item.Naziv.Contains(Session["Pretraga"].ToString()))
                    vracamArtikal.Add(item);
            return View(lista);
        }

        // GET: ArtikalInteres/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ArtikalInteres artikalInteres = db.ArtikalInteres.Find(id);
            if (artikalInteres == null)
            {
                return HttpNotFound();
            }
            return View(artikalInteres);
        }

        // GET: ArtikalInteres/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ArtikalInteres/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,idArtikla,idInteresa")] ArtikalInteres artikalInteres)
        {
            if (ModelState.IsValid)
            {
                db.ArtikalInteres.Add(artikalInteres);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(artikalInteres);
        }

        // GET: ArtikalInteres/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ArtikalInteres artikalInteres = db.ArtikalInteres.Find(id);
            if (artikalInteres == null)
            {
                return HttpNotFound();
            }
            return View(artikalInteres);
        }

        // POST: ArtikalInteres/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,idArtikla,idInteresa")] ArtikalInteres artikalInteres)
        {
            if (ModelState.IsValid)
            {
                db.Entry(artikalInteres).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(artikalInteres);
        }

        // GET: ArtikalInteres/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ArtikalInteres artikalInteres = db.ArtikalInteres.Find(id);
            if (artikalInteres == null)
            {
                return HttpNotFound();
            }
            return View(artikalInteres);
        }

        // POST: ArtikalInteres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            ArtikalInteres artikalInteres = db.ArtikalInteres.Find(id);
            db.ArtikalInteres.Remove(artikalInteres);
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
