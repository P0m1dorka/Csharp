namespace KtPolimorphizm;

public abstract class Property
{
    public double worth;

    public Property(double Worth)
    {
        worth = Worth;
    }

    public virtual double Raschet()
    {
        return 0;
    }
}