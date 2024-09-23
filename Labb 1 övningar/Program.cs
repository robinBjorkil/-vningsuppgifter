
////                            Förberedelseövningar - Labb 1


////Här har ni fler övningsuppgifter med loopar och indexering av strängar.
////Dessa kan vara bra att lösa innan man ger sig på labb 1,
////då ni kommer lära er en del saker som kan hjälpa er på labben.

////OBS! Färgkodning i markdown verkar inte visas på GitHub.
////Checka ut och visa denna filen i Visual studio eller Visual studio code istället!
////-------------------------------------------------------------------------------------------------



////1. Bokstav för bokstav - fram till space
////Utgå från strängen (skapa en variabel med) "Hello World!",
////skriv ut hela strängen bokstav för bokstav, men avsluta när det kommer ett space.
////(Den ska alltså bara skriva “Hello”).

//string helloWorld = "Hello World";

//foreach (char c in helloWorld)
//{
//    Console.Write(c);
//    if (c == ' ')
//    {
//        break;
//    }
//}



////2.Bokstav för bokstav - radbyte på space
////Utgå från strängen "This is just some other text". Skriv ut strängen bokstav för bokstav,
////men när det kommer ett space, gör radbyte istället. (Du ska få ett ord på varje rad).

//string otherText = "This is just some other text";


//foreach (char c in otherText)
//{
//    Console.Write(c);
//    if (c == ' ')
//    {
//        Console.WriteLine();
//    }
//}


////3. Bokstav för bokstav - varannan stjärna
////Utgå från strängen "Detta är uppgift 3". Skriv ut bokstav för bokstav.
////Men om index är en jämn siffra, skriv istället ut *

//string task3 = "Detta är uppgift 3";

//for (int i = 0; i < task3.Length; i++)
//{
//    if (i % 2 == 0)
//    {
//        Console.Write("*");
//    }
//    else
//    {
//        Console.Write(task3[i]);
//    }
//}



////4. Bokstav för bokstav - gröna o, röda l
////Utgå från strängen "Hello world!". Skriv ut bokstav för bokstav.
////Alla 'o' ska vara grön färg, alla 'l' ska vara röd färg. Övriga bokstäver är vita/grå.

//string helloWorld = "Hello World!";

//for (int i = 0; i < helloWorld.Length; i++)
//{
//    if (helloWorld[i] == 'o')
//    {
//        Console.ForegroundColor = ConsoleColor.Green;
//        Console.Write('o');
//    }
//    else if (helloWorld[i] == 'l')
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.Write('l');
//    }
//    else
//    {
//        Console.ForegroundColor = ConsoleColor.White;
//        Console.Write(helloWorld[i]);
//    }
//}


////5. Bokstav för bokstav - dubbla med grön färg
////Utgå från strängen "Hello world". Skriv ut bokstav för bokstav.
////Om två tecken på rad är samma så ska dessa vara grön färg. Övriga bokstäver är vita/grå.

//string helloWorld = "Hello WWorld!";


//for (int i = 0; i < helloWorld.Length; i++)
//{

//    if (i == helloWorld.Length - 1)
//    {
//        Console.Write(helloWorld[i]);
//        break;
//    }
//    char nextChar = helloWorld[i + 1];
//    char currentChar = helloWorld[i];

//    if (nextChar == currentChar)
//    {
//        Console.ForegroundColor = ConsoleColor.Green;
//        Console.Write($"{currentChar}{nextChar}");
//        i++;
//    }
//    else
//    {
//        Console.ForegroundColor = ConsoleColor.White;
//        Console.Write(helloWorld[i]);
//    }
//}


////6. Bokstav för bokstav - grön substring
////Utgå från strängen "How much wood would a woodchuck chuck if a woodchuck could chuck wood?",
////samt den mindre strängen "oo". Skriv ut den långa strängen bokstav för bokstav.
////Varje gång den mindre strängen förekommer (två 'o' på raken)
////så ska dessa vara med grön färg. Övriga bokstäver är vita/grå.

//string woodchuck = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";

//for (int i = 0; i < woodchuck.Length; i++)
//{
//    if (i == woodchuck.Length - 1)
//    {
//        Console.WriteLine(woodchuck[i]);
//        break;
//    }

//    char nextChar = woodchuck[i + 1];
//    char currentChar = woodchuck[i];

//    if (nextChar == 'o' && currentChar == 'o')
//    {
//        Console.ForegroundColor = ConsoleColor.Green;
//        Console.Write($"{nextChar}{currentChar}");
//        i++;
//    }
//    else
//    {
//        Console.ForegroundColor = ConsoleColor.White;
//        Console.Write(woodchuck[i]);
//    }
//}


////7. Bokstav för bokstav - grön substring 2
////Samma som uppgift 6, men den mindre strängen är "chuck" istället för "oo".
////D.v.s. alla gånger "chuck" förekommer i den längre strängen skrivs dessa med grön text.


//string userInput = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
//string storedString = string.Empty;

//for (int i = 0; i < userInput.Length; i++)
//{
//    storedString += userInput[i];
//    if (storedString.Contains("chuck"))
//    {
//        Console.ForegroundColor = ConsoleColor.Green;
//        Console.Write(storedString);
//        storedString = string.Empty;
//    }
//    else if (storedString.Contains(" ") || i == userInput.Length - 1)
//    {
//        Console.ForegroundColor = ConsoleColor.White;
//        Console.Write(storedString);
//        storedString = string.Empty;
//    }
//}


////8. Bokstav för bokstav - grön substring 3
////Samma som uppgift 6 igen, men denna gången kan användaren mata in den kortare strängen,
////alltså valfri text som ska sökas (färgas grön) i den längre texten.

//Console.WriteLine("Skriv några ord.");
//string userInput = Console.ReadLine();

//Console.WriteLine("Skriv ett av orden du nyss skrev");
//string userInput2 = Console.ReadLine();

//string storedString = string.Empty;

//for (int i = 0; i < userInput.Length; i++)
//{
//    storedString += userInput[i];
//    if (storedString.Contains(userInput2))
//    {
//        Console.ForegroundColor = ConsoleColor.Green;
//        Console.Write(storedString);
//        storedString = string.Empty;
//    }
//    else if (storedString.Contains(" ") || i == userInput.Length - 1)
//    {
//        Console.ForegroundColor = ConsoleColor.White;
//        Console.Write(storedString);
//        storedString = string.Empty;
//    }
//}

////9. Bokstavspyramid
////Utgå från strängen "Hello world!".
////Gör ett program som skriver ut första bokstaven en gång på första raden.
////Andra bokstaven 2 gånger på andra raden. Tredje 3 gånger på nästa rad osv. Alltså:

////H
////ee
////lll
////... etc

//string userInput = "Hello world!";

//for (int i = 0; i < userInput.Length; i++)
//{
//    for (int j = 0; j <= i; j++)
//    {
//        Console.Write(userInput[i]);
//    }
//    Console.WriteLine();
//}


////10. Ordpyramid
////Utgå från strängen “How much wood would a woodchuck chuck if a woodchuck could chuck wood?”.
////Gör ett program som skriver ut första ordet en gång på första raden;
////andra ordet två gånger på nästa rad. Tredje ordet tre gånger på nästa. etc. alltså:

////How
////much much
////wood wood wood
////... etc

//string woodchuck = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
//string storedString = string.Empty;
//string[] woodchuckWords = woodchuck.Split(' ');


//for (int i = 0; i < woodchuckWords.Length; i++)
//{
//    storedString = woodchuckWords[i];
//    for (int j = 0; j <= i; j++)
//    {

//        Console.Write($"{storedString} ");
//    }
//    Console.WriteLine();
//}



////11. Ordpyramid 2
////Utgå från strängen “How much wood would a woodchuck chuck if a woodchuck could chuck wood?”.
////Gör ett program som på första raden skriver ut första ordet.
////På nästa rad skriver ut de två första orden, sedan de tre första orden på
////nästa rad o.s.v till man kommit till raden som skriver ut hela meningen. Alltså:

////How
////How much
////How much wood
////... etc


//string woodchuck = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
//string storedString = string.Empty;
//string[] woodchuckWords = woodchuck.Split(' ');


//for (int i = 0; i < woodchuckWords.Length; i++)
//{
//    for (int j = 0; j <= i; j++)
//    {
//        storedString = woodchuckWords[j];
//        Console.Write($"{storedString} ");
//    }
//    Console.WriteLine();
//}

////12. Rödmarkerade ord
////Utgå från samma sträng igen, men denna gång ska programmet skriva ut hela strängen på varje rad.
////På första raden ska första ordet vara rött (övriga vita),
////på andra raden ska andra ordet vara rött. På tredje raden ska tredje vara rött osv. Alltså:

////How much wood would a woodchuck chuck if a woodchuck could chuck wood?
////How much wood would a woodchuck chuck if a woodchuck could chuck wood?
////How much wood would a woodchuck chuck if a woodchuck could chuck wood?
////... etc

//villkor för loopar:
//för varje gång villkoret uppfylls för "for i", så säger "for i",till "for j" att göra sin grej.
//grejen som "for j" gör är att skriva ut ett ord i taget av den splittade strängen woodchuck.

//för varje gång "for i" har värde 0, så ska "for j" skriva ut sitt värde 0, med röd text och resten av texten vit.
//för varje gång "for i" har värde 1, så ska "for j" skriva ut sitt värde 1, med röd text och resten av texten vit.
//för varje gång "for i" har värde 2, så ska "for j" skriva ut sitt värde 2, med röd text och resten av texten vit.


//string woodchuck = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
//string[] woodchuckWords = woodchuck.Split(' ');

//for (int i = 0; i < woodchuckWords.Length; i++)
//{
//    for (int j = 0; j < woodchuckWords.Length; j++)
//    {
//        if (i == j)
//        {
//            Console.ForegroundColor = ConsoleColor.Red;
//            Console.Write($"{woodchuckWords[j]} ");
//        }
//        else
//        {
//            Console.ForegroundColor = ConsoleColor.White;
//            Console.Write($"{woodchuckWords[j]} ");
//        }
//    }
//    Console.WriteLine();
//}



////13. Rödmarkerade bokstäver
////Utgå från strängen "abcdefghijklmnopqrstuvwxyz". Hela strängen skrivs ut på varje rad.
////På första raden är de 5 första tecknen röda. På nästa rad är “bcdef” röda,
////sedan “cedfg” osv.. alltså alltid 5 tecken, men de flyttas ett steg åt höger för varje rad,
////tills sista raden har “vwxyz” rödfärgad. Alltså:

////abcdefghijklmnopqrstuvwxyz
////abcdefghijklmnopqrstuvwxyz
////abcdefghijklmnopqrstuvwxyz
////... etc



//string alphabet = "abcdefghijklmnopqrstuvwxyz";
//int length = 5;
////_________________________________________________________________

////for (int i = 0; i < alphabet.Length; i++)
////{
////	for (int j = 0; j < length; j++)
////	{

////	}
////}

////____________________________________________________________________________
//for (int i = 0; i <= alphabet.Length - length; i++)
//{
//    //int startOfLastPart = i + length;
//    string firstPartOfString = alphabet.Substring(0, i);
//    string redPartOfString = alphabet.Substring(i, length);
//    string lastPartOfString = alphabet.Substring(i + length);
//    //    string lastPartOfString = alphabet.Substring(i + length, alphabet.Length - (i + length)); // man behöver inte ett end index

//    Console.Write(firstPartOfString);
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.Write(redPartOfString);
//    Console.ResetColor();
//    Console.Write(lastPartOfString);
//    Console.Write($" i: {i,-5} i + length: {i + length,-5} a.Length - (i + length) {alphabet.Length - (i + length),-5} a.Length: {alphabet.Length,-5}");
//    Console.WriteLine();
//}




////14. Rödmarkerade bokstäver 2
////Användaren matar in valfri sträng. Programmet skriver ut hela strängen bokstav för bokstav.
////Alla bokstäverna är röda fram tills du stöter på ett tecken som är samma som första tecknet
////i strängen. Därefter skriver den ut resten av bokstäverna med vit/grå färg.
////Några exempel vid olika inmatningar/körningar:

////ajdfhvajhdfd
////hhfgijff
////fjpdpog

//Console.WriteLine("skriv massor av tecken.");
//string input = Console.ReadLine();
//char firstChar = input[0];


//for (int i = 0; i < input.Length; i++)
//{
//    if (input[i] == firstChar && i == 0)
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//    }
//    Console.Write(input[i]);
//    if (i > 0 && input[i] == firstChar)
//    {
//        Console.ForegroundColor = ConsoleColor.White;        
//    }
//}



////15. Rödmarkerade bokstäver 3
////Användaren matar in valfri sträng. Programmet skriver sedan ut en hela strängen flera gånger.
////På första raden börjar den skriva med röd färg på första bokstaven och fram tills den hittar
////samma bokstav igen. På andra raden börjar den skriva med röd färg på andra bokstaven och fram
////tills den hittar samma bokstav igen. På tredje raden börjar den skriva med röd text på tredje
////bokstaven och fram tills den hittar samma igen... etc. Om man t.ex matar in “ajdfhvajhdfd”
////blir det då:

////ajdfhvajhdfd
////ajdfhvajhdfd
////ajdfhvajhdfd
////ajdfhvajhdfd
////... etc



//string input = "ajdfhvajhdfd";

//for (int i = 0; i < input.Length; i++)
//{
//    Console.ForegroundColor = ConsoleColor.White;

//    char firstChar = input[i];
//    for (int j = 0; j < input.Length; j++)
//    {
//        if (j == i)
//        {
//            Console.ForegroundColor = ConsoleColor.Red;
//        }
//        Console.Write(input[j]);

//        if (j > i && input[j] == firstChar)
//        {
//            Console.ForegroundColor = ConsoleColor.White;
//        }
//    }
//    Console.WriteLine();

//}

//Console.ResetColor();
