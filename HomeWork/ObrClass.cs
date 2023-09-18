namespace HomeWork;

public class ObrClass <T>
{
    private T Value;
    public ObrClass(T value)
    {
        Value = value;
    }
    public void Reset( T value)
    {
        Value = value;
    }
}