using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETFKupon.Model
{
    public class Kupon
    {
        public string id { get; set; }
        public double Postotak { get; set; }
        public int Kolicina { get; set; }

        public Kupon()
        {
                
        }

        public Kupon(string _id, double postotak, int kolicina)
        {
            id = _id;
            Kolicina = kolicina;
            Postotak = postotak;
        }
    }
}
