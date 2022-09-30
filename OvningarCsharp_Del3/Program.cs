//.29
//Skriv en klass som representerar en bil.Varje bil ska kunna ha en färg som representeras av
//en enum (det ska finna minst 5 olika färger på bilar), samt en längd.
//När man instansierar en bil så ska den få en random färg, och en random längd (mellan 3 och 5 meter).
//Instansiera 1000 bilar och spara i en array. Skriv sedan ut den sammanlagda längden av alla gröna bilar.

//using OvningarCsharp_Del3;

//var cars = new Car[1000];
//for (int i = 0; i < 1000; i++)
//{
//    cars[i] = new Car();
//}

//var sumLength = 0;

//foreach (var car in cars)
//{
//    if (car.Color == Car.Colors.Green.ToString())
//    {
//        sumLength += car.Length;
//    }
//}

//Console.WriteLine(sumLength);


//.31
//Skriv metod: void ConvertDegrees(float Celsius, out float Fahrenheit, out float Kelvin)
//Metoden ska ta antal grader i Celsius in, och man ska få ut motsvarigheten i Fahrenheit
//och Kelvin i out-parametrarna. Ta input från användaren i Celsius, använd metoden och skriv ut resultat.
//float userInput = float.Parse(Console.ReadLine());
//void ConvertDegrees(float Celsius, out float Fahrenheit, out float Kelvin)
//{
//    Celsius = userInput;
//    Fahrenheit = (userInput * 9) / 5 + 32;
//    Kelvin = userInput + 273.15f;
//}

//ConvertDegrees(userInput, out float fahrenheit, out float kelvin);

//Console.WriteLine($"C: {userInput}, F: {fahrenheit}, K: {kelvin}");


//.33
//Skriv en metod som använder en ref int som in-parameter och som multiplicerar referensen med sig själv.
//Den ska även returnera parametern konverterad till en sträng.
//Anropa metoden och skriv sedan ut både den inskickade (uppdaterade) variabeln, och det returnerade värdet.

//void Method(ref int refArgument, ref string myString)
//{
//    refArgument = refArgument * refArgument;
//    myString = refArgument.ToString();
//}

//int myNumber = 10;
//int myNumber2 = myNumber;
//string myString = String.Empty;
//Method(refArgument: ref myNumber, myString: ref myString);
//Console.WriteLine($"{myNumber2}, {myString}");


//.35
//Skapa en klass som har en privat konstruktor, och en statisk metod som anropar konstruktorn och returnerar
//en ny instans av objektet. //OM ni är klara; lägg till en public readonly int (field) i klassen som får
//ett random tal 0-100 för varje objekt som instansieras.

//using OvningarCsharp_Del3;

//for (int i = 0; i < 3; i++)
//{
//    Class35.CallCtor();
//}


//.38

//Skapa en klass “Person” som har minst 5 properties som lagrar data om en person (t.ex. namn, telefonnr, etc).
//Skapa en Dictionary<string, Person> med minst 5 key-value-pairs. Nyckeln ska vara personnummer.
//Skriv ett program som ber användaren skriva in ett personnummer, och lista all info om den personen.

using OvningarCsharp_Del3;

Dictionary<string, Person> personer = new Dictionary<string, Person>();
personer.Add("850324", new Person("Magnus", 0733299038, "Hasselvägen 2", 850324, "Romelanda"));
personer.Add("860401", new Person("Hanna", 0733299038, "Hasselvägen 2", 850324, "Romelanda"));

Console.Write("Skriv in ditt personnummer:");
string pNum = Console.ReadLine();

if (personer.ContainsKey(pNum))
{
    Person p = personer[pNum];
    Console.WriteLine(p);
}
