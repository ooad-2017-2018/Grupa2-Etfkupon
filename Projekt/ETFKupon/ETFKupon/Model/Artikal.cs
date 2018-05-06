using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETFKupon.Model
{
    public class Artikal
    {
        public int IdArtikla { get; set; }
        public string Naziv { get; set; }
        public int Kolicina { get; set; }
        public double Cijena { get; set; }
        private Kupon popust;
        private Interes grupa;
        //TODO dodati sliku
        public Interes Grupa { get => grupa; set => grupa = value; }
        public Kupon Popust { get => popust; set => popust = value; }

        public Artikal()
        {

        }

        public Artikal(int id, string ime, int kolicina, double cijena, Interes interes, Kupon kupon)
        {
            IdArtikla = id;
            Naziv = ime;
            Kolicina = kolicina;
            Cijena = cijena;
            Grupa = interes;
            Popust = kupon;
        }
    }
}
