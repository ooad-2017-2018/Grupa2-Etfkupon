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
            MainPage.etfKupon.ListaFirmi.Add(firma);
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