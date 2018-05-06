# Grupa2-Etfkupon


![Alt text](LogoEKupovina.jpg?raw=true)

1. Adnan Br�anin
2. Na�a Dardagan
3. Armin Bilal

## Opis teme 

Na� sistem e-kupovine se zasniva na ideji automatizovanja procesa kupovine. 
Kako nismo uspjeli prona�i odgovaraju�i sistem za e-kupovinu na podru�ju BiH, na�a ideja je da uradimo sistem koji �e to olak�ati na na�in: 
- korisniku �e se ponuditi da izabere njegove interese
- na osnovu tih interesa, korisniku �e se prikazivati odgovaraju�i artikli koji bi ga mogli zanimati
- korisnik mo�e dodavati ili brisati svoje interese
- tako�er �e biti prikaz odre�enih popusta u radnjama koje bi mogle interesovati korisnika sistema

Sistem bi mogao olak�ati kupovinu u smislu da korisnik ne�e morati i�i od radnje do radnje da bi na�ao odgovaraju�i artikal za sebe. 

## Procesi

Korisnik nakon definisanja interesa dobija listu artikala sa nazivom radnje u kojoj se nalazi artikal, cijenom te mogu�nosti kupovine. 
Prikazat �e se koli�ina artikla, veli�ine (ako se radi o odjevnim predmetima)... 
Radnik (firma) �e imati svoj dio u sistemu kako bi mogli dodavati nove artikle te stavljati odgovaraju�e kupone (popuste) na ve� postoje�e. 
Tako�er, firme �e biti u mogu�nosti da provjere stanje artikala kako bi mogli a�urirati.
Administrator �e mo�i sve kontrolisati i on �e biti root user. 

- *Registracija korisnika*:
Korisniku �e biti omogu�eno da se registruje na sistem, unese svoje li�ne podatke, odabere interese te kona�no po�alje zahtjev adminstratoru 
za odobrenje otvaranja ra�una. U svakom trenutku �e se naravno mo�i logovati jer �e se �uvati podaci interno. Tako�er ako se korisniku ne�to 
na profilu ne svi�a, profil mo�e urediti ali isto tako i poslati zahtjev za zatvaranje profila ako �eli da prestane koristiti sistem. 
- *Registracija firme*:
Firma �e tako�er poslati zahtjev za kreiranje ra�una, te �e nakon �to firma otvori account, imati mogu�nost pregleda ra�una �to uklju�uje: 
a�uriranje ponuda, podatke o ponudama te trenutnu statistiku prodavanja. U a�uriranju se podrazumijevaju opcije poput izmjena trenutne ponude, 
brisanje ponude te stvaranje nove ponude. 

Sami procesi registracije korisnika, firme kao i proces kupovine se mo�e prona�i u folderu root/UseCaseIScenarij

## Funkcionalnosti
- registracija te dodavanje interesa za korisnike
- registracija za firme te dodavanje artikala i popusta
- pregled profila (i za korisnika i za firmu) te editovanje profila
- dodavanje novih artikala (firme)
- kupovina artikala (korisnici)
- popunjavanje ankete na kraju svakog mjeseca (korisnici) kako bi firme mogle vidjeti gdje korisnici �ele vidjeti neko sni�enje

## Akteri
- *korisnik* - klasi�ni kupac, korisnik sistema kojeg zanima e-kupovina
- *radnik/firma* - onaj koji daje mogu�nost kupovine, a�urira svoje artikle te popuste 
- *admin* - onaj koji reguli�e rad sistema te ima mogu�nosti koje ima i korisnik i radnik

## Dokumentacija za validaciju (Error codes)
- *0* - OK
- *1* - Prekratka dužina
- *2* - Preduga dužina
- *3* - Passwordi se ne poklapaju
- *4* - Email već postoji 
- *5* - Polje ne može biti prazno
- *6* - Brojčana vrijednost je manja od očekivane
- *7* - Brojčana vrijednost je veća od očekivane 