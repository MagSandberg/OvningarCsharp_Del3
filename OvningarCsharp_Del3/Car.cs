using System.Threading.Channels;
using System.Xml.Linq;

namespace OvningarCsharp_Del3;


public class Car
{
    //.29
    private int _length;
    public int Length
    {
        get { return _length; }
        set { _length = value; }
    }

    private string _color;

    public string Color
    {
        get { return _color; }
        set { _color = value; }
    }

    public enum Colors
    {
        Red,
        Green,
        Blue,
        Yellow,
        Black
    }

    //Constructor
    public Car()
    {
        Random rand = new Random();

        Enum myColor = (Colors)rand.Next(0, 5);
        Color = myColor.ToString();
        Length = rand.Next(3, 5);
    }
}