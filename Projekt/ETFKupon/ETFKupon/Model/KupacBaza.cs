using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETFKupon.Model
{
    class KupacBaza
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Adresa { get; set; }
        public string BrojKartice { get; set; }
        public double StanjeRacuna { get; set; }

        public KupacBaza(string _ime, string _prezime, string _username, string _password, string _email, string _adresa, string _brojKartice, double _stanjeRacuna)
        {
            Ime = _ime;
            Prezime = _prezime;
            Username = _username;
            Password = _password;
            Email = _email;
            Adresa = _adresa;
            BrojKartice = _brojKartice;
            StanjeRacuna = _stanjeRacuna;
        }
    }
}
