using Lessons;
Random rnd = new Random();
List<int> dynmass = new List<int>();
try
{ 
    Console.WriteLine("Введи количество строк массива");
    int strok = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введи количество элементов в строке");
    int elem = Convert.ToInt32(Console.ReadLine());   
    int[,] mass = new int[strok,elem];
    Methods mth = new Methods(mass, dynmass);
    mth.ZachislRand();
    mth.Nomer1();
    mth.Print();
    mth.PrintDynam();
    mth.Nomer2();
    mth.Print();
    mth.PrintDynam();
    mth.Nomer3();
}
catch (Exception)
{
Console.WriteLine("Вы ввели неправильный формат");
}
 