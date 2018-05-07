using ETFKupon.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ETFKupon.ModelView
{
    public class ArtikalModelView
    {
        public ICommand DodajArtikal { get; set; }
        public ICommand OdbaciArtikal { get; set; }
        public ArtikalModelView()
        {
            DodajArtikal = new RelayCommand(dodaj);
            OdbaciArtikal = new RelayCommand(odbaci);
        }

        public void dodaj(object parametar)
        {
            Artikal k = new Artikal();
            MainPage.etfKupon.ListaFirmi.Find(x=> x.Username==MainPage.TrenutnaFirma.Username).ListaArtikala.Add(k);

            //CloseAction();
        }
        public void odbaci(object parametar)
        {
            Artikal k = new Artikal();
            MainPage.etfKupon.ListaFirmi.Find(x => x.Username == MainPage.TrenutnaFirma.Username).ListaArtikala.Remove(k);

            //CloseAction();
        }
    }
}
