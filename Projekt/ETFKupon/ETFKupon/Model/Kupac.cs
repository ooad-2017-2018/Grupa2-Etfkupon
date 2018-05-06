using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace ETFKupon.Model
{
    public class Kupac
    {
        public string id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string UserName { get; set; }
        private string password;
        public string Password { set => password = value; }
        public string Email { get; set; }
        public string Adresa { get; set; }
        public string BrojKartice { get; set; }
        public double StanjeRacuna { get; set; }
        public BitmapImage Slika { get; set; }
        public List<Interes> ListaInteresa { get; set; }
        public Korpa MojaKorpa { get; set; }
        

        public Kupac()
        {
            ListaInteresa = new List<Interes>();
        }

        public Kupac(string _id, string ime, string prezime, string user, string lozinka, string email, string adresa, string kartica, double racun, BitmapImage slika,  List<Interes> interesi, Korpa korpa)
        {
            id = _id;
            Ime = ime;
            Prezime = prezime;
            UserName = user;
            Password = lozinka;
            Email = email;
            Adresa = adresa;
            BrojKartice = kartica;
            StanjeRacuna = racun;
            Slika = slika;
            ListaInteresa = interesi;
            MojaKorpa = korpa;
        }

        public void uplatiNovac(double uplata = 0)
        {
            StanjeRacuna += uplata;
        }
    }
}
