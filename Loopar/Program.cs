
// Loopar

/*
1. Skriv talen 20 till 30
Skriv en loop som skriver ut alla tal från 20 till 30.


for (int i = 20; i <= 30; i++)
{
    Console.WriteLine(i);
}
____________________________________________________________________________________*/

/*2.Jämna tal
Skriv en loop som skriver ut alla jämna tal från 0 till 30.


for(int i = 0; (i <= 30); i+=2)
{
       Console.WriteLine(i);
}
--------------------------------------------------------------------------------------*/
/*3.Var tredje "Hej"
Skriv en loop som skriver ut tal från 0 till 30, men om talet är jämnt delbart med 3 skriv istället “Hej”


for (int i = 0; i <= 30; i++)
{
    if (i % 3 == 0)
    {
        Console.WriteLine("Hej");
    }
    else
    {
        Console.WriteLine(i);
    }
}
----------------------------------------------------------------------------------------*/
/*4.Gångertabell
Gör ett program som ber användaren mata in ett tal,
skriv ut det talets “gångertabell” dvs,
multiplikationer av talet med alla tal från 1 t.o.m. 10.

Exempel:

Skriv in ett tal: 4
1 * 4 = 4
2 * 4 = 8...
10 * 4 = 40

Console.WriteLine("Skriv ett tal. Sedan gångrar jag det talet från 1 - 10.");
int nr = Int32.Parse(Console.ReadLine());

for(int tal = 1; tal <= 10; tal++)
{
    Console.WriteLine($"{tal} * {nr} = {nr * tal}");
}
----------------------------------------------------------------------------------------*/

/*5.Summa
Summan av alla tal 1 till 4, är 10 (1+2+3+4).
Gör ett program som räknar ut summan av alla tal 1 till 1000.

int tal = 0; 
for(int i = 1; i <= 1000; i++)
{
    tal += i;
}
Console.WriteLine("Summan av alla tal från 1 - 1000 är = " + tal);
---------------------------------------------------------------------------------------*/

/*
6.Riskorn på shackbräde
Enligt legenden så fick den man som hade konstruerat det formidabla spelet schack
önska sig något värdefullt av den överförtjuste kungen.
Monarken blev förvånad över uppfinnarens anspråkslöshet när gåvan skulle bestå av riskorn.

Antalet riskorn bestämdes enligt följande regel:
ett korn skulle lämnas för första rutan på ett schackbräde,
två korn för andra rutan, fyra för tredje, åtta för fjärde och
så ändå till den sista rutan.

Skriv ett program som hjälper kungen att beräkna antalet riskorn på vardera ruta.

Exempel:

Ruta 1: 1
Ruta 2: 2
Ruta 3: 4
Ruta 4: 8
Ruta 5: 16...
Ruta 64: ???


decimal rice = 1;

for (int i = 1; i <= 64; i++)
{
    Console.WriteLine($"Ruta {i}: {rice} ");
    rice *= 2;

}

-----------------------------------------------------------------------------------------------------------------------------*/
/*
7.Fylld box
Gör ett program som ber användaren mata in höjd och bredd. Printa ut en “box” med bokstaven X på skärmen med den höjd och bredd som matats in.

Exempel:

Mata in höjd: 3
Mata in bredd: 5
XXXXX
XXXXX
XXXXX



/*15.Sten, sax, påse
Skriv ett sten-sax-påse spel.
    Användaren skriver in “sten”, “sax” eller “påse”.
    Dators val slumpas med Random. Skriv sedan ut vad datorn valde,
    och vem som vann omgången. Lägg det hela i en loop så spelet fortsätter tills
    man matar in en tom sträng (trycker enter utan att skriva något).
    Skriv även ut poäng.


string rock = "sten";
string paper = "påse";
string scissor = "sax";

Random randomNr = new Random();
int randomIndex = = randomNr.Next(0, 3);
string computerHand = randomIndex switch {

    0 => scissor,
    1 => rock,
    2 => paper,
}


Console.WriteLine("Nu ska vi spela sten, sax eller påse!\nJag har redan valt, din tur!");
*/

