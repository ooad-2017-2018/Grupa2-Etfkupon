using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace ETFKupon.Model
{
    public class Interes
    {
        public int IdInteresa { get; set; }
        public string Naziv { get; set; }
        public BitmapImage Slika { get; set; }
        public Interes()
        {

        }
        public Interes(int id, string naziv, BitmapImage slika)
        {
            IdInteresa = id;
            Naziv = naziv;
            Slika = slika;
        }
    }

   
}
