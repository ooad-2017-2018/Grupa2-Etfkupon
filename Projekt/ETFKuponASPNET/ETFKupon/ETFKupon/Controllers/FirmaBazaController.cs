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
    public class FirmaBazaController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: FirmaBaza
        public ActionResult Index()
        {
            FirmaBaza firmaBaza = Session["User"] as ETFKupon.Models.FirmaBaza;

            List<Artikal> artikliFime = new List<Artikal>();
            foreach (Artikal x in db.Artikal.ToList()) 
                if (firmaBaza != null && x.idFirma == firmaBaza.id)
                    artikliFime.Add(x);

            List<Kupon> kuponiFime = new List<Kupon>();
            foreach (Kupon x in db.Kupon.ToList())
                if (firmaBaza != null && x.idFirma == firmaBaza.id)
                    kuponiFime.Add(x);

            List<object> lista = new List<object>();
            lista.Add(artikliFime); 
            lista.Add(kuponiFime);

            List<Interes> interesiLista = new List<Interes>();
            interesiLista = db.Interes.ToList();
            ViewBag.ListaInteresaSelekcija = new List<SelectListItem>();

            for (int i = 0; i < interesiLista.Count; i++)
                ViewBag.ListaInteresaSelekcija.Add(
                    new SelectListItem()
                    {
                        Value = interesiLista[i].id,
                        Text = interesiLista[i].Naziv
                    });
            
            List<Artikal> artikliLista = new List<Artikal>();
            artikliLista = artikliFime;
            ViewBag.ListaArtikalaSelekcija = new List<SelectListItem>();
            for (int i = 0; i < artikliLista.Count; i++)
                ViewBag.ListaArtikalaSelekcija.Add(
                    new SelectListItem()
                    {
                        Value = i.ToString(),
                        Text = artikliLista[i].Naziv
                    });

            List<Kupon> kuponiLista = new List<Kupon>();
            kuponiLista = kuponiFime;
            ViewBag.ListaKuponaSelekcija = new List<SelectListItem>();
            for (int i = 0; i < kuponiLista.Count; i++)
                ViewBag.ListaKuponaSelekcija.Add(
                    new SelectListItem()
                    {
                        Value = db.Kupon.ToList()[i].id,
                        Text = kuponiLista[i].Kolicina.ToString() + kuponiLista[i].Postotak.ToString()
                    });

            return View(lista);
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
        public ActionResult Create([Bind(Include = "id,Naziv,Username,Password,Email,StanjeRacuna,Latitude,Longitude")] FirmaBaza firmaBaza)
        {
            if (ModelState.IsValid)
            {
                db.FirmaBaza.Add(firmaBaza);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
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

        public ActionResult SaveRecords() {
            return View();
        }
    }
}
