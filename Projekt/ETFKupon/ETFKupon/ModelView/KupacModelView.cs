using ETFKupon.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ETFKupon.ModelView
{
    public class KupacModelView
    {
        public ICommand Dodaj { get; set; }
        public KupacModelView()
        {
            Dodaj = new RelayCommand(dodaj);
        }

        public Action CloseAction { get; set; }

        public void dodaj(object parametar)
        {
            MainPage.etfKupon.ListaKupaca.Add((Kupac)parametar);
            //CloseAction();
        }
    }
}
