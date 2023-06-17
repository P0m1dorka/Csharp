using System;
namespace testDrink
{
    public class Beverage
    {
        private double _maxLiquid;
        private double _weight;// _weight = fake + norm
        private double _fakeweight;
        private double _normweight;
        private List<Liquid> liquids;
        public Beverage(double _maxLiquid) 
        {
            this._maxLiquid=_maxLiquid;
            liquids = new List<Liquid>();
        }
        public void AddLiquid( Liquid liq)
        {
           bool _have =false;
           //добавляет в лист жидкость, если ее там не было до ээтого, если была, то добавляет к ее весу => вызывается метод для перерасчета веса
           for(int i = 0; i < this.liquids.Count;i++)
           {
                if(liq._typeDrink == this.liquids[i]._typeDrink)
                {
                   _have = true;
                   liquids[i]._weight += liq._weight;
                   break; 
                }
           }
           if(!_have)
           {
             liquids.Add(liq);
           }
           liquids.Sort((x,y) =>
            x._typeDrink.CompareTo(y._typeDrink));
           Reweight();
        }
        private void Reweight ()
        {
            double summ = 0;
            double summfake = 0;
            // проход по листу и перерасчет веса паленки и норм веса
            foreach(Liquid liq in liquids)
            {
                if(liq._fake){
                    summfake += liq._weight;
                }
                else{
                    summ += liq._weight;
                }
            }
            _normweight = summ;
            _fakeweight = summfake;
            _weight = _fakeweight + _normweight;
        }
        // мб разлить метод
        private static bool Compare(Beverage first, Beverage second, double x, double y)
        {
            //x - погрешность для всего напитка 
            // y - погрежность для жидкости отдельной (отдельно пиво и прочее)
        // метод сравнения 
        // сраврение по кол-ву веса(общего), потом проход по листу +-X веса (X к примеру 10)
            if(first.liquids.Count != second.liquids.Count)
            {
                return false;
            }
            first.liquids.Sort((x,y) =>
            x._typeDrink.CompareTo(y._typeDrink));
            second.liquids.Sort((x,y) =>
            x._typeDrink.CompareTo(y._typeDrink));
            if(first._weight - second._weight < x)
            {
                for(int i = 0; i < first.liquids.Count;i++)
                {
                    if(first.liquids[i]._weight - second.liquids[i]._weight >=y)
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;        
        }   
        private void SortBeverage()
        {
           liquids.Sort((x,y) =>
            x._typeDrink.CompareTo(y._typeDrink)); 
            
        }
        /*
        public void PrintInfo()
        {
            Console.WriteLine("Напиток и его состав:");
            for (int i = 0; i < _alcoholType.Count; i++)
            {
                Console.Write($"{_alcoholType[i]}," + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Палёный алкоголь:");
            for (int i = 0; i < _achoholFake.Count; i++)
            {
                Console.Write($"{_achoholFake[i]}" + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Максимальное количество жидкости в напитке: {this._maxLiquid}");
            Console.WriteLine($"Жидкости в напитке сейчас: {this._weight}");
        } */
    }
}
