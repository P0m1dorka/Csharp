namespace Lessons
{
    class Program
    {
        delegate void Print();
        public static void Main(string[] args)
        {
            //nomer 1
            Print pr;
            Weather wt = new Weather();
            Console.WriteLine("Введите прогноз погоды");
            Console.WriteLine("H - жара");
            Console.WriteLine("R - дождь");
            Console.WriteLine("С - хллод");
            string? weather = Console.ReadLine();
            char symbol;
            if(weather is null)
            {
                Console.WriteLine("Ничего не ввели");
                throw new Exception("Вы ничего не ввели");
                 throw new NotImplementedException();
            }
            else
            {
                for(int i =0; i< weather.Length;i++){
                   symbol = weather[i];
                   switch (symbol)
                   {
                        case 'C':
                            pr = wt.Holod;
                            pr();
                            break;
                        case 'R':
                            pr = wt.Rain;
                            pr();
                            break;
                        case 'H':
                            pr = wt.Hot;
                            pr();
                            break;
                        case ' ':
                            break;
                        default:
                            Console.WriteLine("Вы ввели какой-то иной символ. Не C или R или H");
                            break;
                   }
                }
            }
            //nomer 2
            Console.WriteLine("Сколбко всего было машин?");
            int razmer = Convert.ToInt32(Console.ReadLine());
            FuelTank[] array = new FuelTank[razmer]; //массив машин
            int type = 0; // нужен для определения типа машины
            double Vb = 0; // вместимость бензобака
            TypeCar tc = TypeCar.Sport; // отвечает за тип машины
            int kb = 0; //количество бензобаков
            int slb = 0; //стоимость однго литра бензина
            double rb = 0; //средний расход бензина на 1 км
            if(razmer<=0){ //если машин нет или они отрицательные, то выкидываем экспешн
                throw new Exception("Машин нет");
                 throw new NotImplementedException();
            }
            else // если же машин больше 0 то начинаем вносить машины
            {
                for(int i = 0; i < array.Length;i++) // прогоняемся по всей длинне массива машин
                {
                    Console.WriteLine($"Введи тип машины для {i+1}. Автбоус - 1, СпортКар - 2");
                    type = Convert.ToInt32(Console.ReadLine()); //с помощью чисел проверяю какой тип машины будет у объекта
                    switch (type)
                    {
                        case 1: //если 1, то присваем автобус
                        tc = TypeCar.Buss;
                        break;
                        case 2: //если 1, то присваем спорт кар
                        tc = TypeCar.Sport;
                        break;
                        default: //если какое-то иное значение, то присваем тип notcar
                        tc = TypeCar.NotCar;
                        break;
                    }
                    Console.WriteLine($"Вместимость бензобака для машины номер {i+1}");
                    Vb = Convert.ToDouble(Console.ReadLine()); //пользователь вводит вместимость 1 бензобака
                    if(Vb<=0) //если вместимость 0 или меньше, то кидаем эксепшн, если больше 0, то продолжаем
                    {
                        throw new Exception("Вы ошиблись. Начните заново");
                         throw new NotImplementedException();
                    }
                    if(tc==TypeCar.Buss) //если у машины тип автобус, то просим внести сколько бензобаков в ней
                    {
                        Console.WriteLine($"Сколько бензобаков в машине под номером {i+1}");
                        kb = Convert.ToInt32(Console.ReadLine()); // пользователь вводит сколько бензобаков в машине
                        if(kb<=0){ //если меньше 0 или 0, то кидаем эксепшн
                            throw new Exception("Вы ошиблись. Начните заново");
                            throw new NotImplementedException();
                        }
                    }
                    Console.WriteLine($"Стоимость одного литра бензина для машины {i+1}"); 
                    slb = Convert.ToInt32(Console.ReadLine()); //пользователь вводит цену за 1 литр бензина 
                    if(slb<=0) //если цена 0 или меньше, то кидаем экспешн
                    {
                         throw new Exception("Вы ошиблись. Начните заново");
                          throw new NotImplementedException();
                    }
                    Console.WriteLine($"Средний расход бензина на 1км для машины {i+1}");
                    rb = Convert.ToDouble(Console.ReadLine()); //пользователь вводит расход бензина на 1км
                    if(rb<=0){ //если расход 0 или меньше 0, то кидаем экспешн
                        throw new Exception("Вы ошиблись. Начните заново");
                         throw new NotImplementedException();
                    }
                    if(tc == TypeCar.Buss) //если тип машины автобус, то делаем следующее
                    {
                        Bus _bus = new Bus(tc,kb,rb,slb, Vb); //создаём новый обект класса Bus с параметрами, которые присвоили во время цикл 
                        array[i] = _bus; //присваиваем ячейке объект, который создали
                    }
                    else{ //если тип машины не Bus, то делаем следующее
                        SportCar _sprotcar = new SportCar(tc,kb,rb,slb,Vb); //создаём новый обект класса SprotCar с параметрами, которые присвоили во время цикл 
                        array[i] = _sprotcar;  //присваиваем ячейке объект, который создали
                    }
                }
            }
            Console.WriteLine("Весь список транспортных средств");
            for(int i = 0; i < array.Length;i++){
                array[i].PrintInfo();
            } 
        }
    }
}

