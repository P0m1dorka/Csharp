namespace HomeWork;

public class ObrClass <T>
{
    private T Value;
    public ObrClass(T value )
    {
        Value = value;
    }
    public override string ToString()
    {
        Console.WriteLine($"Value:{Value}");
        return "";
    }

    public void Reset()
    {
        Value = default(T);
    }
}