# Grupa2-Etfkupon


![Alt text](LogoEKupovina.jpg?raw=true)

1. Adnan Brðanin
2. Naða Dardagan
3. Armin Bilal

## Opis teme 

Naš sistem e-kupovine se zasniva na ideji automatizovanja procesa kupovine. 
Kako nismo uspjeli pronaæi odgovarajuæi sistem za e-kupovinu na podruèju BiH, naša ideja je da uradimo sistem koji æe to olakšati na naèin: 
- korisniku æe se ponuditi da izabere njegove interese
- na osnovu tih interesa, korisniku æe se prikazivati odgovarajuæi artikli koji bi ga mogli zanimati
- korisnik može dodavati ili brisati svoje interese
- takoðer æe biti prikaz odreðenih popusta u radnjama koje bi mogle interesovati korisnika sistema

Sistem bi mogao olakšati kupovinu u smislu da korisnik neæe morati iæi od radnje do radnje da bi našao odgovarajuæi artikal za sebe. 

## Procesi

Korisnik nakon definisanja interesa dobija listu artikala sa nazivom radnje u kojoj se nalazi artikal, cijenom te moguænosti kupovine. 
Prikazat æe se kolièina artikla, velièine (ako se radi o odjevnim predmetima)... 
Radnik (firma) æe imati svoj dio u sistemu kako bi mogli dodavati nove artikle te stavljati odgovarajuæe kupone (popuste) na veæ postojeæe. 
Takoðer, firme æe biti u moguænosti da provjere stanje artikala kako bi mogli ažurirati.
Administrator æe moæi sve kontrolisati i on æe biti root user. 

- Registracija korisnika
Korisniku æe biti omoguæeno da se registruje na sistem, unese svoje liène podatke, odabere interese te konaèno pošalje zahtjev adminstratoru 
za odobrenje otvaranja raèuna. U svakom trenutku æe se naravno moæi logovati jer æe se èuvati podaci interno. Takoðer ako se korisniku nešto 
na profilu ne sviða, profil može urediti ali isto tako i poslati zahtjev za zatvaranje profila ako želi da prestane koristiti sistem. 
- Registracija firme
Firma æe takoðer poslati zahtjev za kreiranje raèuna, te æe nakon što firma otvori account, imati moguænost pregleda raèuna što ukljuèuje: 
ažuriranje ponuda, podatke o ponudama te trenutnu statistiku prodavanja. U ažuriranju se podrazumijevaju opcije poput izmjena trenutne ponude, 
brisanje ponude te stvaranje nove ponude. 

Sami procesi registracije korisnika, firme kao i proces kupovine se može pronaæi u folderu root/UseCaseIScenarij

## Funkcionalnosti
- registracija te dodavanje interesa za korisnike
- registracija za firme te dodavanje artikala i popusta
- pregled profila (i za korisnika i za firmu) te editovanje profila
- dodavanje novih artikala (firme)
- kupovina artikala (korisnici)
- popunjavanje ankete na kraju svakog mjeseca (korisnici) kako bi firme mogle vidjeti gdje korisnici žele vidjeti neko sniženje

## Akteri
- *korisnik* - klasièni kupac, korisnik sistema kojeg zanima e-kupovina
- *radnik/firma* - onaj koji daje moguænost kupovine, ažurira svoje artikle te popuste 
- *admin* - onaj koji reguliše rad sistema te ima moguænosti koje ima i korisnik i radnik

