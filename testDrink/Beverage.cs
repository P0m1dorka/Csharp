using System;

namespace testDrink
{
    public class Beverage
    {
        private double _maxLiquid;
        private double _weight;
        private List<bool> _achoholFake = new List<bool>(5);
        private List<TypeDrinks> _alcoholType = new List<TypeDrinks>(5);
        private string _buf;
        public Beverage(List<Liquid> drink, double _maxLiquid)
        {
            for (int i = 0; i < drink.Count; i++)
            {
                this._achoholFake.Add(true);
                this._alcoholType.Add(drink[i]._typeDrink);

                this._weight += drink[i]._weight;
            }
            this._maxLiquid = _maxLiquid;
        }
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
        }
    }
}
