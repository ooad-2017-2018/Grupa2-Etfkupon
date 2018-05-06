using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETFKupon.Model
{
    public class Kupon
    {
        public int IdKupona { get; set; }
        public double Postotak { get; set; }
        public int Kolicina { get; set; }

        public Kupon()
        {
                
        }

        public Kupon(int id, double postotak, int kolicina)
        {
            IdKupona = id;
            Kolicina = kolicina;
            Postotak = postotak;
        }
    }
}
