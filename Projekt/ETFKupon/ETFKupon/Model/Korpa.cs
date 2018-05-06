using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETFKupon.Model
{
    public class Korpa
    {
        public static int id = -1;
        public List<Artikal> ListaArtikala { get; set; }

        public Korpa()
        {
            id++;
            ListaArtikala = new List<Artikal>();
        }

        public Korpa(List<Artikal> artikli)
        {
            ListaArtikala = artikli;
        }

        public double zaNaplatu()
        {
            double cijena = 0;
            for (int i = 0; i < ListaArtikala.Count; i++)
            {
                cijena += ListaArtikala.ElementAt(i).Cijena;
            }
            return cijena;
        }
    }
}
