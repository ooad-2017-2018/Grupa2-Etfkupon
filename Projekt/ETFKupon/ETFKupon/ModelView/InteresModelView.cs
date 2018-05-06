using ETFKupon.Interface;
using ETFKupon.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ETFKupon.ModelView
{
    public class InteresModelView
    {
        public ICommand Dodaj { get; set; }
        public ICommand Odbaci { get; set; }
        public InteresModelView()
        {
            Dodaj = new RelayCommand(dodaj);
            Odbaci = new RelayCommand(odbaci);
        }

        public Action CloseAction { get; set; }

        public void dodaj(object parametar)
        {
            MainPage.etfKupon.ListaKupaca.ElementAt(MainPage.etfKupon.ListaKupaca.Count - 1).ListaInteresa.Add((Interes)parametar);
            //CloseAction();
        }

        public void odbaci(object parametar)
        {
            MainPage.etfKupon.ListaKupaca.Find(x => x.Username == MainPage.TrenutniKupac.Username).ListaInteresa.Remove((Interes)parametar);
        }
    }
}
