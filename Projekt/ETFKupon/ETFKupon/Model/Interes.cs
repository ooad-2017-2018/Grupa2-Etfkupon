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
        public static int id = -1;
        public string Naziv { get; set; }

        public Interes()
        {
            id++;
        }

        public Interes(string naziv)
        {
            Naziv = naziv;
        }
    }

   
}
