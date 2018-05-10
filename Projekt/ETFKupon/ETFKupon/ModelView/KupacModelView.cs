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
    public class KupacModelView
    {
        private Kupac kupac;
        public ICommand Dodaj { get; set; }
        public INavigationService NavigationService { get; set; }        public Kupac Kupac
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
            MainPage.etfKupon.ListaKupaca.Add(Kupac);
            NavigationService.Navigate(typeof(MainPage), new MainPage(this));
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
