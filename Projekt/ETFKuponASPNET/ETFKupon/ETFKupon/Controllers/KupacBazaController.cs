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
            List<object> lista = new List<object>();

            List<InteresKupca> interesiLista = new List<InteresKupca>();
            foreach (InteresKupca x in db.InteresKupca.ToList())
                if (x.idKupac.Equals(Session["UserId"].ToString()))
                    interesiLista.Add(x);

            List<Interes> interesiKupca = new List<Interes>();
            foreach (InteresKupca y in interesiLista)
               interesiKupca.Add(db.Interes.ToList().Find(x => x.id.Equals(y.idInteres)));

            lista.Add(interesiKupca);

            List<ArtikalInteres> interesArtikal = new List<ArtikalInteres>();
            foreach (ArtikalInteres x in db.ArtikalInteres.ToList())
                foreach(Interes y in interesiKupca)
                    if (x.idInteresa.Equals(y.id))
                        interesArtikal.Add(x);

            List<Artikal> artikliKupca = new List<Artikal>();
            foreach (ArtikalInteres y in interesArtikal)
                artikliKupca.Add(db.Artikal.ToList().Find(x => x.id.Equals(y.idArtikla)));

            lista.Add(artikliKupca);

            List<Korpa> korpaKupca = db.Korpa.ToList();
            List<Artikal> artikliKorpa = new List<Artikal>();
            foreach (Korpa x in korpaKupca) {
                if (x.idKupac.Equals(Session["UserId"]))
                    foreach (Artikal y in db.Artikal.ToList())
                        if (y.id.Equals(x.idArtikal))
                            artikliKorpa.Add(y);
            }

            lista.Add(artikliKorpa);

            ViewBag.ListaInteresaSelekcija = new List<SelectListItem>() ;
            for (int i = 0; i < db.Interes.ToList().Count; i++)
                ViewBag.ListaInteresaSelekcija.Add(
                    new SelectListItem()
                    {
                        Value = db.Interes.ToList()[i].id,
                        Text = db.Interes.ToList()[i].Naziv
                    });
            
            return View(lista);
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
                return RedirectToAction("Index", "Home");
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
            return RedirectToAction("Index", "Home");
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
