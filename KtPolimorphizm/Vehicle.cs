namespace KtPolimorphizm;

public class Vehicle : Property
{
    public string name;
    public double worth
    {
        get
        {
            return base.worth;
        }
        set{}
    }
    public double obiem
    {
        get
        {
            return base.worth;
        }
        set{}
    }
    public Vehicle(double Worth, double Obiem, string name) : base(Worth)
    {
        if (Worth < 0)
            throw new ArgumentException();
        if (Obiem < 0)
            throw new AggregateException();
        worth = Worth;
        obiem = Obiem;
        this.name = name;
    }
    public override double Raschet()
    {
        return (worth*obiem)/3000;
    }
    public override string ToString()
    {
        return $"{name}: Стоимость - {worth}, налог - {Math.Round(Raschet(),2)}, объём двигателя - {obiem} см.куб";
    }
}