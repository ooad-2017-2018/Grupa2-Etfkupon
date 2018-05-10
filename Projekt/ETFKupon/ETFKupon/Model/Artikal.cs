using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace ETFKupon.Model
{
    public class Artikal: INotifyPropertyChanged
    {
        public static int id = -1;
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
            id++;
        }

        public Artikal(string ime, int kolicina, double cijena, BitmapImage slika, Interes interes, Kupon kupon)
        {
            Naziv = ime;
            Kolicina = kolicina;
            Cijena = cijena;
            Grupa = interes;
            Slika = slika;
            Popust = kupon;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
