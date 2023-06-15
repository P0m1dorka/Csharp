using System;

namespace Lessons
{
    public class SportCar : FuelTank //класс спортивных машин
    {
        private TypeCar type = TypeCar.Sport; //тип машины
        private double rb; //средний расход бензина на 1 км
        private int slb; //стоимость одного литра бензина
        
        public SportCar(TypeCar _type, int _kb, double _rb, int _slb, double _vd) //конструктор объекта класса в который пользователь передаёт всю нужную информацию
        {
            this.type = _type;
            this.rb = _rb;
            this.slb = _slb;
            this.Vb = _vd;
        }
        public override void PrintInfo() //выводит всю нужную информацию об объекте
        {
            Console.WriteLine();
            Console.WriteLine("_____________________________________________________________");
            Console.WriteLine($"\n Тип авто: {this.type}"); //берём у объекта его тип
            Console.WriteLine($"\n Средний пробег на полном бензобаке без дозаправки: {Math.Round((this.Vb)/rb,0)}"); //выводим средний пробег. округление использую чтобы не было запредельных чисел
            Console.WriteLine($"\n Стоимость всех полных бензобаков: {(this.Vb)*this.slb}"); //вывод цены за все полные баки
            Console.WriteLine("_____________________________________________________________");
        }
    }
}
