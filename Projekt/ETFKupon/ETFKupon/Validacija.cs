using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETFKupon
{
    public class Validacija
    {
        public Validacija() { }
        // validacija za kupce 
        public Tuple<int, string> ValidirajImeKupca(string ime)
        {
            if (ime.Length > 1) return new Tuple<int, string>(0, "Validno");
            else if (ime == string.Empty) return new Tuple<int, string>(5, "Polje imena ne moze biti prazno!");
            else return new Tuple<int, string>(1, "Ime mora biti duze od 1 znaka!");
        }
        public Tuple<int, string> ValidirajPrezimeKupca(string prezime)
        {
            if (prezime.Length > 1) return new Tuple<int, string>(0, "Validno");
            else if (prezime == string.Empty) return new Tuple<int, string>(5, "Polje prezimena ne moze biti prazno!");
            else return new Tuple<int, string>(1, "Prezime mora biti duze od 1 znaka!");
        }
        public Tuple<int, string> ValidirajUsernameKupca(string username)
        {
            bool postoji = false;
            for (int i = 0; i < MainPage.etfKupon.ListaFirmi.Count; i++)
                if (MainPage.etfKupon.ListaFirmi.ElementAt(i).Username == username)
                {
                    postoji = true;
                    break;
                }
            for (int i = 0; i < MainPage.etfKupon.ListaKupaca.Count; i++)
                if (MainPage.etfKupon.ListaKupaca.ElementAt(i).Username == username)
                {
                    postoji = true;
                    break;
                }
            if (username.Length > 15) return new Tuple<int, string>(2, "Username mora biti kraci od 15 znakova!");
            else if (username.Length < 4) return new Tuple<int, string>(1, "Username mora biti duzi od 4 znaka!");
            else if (username == string.Empty) return new Tuple<int, string>(5, "Polje username ne moze biti prazno!");
            else if (postoji) return new Tuple<int, string>(4, "Username vec postoji!");
            else return new Tuple<int, string>(0, "Validno");
        }
        public Tuple<int, string> ValidirajPasswordKupca(string password)
        {
            if (password.Length >= 4 && password.Length <= 15) return new Tuple<int, string>(0, "Validno");
            else if (password.Length < 4) return new Tuple<int, string>(1, "Password mora biti duzi od 4 znaka!");
            else if (password == string.Empty) return new Tuple<int, string>(5, "Polje password ne moze biti prazno!");
            else return new Tuple<int, string>(2, "Password mora biti kraci od 15 znakova!");
        }
        public Tuple<int, string> ValidirajPasswordPotvrduKupca(string password, string potvrda)
        {
            if (String.Equals(password, potvrda)) return new Tuple<int, string>(0, "Validno");
            else return new Tuple<int, string>(3, "Passwordi se ne poklapaju!");
        }
        public Tuple<int, string> ValidirajEmailKupca(string email)
        {
            bool postoji = false;
            for (int i = 0; i < MainPage.etfKupon.ListaFirmi.Count; i++)
                if (MainPage.etfKupon.ListaFirmi.ElementAt(i).Email == email)
                {
                    postoji = true;
                    break;
                }
            for (int i = 0; i < MainPage.etfKupon.ListaKupaca.Count; i++)
                if (MainPage.etfKupon.ListaKupaca.ElementAt(i).Email == email)
                {
                    postoji = true;
                    break;
                }
            if (email == string.Empty) return new Tuple<int, string>(5, "Polje email ne moze biti prazno!");
            else if (postoji) return new Tuple<int, string>(4, "Email vec postoji!");
            else return new Tuple<int, string>(0, "Validno");
        }
        public Tuple<int, string> ValidirajAdresuKupca(string adresa)
        {
            if (adresa == string.Empty) return new Tuple<int, string>(5, "Polje adresa ne moze biti prazno!");
            else return new Tuple<int, string>(0, "Validno");
        }
        //dodati validaciju za broj kartice?



        // validacija firme
        public Tuple<int, string> ValidirajNazivFirme(string naziv)
        {
            return ValidirajImeKupca(naziv);
        }
        public Tuple<int, string> ValidirajUsernameFirme(string username)
        {
            return ValidirajUsernameKupca(username);
        }
        public Tuple<int, string> ValidirajPasswordFirme(string password)
        {
            return ValidirajPasswordKupca(password);
        }
        public Tuple<int, string> ValidirajPasswordPotvrduFirme(string password, string potvrda)
        {
            return ValidirajPasswordPotvrduKupca(password, potvrda);
        }
        public Tuple<int, string> ValidirajEmailFirme(string email)
        {
            bool postoji = false;
            for (int i = 0; i < MainPage.etfKupon.ListaFirmi.Count; i++)
                if (MainPage.etfKupon.ListaFirmi.ElementAt(i).Email == email)
                {
                    postoji = true;
                    break;
                }
            for (int i = 0; i < MainPage.etfKupon.ListaKupaca.Count; i++)
                if (MainPage.etfKupon.ListaKupaca.ElementAt(i).Email == email)
                {
                    postoji = true;
                    break;
                }
            if (email == string.Empty) return new Tuple<int, string>(5, "Polje email ne moze biti prazno!");
            else if (postoji) return new Tuple<int, string>(4, "Email vec postoji!");
            else return new Tuple<int, string>(0, "Validno");
        }


        // validacija interesa
        public Tuple<int, string> ValidirajNazivInteresa(string ime)
        {
            if (ime.Length > 1) return new Tuple<int, string>(0, "Validno");
            else if (ime == string.Empty) return new Tuple<int, string>(5, "Polje imena interesa ne moze biti prazno!");
            else return new Tuple<int, string>(1, "Ime interesa mora biti duze od 1 znaka!");
        }


        // validacija artikla
        public Tuple<int, string> ValidirajNazivArtikla(string ime)
        {
            if (ime.Length > 1) return new Tuple<int, string>(0, "Validno");
            else if (ime == string.Empty) return new Tuple<int, string>(5, "Polje imena artikla ne moze biti prazno!");
            else return new Tuple<int, string>(1, "Ime artikla mora biti duze od 1 znaka!");
        }
        public Tuple<int, string> ValidirajKolicinuArtikla(int kolicina)
        {
            if (kolicina < 0) return new Tuple<int, string>(6, "Kolicina ne moze biti negativna!");
            else return new Tuple<int, string>(0, "Validno");
        }
        public Tuple<int, string> ValidirajCijenuArtikla(double cijena)
        {
            if (cijena < 0) return new Tuple<int, string>(6, "Cijena ne moze biti negativna!");
            else return new Tuple<int, string>(0, "Validno");
        }


        // validacija kupona
        public Tuple<int, string> ValidirajPostotakKupona(double postotak)
        {
            if (postotak > 1) return new Tuple<int, string>(7, "Postotak ne moze biti veci od 1!");
            else if (postotak < 0) return new Tuple<int, string>(6, "Postotak ne moze biti manji od 0!");
            else return new Tuple<int, string>(0, "Validno");
        }
        public Tuple<int, string> ValidirajKolicinuKupona(int kolicina)
        {
            if (kolicina < 0) return new Tuple<int, string>(6, "Kolicina ne moze biti manja od 0!");
            else return new Tuple<int, string>(0, "Validno");
        }

    }
}
