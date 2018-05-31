using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ETFKupon.Models
{
    public class Kupon
    {
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string id { get; set; }
        [Required(ErrorMessage = "Postotak je neophodan!")]
        [Range(1, 100, ErrorMessage = "Postotak mora biti između 1 i 100!")]
        public double Postotak { get; set; }
        [Required(ErrorMessage = "Kolicina je neophodna!")]
        [Range(1, 10000, ErrorMessage = "Kolicina mora biti između 1 i 10000!")]
        public double Kolicina { get; set; }
        [Required(ErrorMessage = "Id firme je neophodan!")]
        public string idFirma { get; set; }

        // veze
        //public virtual ICollection<FirmaBaza> FirmaKupon { get; set; }

    }
}