

////                                                       Variabler

////1.Hälsa på användaren
////Skriv ett program som frågar efter användarens namn.

//Console.WriteLine("Hej! vad heter du?");
//string name = Console.ReadLine();
//Console.WriteLine("Hej " + name + "!");


////2.Multiplicera två tal
////Skriv ett program som ber användaren mata in två heltal.
////Skriv ut talen multiplicerade med varandra.


//Console.WriteLine("Hej! skriv in två tal, börja med första talet.");
//int nr1 = Int32.Parse(Console.ReadLine());
//Console.WriteLine("Skriv in nästa tal");
//int nr2 = Int32.Parse(Console.ReadLine());

//int produkt = nr1 * nr2;
//Console.WriteLine("Produkten av " + nr1 + " * " + nr2 + " är " + produkt);


////3.Verifiera lösenord
////Skriv ett program som frågar användaren efter ett lösenord.
////Hitta på ett hemligt lösenord och spara det i en variabel.
////När användaren har skrivit in ett lösenord ska programmet jämföra
////med det sparade lösenordet och skriva ut om det var rätt eller inte
////Använd en if-sats.


//int password = 666;
//Console.WriteLine("Skriv in rätt lösenord:");
//int answer = Int32.Parse(Console.ReadLine());

//if (answer == password)
//{
//    Console.WriteLine("Rätt lösenord!");
//}
//else
//{
//    Console.WriteLine("Fel lösenord!");
//}


////4.Jämför tal
////Skriv ett program som frågar användaren efter ett tal.
////Det ska skriva ut om talet är mindre, större eller lika med 100.


//Console.WriteLine("Hej! skriv ett tal och tryck enter.");
//int nr = Int32.Parse(Console.ReadLine());
//int hundred = 100;

//if (nr == hundred)
//{
//    Console.WriteLine("Du skrev 100!");
//}
//else if (nr < hundred)
//{
//    Console.WriteLine(nr + " är mindre än 100.");
//}
//else
//{
//    Console.WriteLine(nr + " är större än 100.");
//}


////5.Dubblera och halvera tal
////Be användaren mata in ett tal. Skriv ut talet som är dubbelt, respektive hälften.


//Console.WriteLine("Skriv in ett tal så kommer jag att dubblera och halvera ditt tal.");
//double nr = Int32.Parse(Console.ReadLine());

//double dubbel = nr * 2;
//double halv = nr / 2;

//Console.WriteLine(dubbel + " är dubbelt så mycket som " + nr + "!");
//Console.WriteLine(halv + " är hälften av " + nr + "!");


////6.Miniräknare
////Skriv ett program som först frågar efter ett tal,
////sedan frågar den efter ett av följande tecken: +, -, *eller /.
////Därefter ska ytterligare ett tal efterfrågas.
////Programmet ska fungera som en simpel miniräknare.
////Om man t.ex matat in först 3, sedan *, och sist 5,
////så ska programmet skriva ut “3 * 5 = 15”.


//Console.WriteLine("Skriv ett tal.");
//double nr1 = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("välj ett räknesätt: +, -, * eller /:");
//string choice = Console.ReadLine();

//Console.WriteLine("Skriv ett till tal.");
//double nr2 = Convert.ToDouble(Console.ReadLine());

//switch (choice)
//{
//    case "+":
//        Console.WriteLine($"{nr1} + {nr2} är = {nr1 + nr2}");
//        break;

//    case "-":
//        Console.WriteLine($"{nr1} - {nr2} är = {nr1 - nr2}");
//        break;

//    case "*":
//        Console.WriteLine($"{nr1} * {nr2} är = {nr1 * nr2}");
//        break;

//    case "/":
//        Console.WriteLine($"{nr1} / {nr2} är = {nr1 / nr2}");
//        break;
//}


////7.Summa och medelvärde
////Skriv ett program som upprepade gånger frågar användaren efter ett tal ända till man
////skriver något som inte är ett tal (t.ex bara trycker enter).
////Efter varje inmatning ska summan av alla tal som matats in skrivas ut,
////innan nästa inmatning efterfrågas. Innan programmet avslutas ska man även skriva ut
////medelvärde av de inmatade talen.

////Exempel:

////Skriv in ett tal: 3
////3
////Skriv in ett tal: 2
////5
////Skriv in ett tal: 7
////12
////Skriv in ett tal:
////Medelvärde: 4
////Tips: Kolla upp TryParse();



//double amountNumbers = 0.0;
//double totalSum = 0.0;
//bool ok1 = true;
//while (ok1)
//{
//    Console.Write("Enter a number: ");
//    string input = Console.ReadLine();
//    if (double.TryParse(input, out double parsedValue))
//    {
//        amountNumbers++;
//        totalSum += parsedValue;
//        Console.WriteLine(totalSum);
//    }
//    else
//    {
//        Console.WriteLine();
//        double average = totalSum / amountNumbers;
//        Console.WriteLine($"Average is {average}");
//        break;
//    }
//}
