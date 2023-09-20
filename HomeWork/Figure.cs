using System.Numerics;

namespace HomeWork;

public class Figure
{
    private Vector2 Vector2 ;
    private double Center;
/*
 * Левая верхняя точка:
- X-координата: центр - (ширина /) = 0 - (4 / 2) = -2
- Y-координата: центр + (высота / 2) = 0 + (2 / 2) = 1

Правжняя точка:
- X-координата: ц + (ширина / 2) = 0 + (4 / 2) = 2
- Y-координата: центр - (высота / 2) = 0 - (2 / 2) = -1

 */
    public virtual Vector2 MinPoint
    {
        get;
    }

    public virtual Vector2 MaxPoint
    {
        get;
    }
    public Figure()
    {
    }
}