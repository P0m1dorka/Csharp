namespace KtPolimorphizm;

public class Immovable : Property
{
    public string name;
    public double worth
    {
        get { return base.worth; }
        set { }
    }
    public double place
    {
        get;
        set;
    }
    public Immovable(double Worth, double Place, string name) : base(Worth)
    {
        if (Worth < 0)
            throw new ArgumentOutOfRangeException();
        if(Place<=0)
            throw new ArgumentOutOfRangeException();
        worth = Worth;
        place = Place;
        this.name = name;
    }
    public override double Raschet()
    {
        switch (place)
        {
            case <100:
                return worth / 500;
            case <300:
                return worth / 350;
            case >=300:
                return worth / 250;
        }
        return 0;
    }

    public override string ToString()
    {
        
        return $"{name}: Стоимость - {worth}, налог - {Math.Round(Raschet(),2)}, площадь - {place} кв.м";
    }
}