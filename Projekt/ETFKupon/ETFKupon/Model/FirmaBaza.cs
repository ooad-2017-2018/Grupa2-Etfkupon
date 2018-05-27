using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETFKupon.Model
{
    public class FirmaBaza
    {
        public string id { get; set;  }
        public string Naziv { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public double StanjeRacuna { get; set; }
        
        public FirmaBaza(string _naziv, string _username, string _password, string _email, double _stanjeRacuna)
        {
            Naziv = _naziv;
            Username = _username;
            Password = _password;
            Email = _email;
            StanjeRacuna = _stanjeRacuna;
        }
    }
}
