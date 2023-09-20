using System.Numerics;

namespace HomeWork;

public class Circle <T> : Figure
{
    private T Radius
    {
        get;
        set;
    }

    private double Ploshad
    {
        get
        {
            return Math.PI * (Math.Pow(Convert.ToDouble(Radius),2)) ;
        }
    }

    public override Vector2 MinPoint { get; }
    public override Vector2 MaxPoint { get; }

    public Circle(T radius) 
    {
        Radius = radius;
    }
    public T SetRadius(T value)
    {
        Radius = value;
        return Radius;
    }
    public void Print()
    {
        Console.WriteLine($"Radius {Radius}, Ploshad {Ploshad}");
    }
}