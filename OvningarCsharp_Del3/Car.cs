using System.Threading.Channels;
using System.Xml.Linq;

namespace OvningarCsharp_Del3;

public class Car
{
    //.29
    private string _color;
    private string _length;
    
    public enum Color
    {
        Red,
        Green,
        Blue,
        Yellow,
        Black
    }

    private Random rndLength = new Random();
    private Random rndColor = new Random();
    public void RandomColor()
    {
        Enum carRndColor = (Color)rndColor.Next(0, 4);
        string myRndColor = carRndColor.ToString();
        _color = myRndColor;
    }
    public void RandomLength()
    {
        var carRndLength = rndLength.Next(3, 5);
        string myRndLength = carRndLength.ToString();
        _length = myRndLength;
    }

    public void RandomValues()
    {
        Console.WriteLine($"{_color}, {_length}");
    }

    //Constructor
    public Car()
    {
    }
}