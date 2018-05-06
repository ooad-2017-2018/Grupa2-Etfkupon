using ETFKupon.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ETFKupon.ModelView
{
    public class KorpaModelView
    {
        public ICommand Dodaj{ get; set; }
        public ICommand Odbaci { get; set; }
        public KorpaModelView()
        {
            Dodaj = new RelayCommand(dodaj);
            Odbaci = new RelayCommand(odbaci);
        }

        public Action CloseAction { get; set; }

        public void dodaj(object parametar)
        {
            MainPage.etfKupon.ListaKupaca.Find(x => x.Username == MainPage.TrenutniKupac.Username).MojaKorpa = (Korpa)parametar;
        }

        public void odbaci(object parametar)
        {
            MainPage.etfKupon.ListaKupaca.Find(x => x.Username == MainPage.TrenutniKupac.Username).MojaKorpa = null;
            //CloseAction();
        }
    }
}
