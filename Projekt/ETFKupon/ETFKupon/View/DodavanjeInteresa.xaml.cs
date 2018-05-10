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
    public sealed partial class DodavanjeInteresa : Page
    {
        public DodavanjeInteresa()
        {
            this.InitializeComponent();
            DataContext = new InteresModelView();
        }

        private void buttonPocetnaKupcaInteresi_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PocetnaKupca));
        }

        /*private void buttonDodajInterese_Click(object sender, RoutedEventArgs e)
        {
            Interes interes = new Interes();
            interes.Naziv = comboBoxInteresi.SelectedValue.ToString();
            InteresModelView i = new InteresModelView();
            i.dodaj(interes);
        }*/
    }
}
