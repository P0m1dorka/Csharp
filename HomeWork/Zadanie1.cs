using HomeWork;

Console.WriteLine("Zadanie 1");
List<object> list = new List<object>();
for (int i = 0; i < 5; i++)
{
    list.Add(Console.ReadLine());
    if (list[i] is double)
    {
        Console.WriteLine("sstring");
    }
}
Console.WriteLine("ssssssss");
for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine(list[i]);
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


void Summ(List<object> list)
{
    double summ = 0;
    for (int i = 0; i < list.Count; i++)
    {
        summ += Convert.ToDouble(list[i]);
    }
    Console.WriteLine(summ);
}