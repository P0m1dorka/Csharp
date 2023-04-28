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
    Methods mt = new Methods(mass,dynmass);
    mt.ZachislRand();
    mt.Nomer1();
    mt.Print();
    mt.PrintDynam();
    mt.Nomer2();
    mt.Print();
    mt.PrintDynam();
    mt.Nomer3();
}
catch (Exception)
{
Console.WriteLine("Вы ввели неправильный формат");
}














