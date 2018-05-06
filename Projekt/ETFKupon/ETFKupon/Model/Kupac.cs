using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETFKupon.Model
{
    public class Kupac
    {
        public int IdKupca { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string UserName { get; set; }
        private string Password;
        public string Email { get; set; }
        public string Adresa { get; set; }
        public string BrKartice { get; set; }
        public double StanjeRacuna { get; set; }
        //TODO slika
        public List<Interes> ListaInteresa { get; set; }
        public Korpa MojaKorpa { get; set; }

        public Kupac()
        {
            ListaInteresa = new List<Interes>();
        }

        public Kupac(int id, string ime, string prezime, string user, string lozinka, string email, string adresa, string kartica, double racun, List<Interes> interesi, Korpa korpa)
        {
            IdKupca = id;
            Ime = ime;
            Prezime = prezime;
            UserName = user;
            Password = lozinka;
            Email = email;
            Adresa = adresa;
            BrKartice = kartica;
            StanjeRacuna = racun;
            ListaInteresa = interesi;
            MojaKorpa = korpa;
        }

        public void uplatiNovac(double uplata = 0)
        {
            StanjeRacuna += uplata;
        }
    }
}
