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
    public class KorpaModelView
    {
        private Korpa korpa;
        private Artikal artikal;
        public INavigationService NavigationService { get; set; }
        public ICommand Dodaj{ get; set; }
        public ICommand Odbaci { get; set; }
        public Korpa Korpa
        {
            get { return korpa; }
            set { korpa = value; OnPropertyChanged("Korpa"); }
        }
        public Artikal Artikal
        {
            get { return artikal; }
            set { artikal = value; OnPropertyChanged("Artikal"); }
        }

        public KorpaModelView()
        {
            korpa = new Korpa();
            MainPage.etfKupon.ListaKupaca.Find(x => x.Username == MainPage.TrenutniKupac.Username).MojaKorpa = korpa;
            artikal = new Artikal();
            NavigationService = new NavigationService();
            Dodaj = new RelayCommand(dodaj);
            Odbaci = new RelayCommand(odbaci);
        }
       
        public void dodaj(object parametar)
        {
           MainPage.etfKupon.ListaKupaca.Find(x => x.Username == MainPage.TrenutniKupac.Username).MojaKorpa.ListaArtikala.Add(Artikal);
        }

        public void odbaci(object parametar)
        {
            MainPage.etfKupon.ListaKupaca.Find(x => x.Username == MainPage.TrenutniKupac.Username).MojaKorpa.ListaArtikala.Remove(artikal);
            //NavigationService.Navigate(typeof(PocetnaKupca), new PocetnaKupca(this));
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
