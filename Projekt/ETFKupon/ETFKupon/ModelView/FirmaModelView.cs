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
    public class FirmaModelView
    {
        private Firma firma;
        public INavigationService NavigationService { get; set; }
        public ICommand Dodaj { get; set; }
        public Firma Firma
        {
            get { return firma; }
            set { firma = value; OnPropertyChanged("Firma"); }
        }

        public FirmaModelView()
        {
            firma = new Firma();
            NavigationService = new NavigationService();
            Dodaj = new RelayCommand(dodaj);
        }

        public void dodaj(object parametar)
        {
            IMobileServiceTable<Firma> userTableObj = App.MobileService.GetTable<Firma>();
            Validacija vKupac = new Validacija();
            
            
            Tuple<int, string> vUsername;
            Tuple<int, string> vPassword;
            Tuple<int, string> vEmail;
            Tuple<int, string> vNaziv;
            Tuple<int, string> vPasswordPotvrda;

            
            vUsername = vKupac.ValidirajUsernameKupca(firma.Username);
            vPassword = vKupac.ValidirajPasswordKupca(firma.Password);
            vEmail = vKupac.ValidirajEmailKupca(firma.Email);
            vNaziv = vKupac.ValidirajNazivFirme(firma.Naziv);
            vPasswordPotvrda = vKupac.ValidirajPasswordPotvrduFirme(firma.Password, firma.PasswordPotvrda);

            int suma = vUsername.Item1 + vPassword.Item1 + vEmail.Item1 + vEmail.Item1 + vPasswordPotvrda.Item1;
            if (suma == 0)
            {
                userTableObj.InsertAsync(firma);
                MainPage.etfKupon.ListaFirmi.Add(firma);
                NavigationService.Navigate(typeof(MainPage), new MainPage(this));
                return;
            }
            string poruka = "";
            
            if (vNaziv.Item1 != 0) poruka += vNaziv.Item2 + '\n';
            if (vUsername.Item1 != 0) poruka += vUsername.Item2 + '\n';
            if (vPassword.Item1 != 0) poruka += vPassword.Item2 + '\n';
            if (vEmail.Item1 != 0) poruka += vEmail.Item2 + '\n';
            if (vPasswordPotvrda.Item1 != 0) poruka += vPasswordPotvrda.Item2 + '\n';

            if (poruka != null) new MessageDialog(poruka).ShowAsync();

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