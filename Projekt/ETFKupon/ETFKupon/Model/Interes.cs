using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace ETFKupon.Model
{
    public class Interes: INotifyPropertyChanged
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
