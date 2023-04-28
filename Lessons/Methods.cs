    namespace Lessons;

    public class Methods
    {
        public int[,] mass;
        public List<int> dynam;
        public Methods(int[,] mass,List<int> dynam)
        {
            this.mass = mass;
            this.dynam = dynam;
        }

        private Random rnd = new Random();
        public void Zachisl()
        {
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    mass[i, j] = 0;
                }
            }
        }
        public void ZachislRand()
        {
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    mass[i, j] = rnd.Next(5,11);
                }
            }
        }

    public void Print()
    {
        for (int i = 0; i < mass.GetLength(0); i++)
        {
            Console.WriteLine();
            for (int j = 0; j < mass.GetLength(1); j++)
            {
                Console.Write("{0,3}", mass[i, j]);
            }
        }
    }

    public void PrintDynam()
    {
        Console.WriteLine(" ");
        Console.WriteLine("Динамичесский массив:");
        for (int i = 0; i < dynam.Count; i++)
        {
            Console.Write( " " + dynam[i]  );
        }
        dynam.Clear();
    }
    public void Nomer1() //паралельных главной
    {
        Console.WriteLine("Вычислить сумму элементов диагоналей, параллельных главной и занести в массив ");
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

    public void Nomer2() //паралельных побочной
    {
      
        int summ = 0;
        int k = 0;
        Console.WriteLine(" ");
        Console.WriteLine("Вычислить сумму элементов диагоналей, параллельных побочной и занести в массив ");
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

    public void Nomer3()
    {
        Zachisl();
        Console.WriteLine(" ");
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
       Print();
       Zachisl();
       Console.WriteLine(" ");
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
        Print();
        Zachisl();
        int d = 0;
        Console.WriteLine(" ");
        Console.WriteLine("Верхнетреугольной матрицы относительно побочной диагонали");
        for (int i = mass.GetLength(0)-1; i >=0; i--)
        {
            for (int j = mass.GetLength(1)-1; j >= 0; j--)
            {
                if (j <= d)
                {
                    mass[i, j] = 1;
                }
            }

            d++;
        }
        Print();
        Zachisl();
        d = 0;
        Console.WriteLine(" ");
        Console.WriteLine("Верхнетреугольной матрицы относительно побочной диагонали");
        for (int i = mass.GetLength(0)-1; i >=0; i--)
        {
            for (int j = mass.GetLength(1)-1; j >= 0; j--)
            {
                if (i>= mass.GetLength(0)/2)
                {
                    if (j >= d)
                    {
                        mass[i, j] = 1;
                        
                    }
                }
                else
                {
                    if (j >= d)
                    {
                        mass[i, j] = 1;
                    }  
                }
            }
            d++;

         
        }
        Print();
        
    }

    }