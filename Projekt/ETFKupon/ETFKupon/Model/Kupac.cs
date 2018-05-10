using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace ETFKupon.Model
{
    public class Kupac : INotifyPropertyChanged
    {
        public static int id = -1;
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Username { get; set; }
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
            id++;
            ListaInteresa = new List<Interes>();
        }

        public Kupac(string ime, string prezime, string user, string lozinka, string email, string adresa, string kartica, double racun, BitmapImage slika,  List<Interes> interesi, Korpa korpa)
        {
            Ime = ime;
            Prezime = prezime;
            Username = user;
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
