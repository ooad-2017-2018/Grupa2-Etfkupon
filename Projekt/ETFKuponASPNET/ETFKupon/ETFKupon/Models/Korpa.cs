using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ETFKupon.Models
{
    public class Korpa
    {
        [ScaffoldColumn(false)]
        public string id { get; set; }
        [Required(ErrorMessage = "Id Kupca je neophodan!")]
        public string idKupac { get; set; }
        [Required(ErrorMessage = "Id artikla je neophodan!")]
        public string idArtikal { get; set; }

        // veze
        //public virtual ICollection<KupacBaza> KupacKorpa { get; set; }
        
        //public virtual ICollection<Artikal> ArtikalKorpa { get; set; }
    }
}