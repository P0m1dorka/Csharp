namespace Loginov_CatFramework;

public abstract class Cat
{
    public abstract int Fluffiness
    {
        get; 
    }
    public virtual void FluffinessCheck()
    {
        Console.WriteLine("sss");
    }
    public override string ToString()
    {
        return $"A cat with fluffiness: {this.Fluffiness}";
    }
}