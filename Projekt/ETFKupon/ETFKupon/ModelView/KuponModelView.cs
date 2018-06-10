using ETFKupon.Model;
using ETFKupon.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
namespace ETFKupon.ModelView
{
    public class KuponModelView
    {
        public ICommand DodajKupon { get; set; }
        public ICommand OdbaciKupon { get; set; }
        public KuponModelView()
        {
            DodajKupon = new RelayCommand(dodaj);
            OdbaciKupon = new RelayCommand(odbaci);
        }

        public void dodaj(object parametar)
        {
            /*Kupon k = new Kupon(DodavanjeKupona.id,double.Parse(DodavanjeKupona.textBoxPopust.text),int.Parse(DodavanjeKupona.numbertextBox));
            MainPage.etfKupon.ListaFirmi.Find(x=> x.Username==MainPage.TrenutnaFirma.Username).ListaKupona.Add(k);
            */
            //CloseAction();
        }
        // Forma za funkciju OdbaciKupon jos nije implementirana
        public void odbaci(object parametar)
        {
            Kupon k = new Kupon();
            EtfKupon.getInstance().dajListuFirmi().Find(x => x.Username == MainPage.TrenutnaFirma.Username).ListaKupona.Remove(k);

            //CloseAction();
        }

    }
}
