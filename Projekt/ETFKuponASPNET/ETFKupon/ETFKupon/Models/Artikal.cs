using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ETFKupon.Models
{
    public class Artikal
    {
        [ScaffoldColumn(false)]
        public string id { get; set; }
        [Required(ErrorMessage = "Naziv je neophodan!")]
        public string Naziv { get; set; }
        [Required(ErrorMessage = "Kolicina je neophodna!")]
        [Range(1, 10000, ErrorMessage = "Kolicina mora biti između 1 i 10000!")]
        public double Kolicina { get; set; }
        [Required(ErrorMessage = "Cijena je neophodna")]
        public double Cijena { get; set; }
        public string idKupon { get; set; }
        public string idFirma { get; set; }

        // veze
        //public virtual ICollection<FirmaBaza> FirmaArtikal { get; set; }
        //public virtual ICollection<Kupon> KuponArtikal { get; set; }
        //public virtual Korpa Korpa { get; set; }
    }
}