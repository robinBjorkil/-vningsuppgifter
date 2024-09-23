
////                                     Indexering


////1.En bokstav på varje rad
////Be användaren mata in en sträng. Skriv ut varje tecken i strängen på en egen rad.

////Exempel:

////Skriv något: Hej
////H
////e
////j

////Pröva att lösa uppgift med for-loop istället, för att sedan implementera på uppgift 4.

//Console.WriteLine("Skriv ett ord.");
//string word = Console.ReadLine();

//foreach(char letter in word)
//{
//    Console.WriteLine(letter);
//}


////2. Siffror till text
////Skapa ett program med en array som innehåller strängarna
////“noll”, “ett”, “två”, “tre”, “fyra”, “fem”, “sex”, “sju”, “åtta”, “nio”.
////Be sedan användaren att mata in en siffra. Använd arrayen för att skriva ut siffrans ord.
////Ex. Inmatning “3” => “tre”.

////Exempel:

////Skriv en siffra: 3
////tre
////Extra utmaning: Användaren kan mata in en sträng med fritt antal siffror,
////om man skriver in t.ex 432 så svarar programmet: “fyra - tre - två”.



//string[] numeral = new string[10];
//numeral[0] = "noll";
//numeral[1] = "ett";
//numeral[2] = "två";
//numeral[3] = "tre";
//numeral[4] = "fyra";
//numeral[5] = "fem";
//numeral[6] = "sex";
//numeral[7] = "sju";
//numeral[8] = "åtta";
//numeral[9] = "nio";

//Console.WriteLine("Skriv en siffra.");
//int number = Int32.Parse(Console.ReadLine());

//Console.WriteLine(numeral[number]);


////3. Baklänges
////Be användaren mata in en text. Skriv sedan ut texten baklänges.

////Exempel:

////Skriv något: Hello there!
////!ereht olleH

//Console.WriteLine("Skriv något.");

//string input = Console.ReadLine();
//string output = "";


//for(int i = input.Length - 1; i >= 0; i--)
//{
//    output += input[i];
//}

//Console.WriteLine(output);

////4. Dölj vokaler
////Be användaren mata in en text. Skriv ut texten med alla vokaler ersatta med *

////Exempel:

////Skriv något: Hejsan, jag heter Fredrik!
////H*js*n, j*g h*t*r Fr*dr*k!
////Extra utmaning: Skriv ut texten översatt till rövarspråket.




//Console.WriteLine("Skriv en text:");
//string input = Console.ReadLine();

//char[] vowel = { 'a', 'o', 'u', 'å', 'e', 'i', 'y', 'ä', 'ö' };
//string output = "";

//for(int i = 0; i < input.Length; i++)
//{
//    if (input.Equals(vowel[0]))
//    {
//        Console.WriteLine($"{output} += {input} *");
//    }
                
//}

//Console.WriteLine(output);

//om vokalarrayen innehåller tecknet vi är på, skriv stjärna
//annars skriv tecknet


//skriv ut output

////5. Palindrom
////Ett palindrom är ett ord som blir samma framlänges som baklänges.
////Be användaren skriva in ett ord och ange sedan om det är ett palindrom eller inte.

////Exempel:

////Skriv ett ord: Kajak
////Kajak är ett palindrom.


////6. Miniräknare
////Skapa en enkel miniräknare som kan hantera de fyra räknesätten med två operander.
////Till skillnad från uppgift 6 i övningsuppgifter med variabler, så ska inmatningen nu ske på en rad 
////(första talet, operator, andra talet). Ignorera inmatade mellanslag i strängen.
////Om man t.ex. matar in strängen "34 - 14", så ska programmet skriva ut "= 20".
////Exempel:

////Vad vill du räkna ut? 15 * 4
////= 60


////7. Omvänd ordning
////Be användaren skriva in ett ord, sedan ett till, och ett till; tills man skrivit in 7 ord.
////Skriv sedan ut orden på skärmen i bakvänd ordning mot hur de matades in.
////Alltså ordet man skrev in sist, skrivs ut först.


////8. Fördröjd utskrift
////Skapa ett program som ber användaren att skriva in ett ord.
////Sedan ett till, och ett till i all evighet.
////Varje gång man skrivit in ett ord så ska programmet skriva ut det ord man skrev 10 inmatningar tidigare.
////Men om man inte skrivit in 10 ord än så kan den istället skriva just det: “Du har inte skrivit in 10 ord än.”


////9. Bokstavspyramid
////Skapa ett program som skriver ut första tecknet i "Hello World" på första raden,
////de 2 första tecknen på andra raden osv.

////Exempel:

////H
////He
////Hel
////...
////Hello Worl
////Hello World


////10.Färgade bokstäver
////Man kan byta färg som används för utskrift i console med hjälp av
////Console.ForegroundColor (t.ex Console.ForegroundColor = ConsoleColor.Red)

////Skapa ett program som ber användaren mata in en text.
////Be sedan användaren mata in en bokstav. Skriv ut strängen som matades in;
////de bokstäver som är samma som den användaren valde ska skriva ut med röd färg,
////alla andra med grå..

//Console.WriteLine("Hej! mata in en text");
//string fras = Console.ReadLine();

//Console.WriteLine("Skriv en bokstav som finns i det du nyss skrev.");
//char bokstav = Console.ReadLine()[0];

//foreach (char myChar in fras)
//{
//    if (myChar == bokstav)
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//    }
//    else
//    {
//        Console.ForegroundColor = ConsoleColor.Gray;
//    }
//    Console.Write(myChar);
//}


////11. Start & Stop
////Be användaren mata in en text. Be sedan om ett startindex, och sedan om ett stopindex.
////Skriv ut hela texten, men alla tecken från startindex till stopindex ska vara röda.

////Exempel:

////Mata in en text: Detta är en text
////Välj startindex: 3
////Välj stopindex: 9
////Detta är en text


////12. Växla färg
////Be användaren mata in en text. Be sedan användaren mata in en bokstav.
////Skriv ut hela texten, rödmarkera från första stället den hittar bokstaven
////till andra stället den hittar bokstaven, från tredje stället till fjärde o.s.v.

////Exempel:

////Mata in text: How much wood would a woodchuck chuck if a woodchuck could chuck wood?
////Välj bokstav: o

////How much wood would a woodchuck chuck if a woodchuck could chuck wood?