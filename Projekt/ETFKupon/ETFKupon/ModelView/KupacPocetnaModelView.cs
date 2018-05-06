using ETFKupon.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ETFKupon.ModelView
{
    public class KupacPocetnaModelView
    {
        public ICommand Azuriraj { get; set; }
        public ICommand Odbaci { get; set; }

        public KupacPocetnaModelView()
        {
            Azuriraj = new RelayCommand(azuriraj);
            Odbaci = new RelayCommand(odbaci);
        }

        public Action CloseAction { get; set; }

        public void azuriraj(object parametar)
        {
            Kupac novi = (Kupac)parametar;
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
        }

        public void odbaci(object parametar)
        {
            MainPage.etfKupon.ListaKupaca.Remove((Kupac)parametar);
        }
    }
}
