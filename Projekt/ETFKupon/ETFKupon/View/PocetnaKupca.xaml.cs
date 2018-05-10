using ETFKupon.ModelView;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ETFKupon.Interface
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PocetnaKupca : Page
    {
        private InteresModelView interesModelView;
        private KupacPocetnaModelView kupacPocetnaModelView;
        private KorpaModelView korpaModelView;

        public PocetnaKupca()
        {
            this.InitializeComponent();
            DataContext = new KupacPocetnaModelView();
            NavigationCacheMode = NavigationCacheMode.Required;
        }

        public PocetnaKupca(InteresModelView interesModelView)
        {
            this.interesModelView = interesModelView;
        }

        public PocetnaKupca(KupacPocetnaModelView kupacPocetnaModelView)
        {
            this.kupacPocetnaModelView = kupacPocetnaModelView;
        }

        public PocetnaKupca(KorpaModelView korpaModelView)
        {
            this.korpaModelView = korpaModelView;
        }

        private void buttonInterface_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DodavanjeInteresa));
        }

        private void buttonLogout_Click(object sender, RoutedEventArgs e)
        {
            MainPage.TrenutniKupac = null;
            this.Frame.Navigate(typeof(MainPage));
        }

        private void buttonAzuriraj_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AzuriranjeProfila));
        }
        private void buttonPocetnaKupcaKorpa_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(View.Korpa));
        }
        /*private void buttonObrisi_Click(object sender, RoutedEventArgs e)
        {
            
            KupacPocetnaModelView kp = new KupacPocetnaModelView();
            kp.odbaci(MainPage.etfKupon.ListaKupaca.Find(x => x.Username == MainPage.TrenutniKupac.Username));
           
            MainPage.TrenutniKupac = null;
            this.Frame.Navigate(typeof(MainPage));
        }*/
    }
}
