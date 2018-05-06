using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETFKupon.Model
{
    public class Firma
    {
        public static int id = -1;
        public string Naziv { get; set; }
        public string Username { get; set; }
        private string password;
        public string Password { set => password = value; }
        public string Email { get; set; }
        public double StanjeRacuna { get; }
        public List<Artikal> ListaArtikala { get; set; }
        public List<Kupon> ListaKupona { get; set; }
        

        public Firma()
        {
            id++;
            ListaKupona = new List<Kupon>();
            ListaArtikala = new List<Artikal>();
        }
        public Firma(string ime, string user, string lozinka, string mail, List<Artikal> artikli, List<Kupon> kuponi)
        {
            Naziv = ime;
            Username = user;
            Password = lozinka;
            ListaArtikala = artikli;
            ListaKupona = kuponi;
        }
    }
}
