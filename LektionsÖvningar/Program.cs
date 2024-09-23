////Person mySelf = new Person() { firstName = "Robin", lastName = "Björkil", mother = "Cickie", father = "Ingemar" };
////Person myWife = new Person() { firstName = "Linnea", lastName = "Johanson", mother = "Christina", father = "Peter" };
////Person status = new Person() { status = "gifta" };
////Person adress = new Person() { adress = "Flatås" };



////Console.WriteLine($"{mySelf.firstName} heter {mySelf.lastName} i efternamn.");
////Console.WriteLine($"{myWife.firstName} hette tidigare {myWife.lastName} i efternamn men numera heter hon {mySelf.lastName}.");

////Console.WriteLine(mySelf.GetFullName());
////Console.WriteLine(mySelf.GetFullNameReversed());
////Console.WriteLine(mySelf.GetFullName("Dj."));
////Console.WriteLine();

//Person mig = new Person();
//mig.firstName = "Robin";
//mig.lastName = "Björkil";

//Person mother = new Person();
//mother.firstName = "Cickie";
//mother.lastName = "Björkil";

//mig.mother = mother;

//Person father = new Person();
//father.firstName = "Ingemar";
//father.lastName = "Sandberg";

//mig.father = father;

//Person robin = new Person();
//robin.SetLenght(1.73);
//robin.SetWeight(61.5);
//Console.WriteLine($"{mig.firstName} är {robin.GetLenght()}m lång.");
//Console.WriteLine($"{mig.firstName} väger {robin.GetWeight()}kg");
//Console.WriteLine($"{mig.firstName} har ett BMI-värde på: {robin.GetBMI()}");

//Console.WriteLine(mig.GetFullNameReversed());
//Console.WriteLine(mig.GetFullName("Dj."));
//Console.WriteLine(mig.GetFullName());
//Console.WriteLine(mig.mother.GetFullName());
//Console.WriteLine(mig.father.GetFullName());
//Console.WriteLine(mig.GetSelfAndParents());

//class Person
//{
//    public string firstName;
//    public string lastName;
//    public Person mother;
//    public Person father;

//    public string GetFullName()
//    {
//        return $"{firstName} {lastName}";
//    }

//    public string GetFullName(string titel)
//    {
//        titel = $"Dj. {firstName} {lastName} aka Dj Psycorrhiza.";
//        return titel;
//    }
//    public string GetFullNameReversed()
//    {
//        string backWards = string.Empty;
//        for (int i = GetFullName().Length - 1; i >= 0; i--)
//        {
//            backWards += GetFullName()[i];
//        }
//        return backWards;
//    }
//    public string GetSelfAndParents()
//    {
//        if (mother == null && father == null)
//        {
//            return $"{this.GetFullName()} - Mamma: okänd - Pappa: okänd";
//        }
//        else if (mother == null)
//        {
//            return $"{this.GetFullName()} - Mamma: okänd - Pappa: {this.father.GetFullName()}";
//        }
//        else if (father == null)
//        {
//            return $"{this.GetFullName()} - Mamma: {this.mother.GetFullName()} - Pappa: okänd";
//        }
//        else
//        {
//            return $"{this.GetFullName()} - Mamma: {this.mother.GetFullName()} - Pappa: {this.father.GetFullName()}";
//        }
//    }

//    private double lenght;
//    public void SetLenght(double lenght)
//    {
//        this.lenght = lenght;
//    }
//    public double GetLenght()
//    {
//        return lenght;
//    }


//    private double weight;
//    public void SetWeight(double weight)
//    {
//        this.weight = weight;
//    }
//    public double GetWeight()
//    {
//        return weight;
//    }

//    public double GetBMI()
//    {
//        return weight / (lenght * lenght);
//    }


//}