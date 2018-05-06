using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETFKupon.Model
{
    public class Firma
    {
        public int IdFirme { get; set; }
        public string Naziv { get; set; }
        public string Username { get; set; }
        private string Password;
        public string Email { get; set; }
        public double StanjeRacuna { get; }
        public List<Artikal> ListaArtikala { get; set; }
        public List<Kupon> ListaKupona { get; set; }

        public Firma()
        {
            ListaKupona = new List<Kupon>();
            ListaArtikala = new List<Artikal>();
        }
        public Firma(int id, string ime, string user, string lozinka, string mail, List<Artikal> artikli, List<Kupon> kuponi)
        {
            IdFirme = id;
            Naziv = ime;
            Username = user;
            Password = lozinka;
            ListaArtikala = artikli;
            ListaKupona = kuponi;
        }
    }
}
