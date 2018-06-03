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
        private double cijena = 0;
        private int num = 0;

        // GET: Artikal
        public ActionResult Index()
        {
            return View(db.Artikal.ToList());
        }

        // GET: Artikal/Details/5
        public ActionResult Details(string id, string kolicinaArtikala = "1")
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Session["ArtikalId"] = id;
            num = int.Parse(kolicinaArtikala);
            Artikal artikal = db.Artikal.Find(id);
            if (artikal == null)
            {
                return HttpNotFound();
            }
            cijena = artikal.Cijena * Int64.Parse(kolicinaArtikala);

            Kupon k = db.Kupon.Find(artikal.idKupon);
            if (k != null) {
                if (k.Kolicina != 0) {
                    cijena -= cijena * (k.Postotak / 100);
                    ViewBag.postotakSnizenja = "Artikal ima kupon s popustom od " + k.Postotak.ToString() + "%";
                }
            }
            ViewBag.isplata = "Iznos za naplatu je " + cijena.ToString();
            /*KupacBaza kupac = db.KupacBaza.Find(Session["UserId"]);
            kupac.StanjeRacuna -= cijena;
            db.Entry(kupac).State = EntityState.Modified;
            db.SaveChanges();*/

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
        public ActionResult SaveRecords(Artikal model)
        {
            try
            {
                Artikal artikal = new Artikal();
                artikal.Naziv = model.Naziv;
                artikal.Kolicina = model.Kolicina;
                artikal.Cijena = model.Cijena;
                FirmaBaza firmaBaza = Session["User"] as ETFKupon.Models.FirmaBaza;
                artikal.idFirma = firmaBaza.id;
                Kupon k = new Kupon();
                artikal.idKupon = model.idKupon; //pokupiti element iz dropdown

                db.Artikal.Add(artikal);
                db.SaveChanges();
                String lastArtikalId = artikal.id;

            }
            catch (Exception e) {
                throw e;
            }
            return RedirectToAction("Index");
        }

        public ActionResult Kupovina()
        {
            try
            {
                KupacBaza kupac = db.KupacBaza.Find(Session["UserId"]);
                if (kupac != null)
                {
                    if (kupac.StanjeRacuna >= cijena)
                    {
                        kupac.StanjeRacuna -= cijena;
                        db.Entry(kupac).State = EntityState.Modified;
                        db.SaveChanges();
                        Artikal artikal = db.Artikal.Find(Session["ArtikalId"]);
                        if (artikal != null)
                        {
                            Kupon k = db.Kupon.Find(artikal.idKupon);
                            if (k != null)
                            {
                                if (k.Kolicina - 1 == 0)
                                {
                                    db.Kupon.Remove(k);
                                    db.SaveChanges();
                                    artikal.idKupon = null;
                                }
                                else
                                {
                                    k.Kolicina--;
                                    db.Entry(k).State = EntityState.Modified;
                                    db.SaveChanges();
                                }
                            }

                            artikal.Kolicina -= num;
                            if (artikal.Kolicina - 1 <= 0)
                            {
                                db.Artikal.Remove(artikal);
                                db.SaveChanges();
                            }
                            else
                            {
                                db.Entry(artikal).State = EntityState.Modified;
                                db.SaveChanges();
                            }

                            Korpa korpa = new Korpa();
                            korpa.idKupac = kupac.id;
                            korpa.idArtikal = artikal.id;
                            db.Korpa.Add(korpa);
                            db.SaveChanges();

                            ViewBag.novac = "Kupovina uspjesna!";
                        }
                    } else { ViewBag.novac = "Zao nam je, nemate dovoljno sredstava na racunu!"; }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return RedirectToAction("Index");
        }
    }
}
