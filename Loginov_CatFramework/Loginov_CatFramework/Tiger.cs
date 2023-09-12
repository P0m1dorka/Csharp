using System.Net.NetworkInformation;

namespace Loginov_CatFramework;

public  class Tiger : Cat
{
    public override int Fluffiness
    {
        get;
    }

    private double Weight
    {
        get;
    }

    public Tiger(int fluffiness = 50 , double weight = 50)
    {
        if ((weight < 75.0 || weight > 140.0) && (fluffiness < 0 || fluffiness > 100))
        {
            throw new CatException($"Unable to create a tiger with fluffiness {fluffiness} \n" +
                                   $"Unable to create a tiger with weight {weight}");
        }
        else if (fluffiness < 0 || fluffiness > 100)
        {
            throw new CatException($"Unable to create a tiger with fluffiness {fluffiness}");
        }
        else if (weight < 75.0 || weight > 140.0)
        {
            throw new CatException($"Unable to create a tiger with weight {weight}");
        }
        else
        {
            this.Fluffiness = fluffiness;
            this.Weight = weight;
        }
    }

    public override void FluffinessCheck()
    {
        Console.WriteLine("КУСЬ!");
    }
    public override string ToString()
    {
         Console.WriteLine($"A tiger with weight {this.Weight} fluffiness: {this.Fluffiness}");
         return "";
    }
}