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
    public class InteresModelView
    {
        private Interes interes;
        public ICommand Dodaj { get; set; }
        public ICommand Odbaci { get; set; }
        public INavigationService NavigationService { get; set; }
        public Interes Interes
        {
            get { return interes; }
            set { interes = value; OnPropertyChanged("Interes"); }
        }

        public InteresModelView()
        {
            interes = new Interes();
            NavigationService = new NavigationService();
            Dodaj = new RelayCommand(dodaj);
            Odbaci = new RelayCommand(odbaci);
        }
        
        public void dodaj(object parametar)
        {
            MainPage.TrenutniKupac.ListaInteresa.Add(interes);
            //NavigationService.Navigate(typeof(PocetnaKupca), new PocetnaKupca(this));
        }

        public void odbaci(object parametar)
        {
            MainPage.etfKupon.ListaKupaca.Find(x => x.Username == MainPage.TrenutniKupac.Username).ListaInteresa.Remove(interes);
            NavigationService.Navigate(typeof(PocetnaKupca), new PocetnaKupca(this));
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
