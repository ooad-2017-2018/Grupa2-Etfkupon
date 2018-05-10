using ETFKupon.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using ETFKupon.Model;
using ETFKupon.ModelView;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ETFKupon
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public static EtfKupon etfKupon = new EtfKupon();
        private KupacModelView kupacModelView;
        private FirmaModelView firmaModelView;

        public static Kupac TrenutniKupac { get; set; }
        public static Firma TrenutnaFirma { get; set; }
        public MainPage()
        {
            this.InitializeComponent();
            //etfKupon = new EtfKupon();
            TrenutnaFirma = null;
            TrenutniKupac = null;
        }

        public MainPage(KupacModelView kupacModelView)
        {
            this.kupacModelView = kupacModelView;
        }

        public MainPage(KupacPocetnaModelView kupacPocetnaModelView)
        {
        }

        public MainPage(FirmaModelView firmaModelView)
        {
            this.firmaModelView = firmaModelView;
        }

        private void buttonRegistracijaKupca_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(RegistracijaKupca));
        }

       private void buttonRegistracijaFirme_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(RegistracijaFirme));
        }

        private void buttonPrijava_Click(object sender, RoutedEventArgs e)
        {
            TrenutniKupac = etfKupon.ListaKupaca.Find(x => x.Username == textBoxUsername.Text);
            if (TrenutniKupac == null)
            {
                TrenutnaFirma = etfKupon.ListaFirmi.Find(x => x.Username == textBoxUsername.Text);
                if (TrenutnaFirma != null)
                    this.Frame.Navigate(typeof(PocetnaFirme));
            } else this.Frame.Navigate(typeof(PocetnaKupca));
        }
    }
}
