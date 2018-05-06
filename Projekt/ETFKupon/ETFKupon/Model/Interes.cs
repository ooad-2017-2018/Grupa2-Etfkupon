using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETFKupon.Model
{
    public class Interes
    {
        public int IdInteresa { get; set; }
        public string Naziv { get; set; }
        //TODO dodati sliku
        public Interes()
        {

        }
        public Interes(int id, string naziv)
        {
            IdInteresa = id;
            Naziv = naziv;
        }
    }

   
}
