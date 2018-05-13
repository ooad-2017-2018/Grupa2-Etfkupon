using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETFKupon.ETFBaza.Models
{
    class Kupac
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
        //public byte[] Slika { get; set; }
    }
}
