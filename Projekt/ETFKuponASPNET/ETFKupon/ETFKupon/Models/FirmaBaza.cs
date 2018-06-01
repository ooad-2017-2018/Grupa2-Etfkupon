using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ETFKupon.Models
{
    public class FirmaBaza
    {
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string id { get; set; }
        [Required(ErrorMessage = "Naziv je neophodan!")]
        public string Naziv { get; set; }
        [Required(ErrorMessage = "Username je neophodan!")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password je neophodan!")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Email je neophodan!")]
        [EmailAddress(ErrorMessage = "Nevaljana Email adresa!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Stanje racuna je neophodno!")]
        [Range(1, 10000, ErrorMessage = "Stanje racuna mora biti između 1 i 10000!")]
        public double StanjeRacuna { get; set; }

        //veze
        //public virtual Kupon Kupon { get; set; }
        //public virtual Artikal Artikal { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}