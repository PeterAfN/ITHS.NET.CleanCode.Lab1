# ITHS.NET.CleanCode.Lab1
 
Denna lab ingick i kursen "Clean Code och testbar kod  30p" på IT-Högskolan i Göteborg som jag läste hösten/vintern år 2021.

# Uppgiftsbeskrivningen för lab 1:

## Laboration 1
Denna laboration kommer att täcka grundläggande enhetstestning inklusive mockning.
Laborationen är uppdelad i två delar och är tänkt att lösas i par. Det går naturligtvis att lösa
laborationen själv också. För att redovisa laborationen skall bägge deluppgifterna vara lösta.
Redovisning sker antingen i klassrummet, via Teams eller via GitHub i önskad ordning. Vill ni redovisa
via Teams så hör av er till Dan så bestämmer vi en tid. Redovisas labben via GitHub så skicka Dan en
länk till repot, samt ha en README där det framgår vem/vilka som har gjort labben. Kommentarer om
er lösning är också välkommet.
Laboration 1a: FizzBuzz
FizzBuzz är en lek som används för att få barn att lära sig division, samt att ibland kodtesta juniora
utvecklare.
Det går ut på att räkna en sekvens ett, två, tre, osv där siffror byts ut mot nummer enligt följande
regler:
- Är talet delbart med tre ska man istället för siffran säga Fizz
- Är talet delbart med fem ska man istället för siffran säga Buzz
- Är talet delbart med femton ska man istället för siffran säga FizzBuzz
En “FizzBuzzad” sekvens ser alltså ut som följande: 1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14,
FizzBuzz, 16...
Mer detaljer för den intresserade kan man hitta här: https://en.wikipedia.org/wiki/Fizz_buzz

#### Uppgiften
Skriv passande klass:
- Sekvensen som ska genereras ska starta på ett och sluta på 100.
- Klassen som implementerar FizzBuzzen ska returnera en lista av strängar enligt ovan.
- Frivillig uppgift är att göra att klassens metod kan ta emot en parameter som anger vilket
slutnummer som sekvensen ska ha.
Enhetstesta er klass:
- Täck de eventuella fall som kan uppstå. Vi behöver inte testa ALLA möjliga fall. Det räcker med
Fizz, Buzz, Fizzbuzz och ett nummer. Tänk execution paths och täck de fallen.
- Implementerar ni en parametriserad metod så blir det lite extra test och felhantering. Vad
händer om vi skickar in ett negativt tal? Noll? Returnerar vi samma antal strängar som
parametervärdet?

## Laboration 1b: Mockning
I denna laboration ska vi pröva på att mocka bort ett externt beroende och ersätta det med en mock
som ger oss ett känt resultat så vi kan bygga isolerade enhetstester.

#### Uppgiften
Vi ska skriva och enhetstesta en eller flera klasser som löser följande uppgift:
- En sträng ska läsas in från en textfil med namnet “indata.txt”
o Är filen tom eller inte finnas så skall passande undantag kastas
o Hanteringen för om filen innehåller fler än en rad är valfri. Vi kan ignorera det eller
kasta ett undantag
- Den inlästa strängen ska vändas
o “Dan” => “naD”
o “ITHS” => “SHTI”
Tänk på att skriva kod som kommer att vara förvaltningsbar.
- Tydliga variabelnamn
- Kommentarer om det behövs. Kommentera inte för kommenterandets skull.
- Lägg en <<summary>> om ni vill på eventuella klasser, metoder eller properties.
- Strukturera koden på ett bra sätt.
- Testprojektet bör spegla den testade kodens struktur.
- Ge testmetoderna passande namn enligt strukturen
MetodSomTestas_VadSkickarViInEllerGör_VadFörväntarViOss.
Gör vad ni kan för att göra det enkelt för en utomstående att snabbt förstå vad er kod gör!
För att enhetstesta ett externt beroende, i detta fall filinläsningen, ska den logiken/klassen
abstraheras bort och gömmas bakom ett interface. Tänk er scenariot att vi kanske vill ha flera klasser
som implementerar interfacet; en för att läsa från databas, en för att läsa från ett API, en för att
returnera en slumpmässig sträng.
Det interfaces ska sedan mockas. Det gör vi på stället
För att till fullo kunna utnyttja interfaces så ska interfacet användas så att vi instansierar objektet med
interfacet som typ. Vi ska inte använda den implementerande klassen. Se bild nedan:
Detta gör att vi mycket enkelt kan byta ut vilken datakälla vi vill använda. Detta är ett krav för att vi ska
kunna få Dependency Injection (DI) att fungera på önskat sätt. DI kommer vi täcka i detalj senare i
kursen. Då kommer denna instansiering ske automatiskt.
Lycka till och mycket nöje! Glöm inte att ni alltid kan höra av er om svårigheter uppstår.
