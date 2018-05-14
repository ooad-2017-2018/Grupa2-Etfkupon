using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace ETFKupon.Model
{
    public class Kupac : INotifyPropertyChanged, INotifyDataErrorInfo
    {
        //public static int id = -1;
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Username { get; set; }
        private string password;
        public string Password { get;  set; }
        public string PasswordPotvrda { get; set; }
        public string Email { get; set; }
        public string Adresa { get; set; }
        public string BrojKartice { get; set; }
        public double StanjeRacuna { get; set; }
        public BitmapImage Slika { get; set; }
        public List<Interes> ListaInteresa { get; set; }
        public Korpa MojaKorpa { get; set; }

        public bool HasErrors => IsValid;

        public Kupac()
        {
            //id++;
            ListaInteresa = new List<Interes>();
            Ime = Prezime = Adresa = Username = Password = PasswordPotvrda = Email = BrojKartice = "";
            StanjeRacuna = 0;
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
        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public IEnumerable GetErrors(string propertyName)
        {
            Validacija vKupac = new Validacija();
            
            Tuple<int, string> vAdresa;
            Tuple<int, string> vIme;
            Tuple<int, string> vPrezime;
            Tuple<int, string> vUsername;
            Tuple<int, string> vPassword;
            Tuple<int, string> vEmail;

            vAdresa = vKupac.ValidirajAdresuKupca(this.Adresa);
            vIme = vKupac.ValidirajImeKupca(this.Ime);
            vPrezime = vKupac.ValidirajPrezimeKupca(this.Prezime);
            vUsername = vKupac.ValidirajUsernameKupca(this.Username);
            vPassword = vKupac.ValidirajPasswordKupca(this.Password);
            vEmail = vKupac.ValidirajEmailKupca(this.Email);
            
            string error = null;
            switch (propertyName)
            {
                case "Adresa":
                    error = vAdresa.Item2;
                    break;
                case "Ime":
                    error = vAdresa.Item2;
                    break;
                case "Prezime":
                    error = vAdresa.Item2;
                    break;
                case "Username":
                    error = vUsername.Item2;
                    break;
                case "Password":
                    error = vPassword.Item2;
                    break;
                case "Email":
                    error = vEmail.Item2;
                    break;
            }
            return error;
            //throw new NotImplementedException();
        }

        public bool IsValid
        {
            get
            {
                Validacija vKupac = new Validacija();
                Tuple<int, string> vAdresa;
                Tuple<int, string> vIme;
                Tuple<int, string> vPrezime;
                Tuple<int, string> vUsername;
                Tuple<int, string> vPassword;
                Tuple<int, string> vEmail;

                vAdresa = vKupac.ValidirajAdresuKupca(this.Adresa);
                vIme = vKupac.ValidirajImeKupca(this.Ime);
                vPrezime = vKupac.ValidirajPrezimeKupca(this.Prezime);
                vUsername = vKupac.ValidirajUsernameKupca(this.Username);
                vPassword = vKupac.ValidirajPasswordKupca(this.Password);
                vEmail = vKupac.ValidirajEmailKupca(this.Email);
                int suma = vAdresa.Item1 + vIme.Item1 + vPrezime.Item1 + vPassword.Item1 + vEmail.Item1;
                return suma == 0;
            }
        }

    }
}
