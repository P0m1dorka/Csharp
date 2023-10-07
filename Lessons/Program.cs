delegate void Del();
delegate void Del2();
class Program
{
    static void Main(string[] args)
    {
        List<Del> list = new List<Del>();
        Del del1 = MyClass3.Lol;
        Del del2 = MyClass.Good;
        Del del3 = MyClass.Hello;
        Del del4 = MyClass3.Pivo;
        list.Add(del1);
        list.Add(del2);
        list.Add(del3);
        list.Add(del4);
        foreach (Del VARIABLE in list)
        {
            VARIABLE.Invoke();
        }
    }
}

class MyClass
{
   public static void Hello()
    {
        Console.WriteLine("Hello world");
    }
   public static void Good()
    {
        Console.WriteLine("Bye");
    }
}
class MyClass3
{
    public static void Lol()
    {
        Console.WriteLine("Lol");
    }
    public static void Pivo()
    {
        Console.WriteLine("Pivo");
    }
}