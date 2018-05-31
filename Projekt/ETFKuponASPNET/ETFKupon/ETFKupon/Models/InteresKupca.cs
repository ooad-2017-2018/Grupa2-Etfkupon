using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ETFKupon.Models
{
    public class InteresKupca
    {
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string id { get; set; }
        [Required(ErrorMessage = "Id kupca je neophodan!")]
        public string idKupac { get; set; }
        [Required(ErrorMessage = "Id interesa je neophodan!")]
        public string idInteres { get; set; }

        // veze
        //public virtual ICollection<KupacBaza> KupacInteresKupca { get; set; }
        //public virtual ICollection<Interes> InteresInteresKupca{ get; set; }
    }
}