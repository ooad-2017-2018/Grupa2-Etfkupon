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
        //public static EtfKupon etfKupon=EtfKupon.getInstance();
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
            //dodati popunjavanje listi iz baze
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
            TrenutniKupac = EtfKupon.getInstance().dajListuKupaca().Find(x => x.Username == textBoxUsername.Text);
            if (TrenutniKupac == null)
            {
                TrenutnaFirma = EtfKupon.getInstance().dajListuFirmi().Find(x => x.Username == textBoxUsername.Text);
                if (TrenutnaFirma != null)
                {
                    if (TrenutnaFirma.Password == textBoxPassword.Text)
                        this.Frame.Navigate(typeof(PocetnaFirme));
                }
            }
            else
            {
                if (TrenutniKupac.Password == textBoxPassword.Text)
                this.Frame.Navigate(typeof(PocetnaKupca));
            }
        }
    }
}
