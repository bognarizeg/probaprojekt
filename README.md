# probaprojekt
Itt próbálgatom a programozást


## Alapvetések
Az alapvetések célja, hogy egyértelmű alapokat biztosítson eldönteni, hogy hol állunk, merre megyünk, mit célzunk és mint nem a munkánkkal.

- Olyan technológiát használunk, ami jelenleg programozóként a profik használnak és még jó darabig fejlődőképes marad (dotnet core).
- Olyan eszközöket használunk, amit a profi programozók is használnak.
- Olyan feladatot választunk, amit nem kell terveznünk, már létezik és körbejárható
- A tervet úgy készítjük el, hogy később továbbfejleszthető legyen

## Vázlat
Vázlatunk célja megnevezni az egymásra épülő alkalmazásainkat és megrajzolni az összefüggéseket.

- elsődleges cél: egy webalkalmazás készítése (MVC)
- továbbfejlesztés: az adatok szolgáltatása és az üzleti logika elérése webapin keresztül (MVC)
- továbbfejlesztés: desktop alkalmazás készítése a webapira alapozva (WPF)
- mobil alkalmazás készítése a webapira alapozva (Xamarin)
- továbbfejlesztés: SPA: Single Page Application készítése a webapira alapozva (Blazor)

## Webalkalmazás
Készítsünk egy (továbbfejleszthető) oktató alkalmazást, ahova
 - oktatót tudnak tanfolyamokat feltölteni, valamint
 - hallgatók tudnak ilyen tanfolyamokat elvégezni

Ez egy jól áttekinthető, mégis kellően összetett feladat, ahol a full-stack C# fejlesztés minden részébe belepillanthatunk, immár a profi fejlesztő szemével.

Ha az EF modell mellett kiemeljük a szervezési feladatokat (legyen mondjuk *üzleti logika* a neve, az olyan szakzsargon-pozitív, vagy **Service**), akkor már van olyan pont, ahol az API be tud kapcsolódni és lehetőség szerint nem produkál majd a megvalósításnál már eleve tervezett módon kilóméternyi kódokat.

## Objektumorientált terverzési gondolatok (OOD)
- **Csatolás *(Coupling)*:** ha egy elem függ más elemektől, akkor ezek az elemek csatolásban vannak.
- **gyenge *(Low)*** ez a csatikés abban az esetben, ha a csatolásban lévő elemek esetén egy változás továbbterjedése megállítható.

Első célunk tehát: a **gyenge csatolás (*Low Coupling*)** elérése a dobozaink között.

- **Kohézió *(Cohesion)*:** Egy elem felelősségeinek egymáshoz való kapcsolata.
- a kohézió **gyenge (*Low*)**, ha az adott elemnek túl sok egymástól független felelőssége van.
- a kohézió **erős (high)**, ha az adott elem felelősségei erősen összefüggnek és nagyon koncentráltak.

Célunk tehát az **Erős kohézió *(High Chesion)*** elérése a dobozokon belül.

- Költségek
  - Függ a rendelkezésre álló erőforrások méretétől
  - Függ a rendelkezésre álló időtől is.
  - És leginkább az alkalmazás élettartalmától függ.


## Feladatok, felelősségi körök

### DB
- legyen [ef core támogatása]
(https://docs.microsoft.com/en-us/ef/core/providers/)
  - adatbázis tervezés és telepítés
- [docker container](https://hub.docker.com) támogatás
- kedetben sqlight, majd kibővítjük ms sql-re

- Kockázatok
  - teljesítmény
  - relációs adatbázisok

További gondolatok: [műszaki adósság]
(https://netacademia.blog.hu/2016/06/21/a_muszaki_adossag_fogalma)



### Repository
- CRUD műveletek elvégzése (**C**reate, **R**ead, **U**pdate, **D**elete)
- Listázás (Szűrés, sorbarendezés és lapozás)
- offline adatokat szolgáltat
  Sosem ad vissza IQueryable példányt
- adatmodell-eket szolgáltat
  külön kimeneti modell osztályokat nem fog használni
- LINQ-t csak itt használunk

- Kockázatok

### Service
- transzformáció az adatmodell és a viewmodell között (Data mapping)
- Validálás a ViewModel képességeit meghaladó esetben.
- Minden, amit eddig nem említettünk

- Kockázatok

### Web UI

- http kérés fogadása és válasz küldése
  MVC keretrendszer
- felhasználó azonosítás (authentikation)
  ASP.NET Core Identity
- jogosultságkezelés (authorization)
  ASP.NET Core Identity
- bejövő adatok validálása
  MVC ViewModel

- Kockázatok
  - több alkalmazáson át elosztott bejelentkezés és jogosultságkezelés
    Identity Server

## Továbbiak
- docker containeres fejlesztési környezet
- visual studio code

## Kódstruktúra

Projektek:

- l2l.Data
  - l2l.Data
  - l2l.Repository
- l2l.WebUI
  - l2l.Service
  - l2l.WebUI







