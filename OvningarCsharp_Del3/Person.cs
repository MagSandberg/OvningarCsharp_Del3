namespace OvningarCsharp_Del3;
//Skapa en klass “Person” som har minst 5 properties som lagrar data om en person(t.ex.namn, telefonnr, etc).
//Skapa en Dictionary<string, Person> med minst 5 key-value-pairs. Nyckeln ska vara personnummer.
public class Person
{
    private string _namn;

    public string Namn
    {
        get { return _namn; }
        set { _namn = value; }
    }

    private int _tel;

    public int Tel
    {
        get { return _tel; }
        set { _tel = value; }
    }

    private string _adress;

    public string Adress
    {
        get { return _adress; }
        set { _adress = value; }
    }

    private int _persNummer;

    public int PersNummer
    {
        get { return _persNummer; }
        set { _persNummer = value; }
    }

    private string _stad;

    public string Stad
    {
        get { return _stad; }
        set { _stad = value; }
    }

    public override string ToString()
    {
        return $"{Namn}, {Tel}, {PersNummer}, {Stad}";
    }

    public Person(string namn, int tel, string adress, int persNummer, string stad)
    {
        _namn = namn;
        _tel = tel;
        _adress = adress;
        _persNummer = persNummer;
        _stad = stad;
    }
}