//.29
//Skriv en klass som representerar en bil.Varje bil ska kunna ha en färg som representeras av
//en enum (det ska finna minst 5 olika färger på bilar), samt en längd.
//När man instansierar en bil så ska den få en random färg, och en random längd (mellan 3 och 5 meter).
//Instansiera 1000 bilar och spara i en array. Skriv sedan ut den sammanlagda längden av alla gröna bilar.




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

void Method(ref int refArgument)
{
    refArgument = refArgument * refArgument;
}

int number = 10;
Method(ref number);
Console.WriteLine($"{number}");