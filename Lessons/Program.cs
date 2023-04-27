Random rnd = new Random();
List<int> dynmass = new List<int>();
Console.WriteLine("Введи количество строк массива");
int strok = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи количество элементов в строке");
int elem = Convert.ToInt32(Console.ReadLine());
int[,] mass = new int[strok,elem];
Zachisl(mass);
//Print(mass);
//Nomer1(mass,dynmass);
//Nomer2(mass,dynmass);
Nomer3(mass);

void Zachisl(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i, j] = 0;
        }
    }
}

void Print(int[,] mass)
{
    Console.WriteLine("");
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            Console.Write("{0,4}", mass[i, j]);
        }
    }
    Console.WriteLine("");
}
void Nomer1(int[,] mass, List<int> dynam)
{
    int summ = 0; 
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        summ = 0;
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            if (j == 0)
            {
                summ += mass[i, j];
                int k = i + 1;
                while (k < mass.GetLength(0))
                {
                    summ += mass[k, k - i];
                    k++;
                }
            }
        }
        dynam.Add(summ);
    }
}

void Nomer2(int[,] mass, List<int> dynam)
{
    dynam.Clear();
    int summ = 0;
    int k = 0;
    
    Console.WriteLine();
    for (int i = mass.GetLength(0)-1; i >= 0; i--)
    {
        summ = 0;
        if (i == 0)
        {
            summ += mass[i, 0];
            goto link1;
        }
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            if (j == 0)
            {
                summ += mass[i, j];
                k = i -1;
                while (k>=0)
                {
                    j++;
                    summ += mass[k, j];
                    k--;
                }
                
            }
        }
        link1:
        dynam.Add(summ);
    }
}

void Nomer3(int[,] mass)
{
    Console.WriteLine("Верхнетреугольной матрицы относительно главной диагонали");
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            if (j >= i){
                mass[i, j] = 1;
            }
            
        }
    }
   Print(mass);
   Zachisl(mass);
   Console.WriteLine("Нижнетреугольной матрицы относительно главной диагонали ");
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            if (j == i || j < i)
            {
                mass[i, j] = 1;
            }
        }
    }
    Print(mass);
    Zachisl(mass);
    Console.WriteLine("Верхнетреугольной матрицы относительно побочной диагонали");
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = mass.GetLength(1) - 1; j >= 0; j--)
        {
            
        }
    }
    Print(mass);
}
