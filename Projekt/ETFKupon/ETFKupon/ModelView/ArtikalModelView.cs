﻿using ETFKupon.Model;
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
            Artikal pomocniArtikal = new Artikal();
            EtfKupon.getInstance().dajListuFirmi().Find(x=> x.Username==MainPage.TrenutnaFirma.Username).ListaArtikala.Add(pomocniArtikal);

            //CloseAction();
        }
        public void odbaci(object parametar)
        {
            Artikal pomocniArtikal = new Artikal();
            EtfKupon.getInstance().dajListuFirmi().Find(x => x.Username == MainPage.TrenutnaFirma.Username).ListaArtikala.Remove(pomocniArtikal);

            //CloseAction();
        }
    }
}
