using System;
using ETFKupon.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETFKupon
{
    public class obavijest:Iobserver
    {
        Firma firma;
        string imeKupca;
        public obavijest(Firma _firma, string kupac)
        {
            firma = _firma;
            imeKupca=kupac;
            firma.Notify += Update;
        }
        public void Update(string poruka)
        {
            Console.WriteLine("Kupljen Vam je artikal " + poruka+" od korisnika "+imeKupca+" .");
        }
    }
}
