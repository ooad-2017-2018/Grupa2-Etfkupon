# Grupa2-Etfkupon


![Alt text](LogoEKupovina.jpg?raw=true)

1. Adnan Brđanin
2. Nađa Dardagan
3. Armin Bilal

## Opis teme 

Naš sistem e-kupovine se zasniva na ideji automatizovanja procesa kupovine. 
Kako nismo uspjeli pronaći odgovarajući sistem za e-kupovinu na području BiH, naša ideja je da uradimo sistem koji će to olakšati na način: 
- korisniku će se ponuditi da izabere njegove interese
- na osnovu tih interesa, korisniku će se prikazivati odgovarajući artikli koji bi ga mogli zanimati
- korisnik može dodavati ili brisati svoje interese
- također će biti prikaz određenih popusta u radnjama koje bi mogle interesovati korisnika sistema

Sistem bi mogao olakšati kupovinu u smislu da korisnik neće morati ići od radnje do radnje da bi našao odgovarajući artikal za sebe. 

## Procesi

Korisnik nakon definisanja interesa dobija listu artikala sa nazivom radnje u kojoj se nalazi artikal, cijenom te mogućnosti kupovine. 
Prikazat će se količina artikla, veličine (ako se radi o odjevnim predmetima)... 
Radnik (firma) će imati svoj dio u sistemu kako bi mogli dodavati nove artikle te stavljati odgovarajuće kupone (popuste) na već postojeće. 
Također, firme će biti u mogućnosti da provjere stanje artikala kako bi mogli ažurirati.
Administrator će moći sve kontrolisati i on će biti root user. 

- *Registracija korisnika*:
Korisniku će biti omogućeno da se registruje na sistem, unese svoje lične podatke, odabere interese te konačno pošalje zahtjev adminstratoru 
za odobrenje otvaranja računa. U svakom trenutku će se naravno moći logovati jer će se čuvati podaci interno. Također ako se korisniku nešto 
na profilu ne sviđa, profil može urediti ali isto tako i poslati zahtjev za zatvaranje profila ako želi da prestane koristiti sistem. 
- *Registracija firme*:
Firma će također poslati zahtjev za kreiranje računa, te će nakon što firma otvori account, imati mogućnost pregleda računa što uključuje: 
ažuriranje ponuda, podatke o ponudama te trenutnu statistiku prodavanja. U ažuriranju se podrazumijevaju opcije poput izmjena trenutne ponude, 
brisanje ponude te stvaranje nove ponude. 

Sami procesi registracije korisnika, firme kao i proces kupovine se može pronaći u folderu root/UseCaseIScenarij

## Funkcionalnosti
- registracija te dodavanje interesa za korisnike
- registracija za firme te dodavanje artikala i popusta
- pregled profila (i za korisnika i za firmu) te editovanje profila
- dodavanje novih artikala (firme)
- kupovina artikala (korisnici)
- popunjavanje ankete na kraju svakog mjeseca (korisnici) kako bi firme mogle vidjeti gdje korisnici žele vidjeti neko sniženje

## Akteri
- *korisnik* - klasični kupac, korisnik sistema kojeg zanima e-kupovina
- *radnik/firma* - onaj koji daje mogućnost kupovine, ažurira svoje artikle te popuste 
- *admin* - onaj koji reguliše rad sistema te ima mogućnosti koje ima i korisnik i radnik

## Dokumentacija za validaciju (Error codes)
- *0* - OK
- *1* - Prekratka dužina
- *2* - Preduga dužina
- *3* - Passwordi se ne poklapaju
- *4* - Email već postoji 
- *5* - Polje ne može biti prazno
- *6* - Brojčana vrijednost je manja od očekivane
- *7* - Brojčana vrijednost je veća od očekivane 

## Deploy
Našu aplikaciju možete isprobati na linku: http://etfkupon.azurewebsites.net/

## Rute Web Aplikacije

- *get all*: /KupacBaza
- *get by id*: /KupacBaza/Details/:id
- *get*: KupacBaza/Create
- *post*: KupacBaza/Create
- *get*: KupacBaza/Edit/:id
- *post*: KupacBaza/Edit/:id
- *get*: KupacBaza/Delete/:id
- *post*: KupacBaza/Delete/:id

- *get all*: /FirmaBaza
- *get by id*: /FirmaBaza/Details/:id
- *get*: FirmaBaza/Create
- *post*: FirmaBaza/Create
- *get*: FirmaBaza/Edit/:id
- *post*: FirmaBaza/Edit/:id
- *get*: FirmaBaza/Delete/:id
- *post*: FirmaBaza/Delete/:id