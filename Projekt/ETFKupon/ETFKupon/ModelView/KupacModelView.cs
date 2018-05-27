using ETFKupon.Model;
using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Popups;

namespace ETFKupon.ModelView
{
    public class KupacModelView
    {
        private Kupac kupac;
        public ICommand Dodaj { get; set; }
        public INavigationService NavigationService { get; set; }
        public Kupac Kupac
        {
            get { return kupac; }
            set { kupac = value; OnPropertyChanged("Kupac"); }
        }
        public KupacModelView()
        {
            kupac = new Kupac();
            NavigationService = new NavigationService();
            Dodaj = new RelayCommand(dodaj);
        }

        public void dodaj(object parametar)
        {
            IMobileServiceTable<KupacBaza> userTableObj = App.MobileService.GetTable<KupacBaza>();
            //IMobileServiceTable<proba> blabla = App.MobileService.GetTable<proba>();
            Validacija vKupac = new Validacija();
            Tuple<int, string> vAdresa;
            Tuple<int, string> vIme;
            Tuple<int, string> vPrezime;
            Tuple<int, string> vUsername;
            Tuple<int, string> vPassword;
            Tuple<int, string> vEmail;
            Tuple<int, string> vPasswordPotvrda;

            vAdresa = vKupac.ValidirajAdresuKupca(Kupac.Adresa);
            vIme = vKupac.ValidirajImeKupca(Kupac.Ime);
            vPrezime = vKupac.ValidirajPrezimeKupca(Kupac.Prezime);
            vUsername = vKupac.ValidirajUsernameKupca(Kupac.Username);
            vPassword = vKupac.ValidirajPasswordKupca(Kupac.Password);
            vEmail = vKupac.ValidirajEmailKupca(Kupac.Email);
            vPasswordPotvrda = vKupac.ValidirajPasswordPotvrduKupca(Kupac.Password, Kupac.PasswordPotvrda);
            int suma = vAdresa.Item1 + vIme.Item1 + vPrezime.Item1 + vPassword.Item1 + vEmail.Item1 + vUsername.Item1 + vPasswordPotvrda.Item1;
            if (suma == 0)
            {
                KupacBaza x = new KupacBaza(Kupac.Ime, Kupac.Prezime, Kupac.Username, Kupac.Password, Kupac.Email, Kupac.Adresa, Kupac.BrojKartice, Kupac.StanjeRacuna);
                MainPage.etfKupon.ListaKupaca.Add(Kupac);
                userTableObj.InsertAsync(x);
                NavigationService.Navigate(typeof(MainPage), new MainPage(this));
                return;
            }
            string poruka = "";
            if (vAdresa.Item1 != 0) poruka += vAdresa.Item2 + '\n';
            if (vIme.Item1 != 0) poruka += vIme.Item2 + '\n';
            if (vPrezime.Item1 != 0) poruka += vPrezime.Item2 + '\n';
            if (vUsername.Item1 != 0) poruka += vUsername.Item2 + '\n';
            if (vPassword.Item1 != 0) poruka += vPassword.Item2 + '\n';
            if (vEmail.Item1 != 0) poruka += vEmail.Item2 + '\n';
            if (vPasswordPotvrda.Item1 != 0) poruka += vPasswordPotvrda.Item2 + '\n';

            if (poruka != null) new MessageDialog(poruka).ShowAsync();

            //CloseAction();
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
