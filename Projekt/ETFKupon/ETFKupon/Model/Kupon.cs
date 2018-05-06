using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETFKupon.Model
{
    public class Kupon
    {
        public static int id = -1;
        public double Postotak { get; set; }
        public int Kolicina { get; set; }

        public Kupon()
        {
            id++;   
        }

        public Kupon(double postotak, int kolicina)
        {
            Kolicina = kolicina;
            Postotak = postotak;
        }
    }
}
