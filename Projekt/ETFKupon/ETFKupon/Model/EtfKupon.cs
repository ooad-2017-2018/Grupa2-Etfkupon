using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETFKupon.Model
{
    public class EtfKupon
    {
        public List<Kupac> ListaKupaca { get; set; }
        public List<Firma> ListaFirmi { get; set; }

        public EtfKupon()
        {
            ListaKupaca = new List<Kupac>();
            ListaFirmi = new List<Firma>();
        }

        public Kupac dajNtogKupca(int index)
        {
            return ListaKupaca.ElementAt(index);
        }

        public Firma dajNtuFirmu(int index)
        {
            return ListaFirmi.ElementAt(index);
        }
    }
}
