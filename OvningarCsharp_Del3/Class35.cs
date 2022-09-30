namespace OvningarCsharp_Del3;
//Skapa en klass som har en privat konstruktor, och en statisk metod som anropar konstruktorn och returnerar
//en ny instans av objektet. //OM ni är klara; lägg till en public readonly int (field) i klassen som får
//ett random tal 0-100 för varje objekt som instansieras.
public class Class35
{
    public readonly int _rndNum;

    private Class35()
    {
        Action callCtor = CallCtor;
        Random rand = new Random();
        _rndNum = rand.Next(0, 101);
        Console.WriteLine(_rndNum);
    }


    public static void CallCtor()
    {
        var callingCtor = new Class35();
    }
}