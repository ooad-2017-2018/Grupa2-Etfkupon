using ETFKupon.Model;
using ETFKupon.ModelView;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
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
    public sealed partial class RegistracijaKupca : Page
    {
        public RegistracijaKupca()
        {
            this.InitializeComponent();
        }

        private void textBoxIme_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void buttonRegistracijaK_Click(object sender, RoutedEventArgs e)
        {
            Kupac kupac = new Kupac();
            kupac.Ime = textBoxIme.Text;
            kupac.Prezime = textBoxPrezime.Text;
            kupac.Username = textBoxUsernameK.Text;
            kupac.Password = textBoxPasswordK.Text;
            kupac.Adresa = textBoxAdresa.Text;
            kupac.BrojKartice = textBoxBrKartice.Text;
            kupac.Email = textBoxEmail.Text;
            kupac.Slika = null;
            KupacModelView k = new KupacModelView();
            k.dodaj(kupac);
            textBoxIme.Text = " ";
            //textBoxIme.Text = MainPage.etfKupon.ListaKupaca.Count.ToString();
            //MessageDialog msg = new MessageDialog(MainPage.etfKupon.ListaKupaca.Count.ToString());
            this.Frame.Navigate(typeof(PocetnaKupca));
        }
    }
}
