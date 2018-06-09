using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETFKupon
{
    public class Validacija
    {
        private Tuple<int, string> OK = new Tuple<int, string>(0, "Validno"), nePoklapanjePass= new Tuple<int, string>(3, "Passwordi se ne poklapaju!"),velikiPostotak=new Tuple<int, string>(7, "Postotak ne moze biti veci od 1!");
        private int kratko = 1, dugo = 2,vecPostoji=4, praznoPolje=5, negativno=6, minDuzina=4, maxDuzina=15, minIme=1;
        public Validacija() { }

        private bool jeLiDuplikat(string varijabla ,string izbor)
        {
            bool postojiKupac = false, postojiFirma = false;
            for (int i = 0; i < MainPage.etfKupon.ListaFirmi.Count; i++)
            {
                if ((MainPage.etfKupon.ListaKupaca.ElementAt(i).Email == varijabla && izbor.Equals("Email")) || (MainPage.etfKupon.ListaKupaca.ElementAt(i).Username == varijabla && izbor.Equals("Username")))
                {
                    postojiFirma = true;
                    break;
                }
            }
            if (postojiFirma == false)
            {
                for (int i = 0; i < MainPage.etfKupon.ListaKupaca.Count; i++)
                {
                    if ((MainPage.etfKupon.ListaKupaca.ElementAt(i).Email == varijabla && izbor.Equals("Email")) || (MainPage.etfKupon.ListaKupaca.ElementAt(i).Username == varijabla && izbor.Equals("Username")))
                    {
                        postojiKupac = true;
                        break;
                    }
                }
            }
            return (postojiFirma || postojiKupac);
        }

        private Tuple<int, string> napraviTuple(int prviParametar, string drugiParametar)
        {
            return new Tuple<int, string>(prviParametar, drugiParametar);
        }
        // validacija za kupce 
        public Tuple<int, string> ValidirajImeKorisnika(string ime)
        {
            if (ime.Length > minIme) return OK;
            else if (ime == string.Empty) return napraviTuple(praznoPolje, "Polje imena ne moze biti prazno!");

            return napraviTuple(kratko, "Ime mora biti duze od 1 znaka!");
        }
        public Tuple<int, string> ValidirajPrezimeKorisnika(string prezime)
        {
            if (prezime.Length > minIme) return OK;
            else if (prezime == string.Empty) return napraviTuple(praznoPolje, "Polje prezimena ne moze biti prazno!");

            return napraviTuple(kratko, "Prezime mora biti duze od 1 znaka!");
        }

        public Tuple<int, string> ValidirajUsernameKorisnika(string username)
        {
            bool postojiUsername = jeLiDuplikat(username, "Username");
            if (username.Length > maxDuzina) return napraviTuple(dugo, "Username mora biti kraci od 15 znakova!");
            else if (username.Length < minDuzina) return napraviTuple(kratko, "Username mora biti duzi od 4 znaka!");
            else if (username == string.Empty) return napraviTuple(praznoPolje, "Polje username ne moze biti prazno!");
            else if (postojiUsername) return napraviTuple(vecPostoji, "Username vec postoji!");

            return OK;
        }
        public Tuple<int, string> ValidirajPasswordKorisnika(string password)
        {
            if (password.Length >= minDuzina && password.Length <= maxDuzina) return OK;
            else if (password == string.Empty) return napraviTuple(praznoPolje, "Polje password ne moze biti prazno!");
            else if (password.Length < minDuzina) return napraviTuple(kratko, "Password mora biti duzi od 4 znaka!");
            

            return napraviTuple(dugo, "Password mora biti kraci od 15 znakova!");
        }
        public Tuple<int, string> ValidirajPasswordPotvrduKorisnika(string password, string potvrda)
        {
            if (String.Equals(password, potvrda)) return OK;

            return nePoklapanjePass;
        }
        public Tuple<int, string> ValidirajEmailKorisnika(string email)
        {
            bool postojiEmail = jeLiDuplikat(email, "Email");
            if (email == string.Empty) return napraviTuple(praznoPolje, "Polje email ne moze biti prazno!");
            else if (postojiEmail) return napraviTuple(vecPostoji, "Email vec postoji!");

            return OK;
        }
        public Tuple<int, string> ValidirajAdresuKorisnika(string adresa)
        {
            if (adresa == string.Empty) return napraviTuple(praznoPolje, "Polje adresa ne moze biti prazno!");

            return OK;
        }
        //dodati validaciju za broj kartice?

        // validacija interesa
        public Tuple<int, string> ValidirajNazivInteresa(string ime)
        {
            if (ime.Length > 1) return OK;
            else if (ime == string.Empty) return napraviTuple(praznoPolje, "Polje imena interesa ne moze biti prazno!");

            return napraviTuple(kratko, "Ime interesa mora biti duze od 1 znaka!");
        }
        
        // validacija artikla
        public Tuple<int, string> ValidirajNazivArtikla(string ime)
        {
            if (ime.Length > 1) return OK;
            else if (ime == string.Empty) return napraviTuple(praznoPolje, "Polje imena artikla ne moze biti prazno!");

            return napraviTuple(kratko, "Ime artikla mora biti duze od 1 znaka!");
        }
        public Tuple<int, string> ValidirajKolicinuArtikla(int kolicina)
        {
            if (kolicina < 0) return napraviTuple(negativno, "Kolicina ne moze biti negativna!");

            return OK;
        }
        public Tuple<int, string> ValidirajCijenuArtikla(double cijena)
        {
            if (cijena < 0) return napraviTuple(negativno, "Cijena ne moze biti negativna!");

            return OK;
        }
        
        // validacija kupona
        public Tuple<int, string> ValidirajPostotakKupona(double postotak)
        {
            if (postotak > 1) return velikiPostotak;
            else if (postotak < 0) return napraviTuple(negativno, "Postotak ne moze biti manji od 0!");

            return OK;
        }
        public Tuple<int, string> ValidirajKolicinuKupona(int kolicina)
        {
            if (kolicina < 0) return napraviTuple(negativno, "Kolicina ne moze biti manja od 0!");

            return OK;
        }

    }
}
