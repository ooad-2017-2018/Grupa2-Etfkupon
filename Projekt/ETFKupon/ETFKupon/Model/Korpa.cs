using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETFKupon.Model
{
    public class Korpa
    {
        public int IdKorpe { get; set; }
        public List<Artikal> ListaArtikala { get; set; }

        public Korpa()
        {
            ListaArtikala = new List<Artikal>();
        }

        public Korpa(int id, List<Artikal> artikli)
        {
            IdKorpe = id;
            ListaArtikala = artikli;
        }

        public double zaNaplatu()
        {
            double cijena = 0;
            for (int i = 0; i < ListaArtikala.Count; i++)
            {
                List<Artikal> tmp = ListaArtikala.FindAll(x => x.IdArtikla == ListaArtikala.ElementAt(i).IdArtikla);
                for (int j = 0; j < tmp.Count; j++)
                    cijena += tmp.ElementAt(i).Cijena;
            }
            return cijena;
        }
    }
}
