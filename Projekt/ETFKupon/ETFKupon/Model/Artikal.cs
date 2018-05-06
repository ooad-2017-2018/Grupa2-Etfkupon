using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace ETFKupon.Model
{
    public class Artikal
    {
        public string id { get; set; }
        public string Naziv { get; set; }
        public int Kolicina { get; set; }
        public double Cijena { get; set; }

        private Kupon popust;
        private Interes grupa;
        public BitmapImage Slika { get; set; }

        public Interes Grupa { get => grupa; set => grupa = value; }
        public Kupon Popust { get => popust; set => popust = value; }

        public Artikal()
        {

        }

        public Artikal(string _id, string ime, int kolicina, double cijena, BitmapImage slika, Interes interes, Kupon kupon)
        {
            id = _id;
            Naziv = ime;
            Kolicina = kolicina;
            Cijena = cijena;
            Grupa = interes;
            Slika = slika;
            Popust = kupon;
        }
    }
}
