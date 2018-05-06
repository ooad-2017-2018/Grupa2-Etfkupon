using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETFKupon.Model
{
    public class Firma
    {
        public string id { get; set; }
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
            ListaKupona = new List<Kupon>();
            ListaArtikala = new List<Artikal>();
        }
        public Firma(string _id, string ime, string user, string lozinka, string mail, List<Artikal> artikli, List<Kupon> kuponi)
        {
            id = _id;
            Naziv = ime;
            Username = user;
            Password = lozinka;
            ListaArtikala = artikli;
            ListaKupona = kuponi;
        }
    }
}
