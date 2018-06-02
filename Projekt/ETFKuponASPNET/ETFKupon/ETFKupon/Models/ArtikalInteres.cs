using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ETFKupon.Models
{
    public class ArtikalInteres
    {
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string id { get; set; }
        [Required(ErrorMessage = "Id artikla je neophodan!")]
        public string idArtikla { get; set; }
        [Required(ErrorMessage = "Id interesa je neophodan!")]
        public string idInteresa { get; set; }
    }
}