using System.Numerics;

namespace HomeWork;

public class Square <T, K> : Figure
{
    public T width;
    public K height;
    public Vector2 center;

    public Square(T Width, K Height, Vector2 vector2)
    {
        width = Width;
        height = Height;
        center = vector2;
    }

    public override Vector2 MaxPoint
    {
        get
        {
            double x = (Convert.ToDouble(width) / 2);
            double y = (Convert.ToDouble(height)/2);
            return new Vector2(center.X-(float)x,center.Y + (float)y);
        }
    }

    public override Vector2 MinPoint
    {
        get
        {
            double x = (Convert.ToDouble(width) / 2);
            double y = (Convert.ToDouble(height) / 2);
            return new Vector2(center.X+(float)x, center.Y-(float)y);
        }
    }
}