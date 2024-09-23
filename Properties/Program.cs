
////          1. Person med property FirstName
////Skapa en klass "Person" som har en private field _firstName, och en public property FirstName.
////När man sätter värdet på FirstName ska detta sparas i _firstName,
////och när man läser värdet på FirstName ska den returnera det som finns lagrat i _firstName.

////          2. Autoproperty LastName
////Lägg till en publik auto-property LastName som går att både läsa och skriva.

////          3. Read-only property FullName
////Lägg sedan till en publik property FullName som är read only (bara get;)
////När man läser av propertyn så ska den returnera hela namnet. Testa koden genom att skapa ett objekt,
////tilldela värden på både FirstName och LastName, och sedan skriva ut FullName.


//Person myPerson = new();
//myPerson.FirstName = "Robin";
//myPerson.LastName = "Björkil";

//Console.WriteLine($"{myPerson.FullName}");

//class Person
//{
//public string FirstName { get; set; }
//private string _firstName;
//public string FirstName
//{
//    get
//    {
//        return _firstName;
//    }
//    set
//    {
//        _firstName = value;
//    }
//}
//    public string LastName { get; set; }
//    public string FullName
//    {
//        get
//        {
//            return $"{FirstName} {LastName}";
//        }

//    }
//}



////4.Stegräknare
////Skapa en klass som kan användas som stegräknare.
////Den ska ha en property "Steps" som bara går att läsa;
////en metod Step() som räknar upp Steps med 1 varje gång man anropar den;
////och en metod Reset() som nollställer räknaren.
////Instantiera klassen och skriv en loop som motsvarar att man går 1000 steg. Skriv ut värdet på Steps.


//StepCounter myStepCounter = new StepCounter();

//for (int i = 0; i < 10; i++)
//{
//    myStepCounter.Step();
//    Console.Write($"{myStepCounter.Steps}");
//}


//class StepCounter
//{
//    private int _steps;
//    public int Steps
//    {
//        get
//        {
//            return _steps;
//        }
//    }
//    public void Step()
//    {
//        _steps++;
//    }
//    public void Reset()
//    {
//        _steps = 0;
//    }
//}


//          5.Bil
//Skriv en ny klass som motsvarar en bil. Den ska ha privata fields för modell, pris och färg.
//Skapa publika properties för att hämta eller ändra värdet på varje field.
//Skriv en konstruktor till bilklassen som inte tar några parametrar.
//Skriv en till konstruktor som tar en parameter för varje property som klassen har och initierar dessa.
//Hur kan man styra vilken konstruktor som anropas när man skapar ett objekt av klassen?
//Skriv en metod till bilklassen med namnet HalfPrice(). När den anropas ska priset på bilen sänkas till hälften.


Car car1 = new();
car1.Model = "Volvo Polestar";
car1.Color = "Metallic Blue";
car1.Price = 500000;

Car car2 = new();
car2.Model = "Saab 9-5 SportCombi";
car2.Color = "Red";
car2.Price = 300000;


Car car3 = new();
car3.Model = "Tesla Model S";
car3.Color = "Pearl White";
car3.Price = 1500000;

Console.WriteLine($"En ny {car1.Color} {car1.Model} kostar ca {car1.Price}kr.");
Console.WriteLine($"Halva priset på en {car1.Model} är {car1.HalfPrice()}\n");
Console.WriteLine($"En ny {car2.Color} {car2.Model} kostar ca {car2.Price}kr.");
Console.WriteLine($"Halva priset på en {car2.Model} är {car2.HalfPrice()}\n");
Console.WriteLine($"En ny {car2.Color} {car3.Model} kostar ca {car3.Price}kr.");
Console.WriteLine($"Halva priset på en {car3.Model} är {car3.HalfPrice()}");

class Car
{
    public string Model { get; set; }

    public string Color { get; set; }

    public int Price { get; set; }

    public int HalfPrice()
    {
        return Price / 2;
    }

}


 














//-------------------------- SKOLEXEMPEL ----------------------------------------------------------------
//Otter myOtter = new();

//Console.WriteLine("Du har fått en utter! vad ska den heta?");
//myOtter.Name = Console.ReadLine();

//Console.WriteLine("Hur gammal vill du att din utter ska vara?");
//myOtter.Age = Int32.Parse(Console.ReadLine());

//Console.WriteLine($"Grattis! Du har nu en utter som heter {myOtter.Name} och är {myOtter.Age} år gammal!");

//class Otter
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//}


// Långa varianter av public string och int med get:ers och set:ers.

//          STRING
//private string _name = "Default Otter";
//public string Name
//{
//    get
//    {
//        return _name.ToUpper();
//    }
//    set
//    {
//        _name = value;
//    }
//}

//          INT
//private int _age;
//public int Age
//{
//    get
//    {
//        return _age;
//    }
//    set
//    {
//        _age = value;
//    }
//}
