using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETFKupon.Model
{

    internal class PodsistemFirme
    {
        public List<Firma> Lista { get; set; }
        public PodsistemFirme()
        {
            Lista = new List<Firma>();
        }
    }
    internal class PodsistemKupci
    {
        public List<Kupac> Lista { get; set; }
        public PodsistemKupci()
        {
            Lista = new List<Kupac>();
        }

    }
    public sealed class EtfKupon
    {

        private static EtfKupon uniqueInstance = new EtfKupon();
        PodsistemKupci ListaKupaca;
        PodsistemFirme ListaFirmi;

        private EtfKupon()
        {
            ListaKupaca = new PodsistemKupci();
            ListaFirmi = new PodsistemFirme();
        }

        public static EtfKupon getInstance()
        {
            return uniqueInstance;
        }

        public Kupac dajNtogKupca(int index)
        {
            return ListaKupaca.Lista.ElementAt(index);
        }

        public Firma dajNtuFirmu(int index)
        {
            return ListaFirmi.Lista.ElementAt(index);
        }
        public void dodajFirmu(Firma firma)
        {
            ListaFirmi.Lista.Add(firma);
        }
        public void dodajKupca(Kupac kupac)
        {
            ListaKupaca.Lista.Add(kupac);
        }
        public List<Firma> dajListuFirmi()
        {
            return ListaFirmi.Lista;
        }
        public List<Kupac> dajListuKupaca()
        {
            return ListaKupaca.Lista;
        }
        public void izbrisiKupca(Kupac kupac)
        {
            ListaKupaca.Lista.Remove(kupac);
        }
        public void izbrisiFirmu(Firma firma)
        {
            ListaFirmi.Lista.Remove(firma);
        }
    }
}
