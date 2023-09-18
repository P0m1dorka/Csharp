using HomeWork;

/*Console.WriteLine("Zadanie 1");
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
Summ(list);*/
/*Console.WriteLine("Zadanie 2");

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
}*/
Console.WriteLine("Zadanie 3");








void Summ(List<object> list)
{
    double summ = 0;
    for (int i = 0; i < list.Count; i++)
    {
        summ += Convert.ToDouble(list[i]);
    }
    Console.WriteLine(summ);
}