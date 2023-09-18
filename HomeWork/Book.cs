namespace HomeWork;

public class Book <T>
{
    private string Name;
    private int PagesCount;
    private string Author;
    private T Id;

    public Book(string name, int pagesCount, string author, T id)
    {
        this.Name = name;
        this.PagesCount = pagesCount;
        this.Author = author;
        this.Id = id;
    }
    public override string ToString()
    {
        Console.WriteLine($"{this.Id} {this.Name} {this.Author} {this.PagesCount} страниц");
        return "";
    }
}