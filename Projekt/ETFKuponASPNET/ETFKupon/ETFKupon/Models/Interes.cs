using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ETFKupon.Models
{
    public class Interes
    {
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string id { get; set; }

        [Required(ErrorMessage = "Naziv je neophodan!")]
        public string Naziv { get; set; }

        //veze

        //public virtual InteresKupca InteresKupca { get; set; }
    }
}