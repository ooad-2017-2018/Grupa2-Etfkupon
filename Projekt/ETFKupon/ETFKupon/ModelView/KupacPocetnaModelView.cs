using ETFKupon.Interface;
using ETFKupon.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ETFKupon.ModelView
{
    public class KupacPocetnaModelView
    {
        private Kupac novi;
        public INavigationService NavigationService { get; set; }
        public ICommand Azuriraj { get; set; }
        public ICommand Odbaci { get; set; }
        public Kupac Novi
        {
            get { return novi; }
            set { novi = value; OnPropertyChanged("Azurirani kupac"); }
        }
        public KupacPocetnaModelView()
        {
            novi = new Kupac();
            NavigationService = new NavigationService();
            Azuriraj = new RelayCommand(azuriraj);
            Odbaci = new RelayCommand(odbaci);
        }
        
        public void azuriraj(object parametar)
        {
            int i = MainPage.etfKupon.ListaKupaca.FindIndex(x => x.Username == MainPage.TrenutniKupac.Username);
            if (novi.Ime != null)
                MainPage.etfKupon.ListaKupaca.ElementAt(i).Ime = novi.Ime;
            if(novi.Prezime != null)
                MainPage.etfKupon.ListaKupaca.ElementAt(i).Prezime = novi.Prezime;
            if (novi.Username != null)
                MainPage.etfKupon.ListaKupaca.ElementAt(i).Username = novi.Username;
            //TODO kako password zamijeniti 
            /*if (novi.Password != null)
                MainPage.etfKupon.ListaKupaca.ElementAt(i).Password = novi.Password*/
            if (novi.Email != null)
                MainPage.etfKupon.ListaKupaca.ElementAt(i).Email = novi.Email;
            if (novi.BrojKartice != null)
                MainPage.etfKupon.ListaKupaca.ElementAt(i).BrojKartice = novi.BrojKartice;
            //TODO slika

            NavigationService.Navigate(typeof(PocetnaKupca), new PocetnaKupca(this));
        }

        public void odbaci(object parametar)
        {
            MainPage.etfKupon.ListaKupaca.Remove(Novi);
            MainPage.TrenutniKupac = null;
            NavigationService.Navigate(typeof(MainPage), new MainPage(this));
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
