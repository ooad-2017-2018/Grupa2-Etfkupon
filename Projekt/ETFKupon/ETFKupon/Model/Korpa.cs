using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETFKupon.Model
{
    public class Korpa
    {
        public string id { get; set; }
        public List<Artikal> ListaArtikala { get; set; }

        public Korpa()
        {
            ListaArtikala = new List<Artikal>();
        }

        public Korpa(string _id, List<Artikal> artikli)
        {
            id = _id;
            ListaArtikala = artikli;
        }

        public double zaNaplatu()
        {
            double cijena = 0;
            for (int i = 0; i < ListaArtikala.Count; i++)
            {
                List<Artikal> tmp = ListaArtikala.FindAll(x => x.id == ListaArtikala.ElementAt(i).id);
                for (int j = 0; j < tmp.Count; j++)
                    cijena += tmp.ElementAt(i).Cijena;
            }
            return cijena;
        }
    }
}
