using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETFKupon.Model
{
    public class Firma: INotifyPropertyChanged
    {
        //public static int id = -1;
        public string id { get; set;  }
        public string Naziv { get; set; }
        public string Username { get; set; }
        private string password;
        public string Password { get; set; }
        public string PasswordPotvrda { get; set; }
        public string Email { get; set; }
        public double StanjeRacuna { get; }
        public List<Artikal> ListaArtikala { get; set; }
        public List<Kupon> ListaKupona { get; set; }
        

        public Firma()
        {
            //id++;
            ListaKupona = new List<Kupon>();
            ListaArtikala = new List<Artikal>();
            Naziv = Username = Password = PasswordPotvrda = Email = "";
            StanjeRacuna = 0;
        }
        public Firma(string ime, string user, string lozinka, string mail, List<Artikal> artikli, List<Kupon> kuponi)
        {
            Naziv = ime;
            Username = user;
            Password = lozinka;
            ListaArtikala = artikli;
            ListaKupona = kuponi;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
