using ETFKupon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ETFKupon.Controllers
{
    public class HomeController : Controller
    {
        string passwordGreska;
        public ActionResult Index()
        {
            passwordGreska = "";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Index(string usernameLogin, string passwordLogin)
        {
            DatabaseContext db = new DatabaseContext();
            List<ETFKupon.Models.KupacBaza> listaKupaca = new List<Models.KupacBaza>();
            List<ETFKupon.Models.FirmaBaza> listaFirmi = new List<Models.FirmaBaza>();
            listaKupaca = db.KupacBaza.ToList();
            listaFirmi = db.FirmaBaza.ToList();
            for (int i = 0; i < listaKupaca.Count; i++)
            {
                if (listaKupaca[i].Username.Equals(usernameLogin))
                {

                    if (passwordLogin.Equals(listaKupaca[i].Password))
                    {
                        Session["User"] = listaKupaca[i];
                        Session["UserId"] = listaKupaca[i].id;
                        return RedirectToAction("Index", "KupacBaza");
                    }
                    else
                    {
                        //ModelState.AddModelError("Password", "Password ne valja!");
                        ViewBag.passwordGreska = "Password nije validan!";
                        return View();
                    }

                }
            }
            for (int i = 0; i < listaFirmi.Count; i++)
            {
                if (listaFirmi[i].Username.Equals(usernameLogin))
                {
                    if (passwordLogin.Equals(listaFirmi[i].Password))
                    {
                        Session["User"] = listaFirmi[i];
                        Session["UserId"] = listaFirmi[i].id;
                        return RedirectToAction("Index", "FirmaBaza");
                    }
                    else
                    {
                        //ModelState.AddModelError("Password", "Password ne valja!");
                        ViewBag.passwordGreska = "Password nije validan!";
                        return View();
                    }
                }
            }
            return Content($"E tebe nema {usernameLogin} {passwordLogin}");

        }
        /*public ActionResult Login()
        {
            return View("KupacBaza");
        }*/
    }
}
/*
 @using (Html.BeginForm("Index", "KupacBaza"))
    {
        <p><button type="submit" class="btn btn-primary btn-lg">Login</button></p>
    }
*/