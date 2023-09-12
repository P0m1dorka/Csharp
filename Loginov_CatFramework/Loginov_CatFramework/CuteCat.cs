namespace Loginov_CatFramework;
public class CuteCat : Cat
{
    public override int Fluffiness { get; }
    public CuteCat(int fluffiness = 50)
    {
        if (fluffiness < 0 || fluffiness > 140)
            throw new CatException($"Unable to create a cute cat with fluffiness: {fluffiness}");
        this.Fluffiness = fluffiness;
    }
    public override void FluffinessCheck()
    {
        switch (this.Fluffiness)
        {
            case 0:
                Console.WriteLine("Sphynx");
                break;
            case <=20:
                Console.WriteLine("Slightly");
                break;
            case <=50:
                Console.WriteLine("Medium");
                break;
            case <75:
                Console.WriteLine("Heavy");
                break;
            case >=75:
                Console.WriteLine("OwO");
                break;
        }
    }
    public override string ToString()
    {
        Console.WriteLine($"A cute cat fluffiness: {this.Fluffiness}");
        return " ";
    }
}