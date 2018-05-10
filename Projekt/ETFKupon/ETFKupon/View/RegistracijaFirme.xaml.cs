using ETFKupon.Model;
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
    public sealed partial class RegistracijaFirme : Page
    {
        public RegistracijaFirme()
        {
            this.InitializeComponent();
        }

        private void ButtonRegistracijaF_Click(object sender, RoutedEventArgs e)
        {
            Firma kupac = new Firma();
            kupac.Naziv = TextBoxNazivFirme.Text;
            kupac.Username = TextBoxUsernameF.Text;
            kupac.Password = PasswordBox1.Password;
            kupac.Email = TextBoxEmailF.Text;
            FirmaModelView k = new FirmaModelView();
            k.dodaj(kupac);
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}
