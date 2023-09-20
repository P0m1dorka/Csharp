using System.Numerics;
using HomeWork;

Console.WriteLine("Zadanie 1");
Random rnd = new Random();
List<object> list = new List<object>(5);
for (int i = 0; i < 5; i++)
{
    if (rnd.NextDouble() < 0.5)
    {
        list.Add(rnd.Next(-20,20));
    }
    else
    {
        list.Add(rnd.NextDouble()*rnd.Next(-20,20));
    }
}
for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine( $"{i} - " + list[i]);
}
Summ(list);
Console.WriteLine("Zadanie 2");

for (int i = 0; i < 9; i++)
{
    switch (i)
    { 
        case <3:
            Book<string> book = new Book<string>("string", 5, "pivo", "ss");
            book.ToString();
            break;
        case <6:
            Book<int> books = new Book<int>("int", 7, "vodka", 8);
            books.ToString();
            break;
        case <9:
            Book<Guid> guidss = new Book<Guid>("guid", 4, "author", Guid.NewGuid());
            guidss.ToString();
            break;
    }
}

Console.WriteLine("Zadanie 3");
ObrClass<int> chisloObr = new ObrClass<int>(5);
ObrClass<Book<string>> bookObr = new ObrClass<Book<string>>(new Book<string>("name",5,"ktoo","5id"));
chisloObr.ToString();
bookObr.ToString();
chisloObr.Reset();
bookObr.Reset();
Console.WriteLine("after reset");
chisloObr.ToString();
bookObr.ToString();

Console.WriteLine("Zadanie 4");
Circle<int> intC = new Circle<int>(5);
Circle<string> intS = new Circle<string>("7");
Circle<double> intD = new Circle<double>(3.2);
Circle<float> intF = new Circle<float>(2.4f);

intC.Print();
intS.Print();
intD.Print();
intF.Print();
Console.WriteLine("Change");
intC.SetRadius(2);
intS.SetRadius("20");
intD.SetRadius(4.5);
intF.SetRadius(7.9f);
intC.Print();
intS.Print();
intD.Print();
intF.Print();

Console.WriteLine("Zadanie 5"); 
Square<int,string> first = new Square<int,string>(2,"4", new Vector2(0,0)); 
Console.WriteLine("max point:");
Console.WriteLine(first.MaxPoint);
Console.WriteLine("min point");
Console.WriteLine(first.MinPoint);

Square<double, float> sec = new Square<double, float>(3.3, 2.5F, new Vector2(1.5f, 2.5f));
Console.WriteLine("max point:");
Console.WriteLine(sec.MaxPoint);
Console.WriteLine("min point");
Console.WriteLine(sec.MinPoint);

Square<float, string> third = new Square<float, string>(4.2f, "3", new Vector2(-2, 3));
Console.WriteLine("max point:");
Console.WriteLine(third.MaxPoint);
Console.WriteLine("min point");
Console.WriteLine(third.MinPoint);
void Summ(List<object> list)
{
    double summ = 0;
    for (int i = 0; i < list.Count; i++)
    {
        summ += Convert.ToDouble(list[i]);
    }
    Console.WriteLine(summ);
}