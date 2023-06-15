using System;

namespace Lessons
{
    public class Bus : FuelTank
    {
        private TypeCar type = TypeCar.Buss; //тип машины
        private int kb; //колво безобаков
        private double rb; //средний расход бензина на 1км
        private int slb; // стоимость одно литра бенщина
        public Bus(TypeCar _type, int _kb, double _rb, int _slb, double _vd) //конструктор объекта класса в который пользователь передаёт всю нужную информацию
        {
            this.type = _type;
            this.kb = _kb;
            this.rb = _rb;
            this.slb = _slb;
            this.Vb = _vd;
        }
        public override void PrintInfo()//выводит всю нужную информацию об объекте
        {
            Console.WriteLine();
            Console.WriteLine("_____________________________________________________________");
            Console.WriteLine($"\n Тип авто: {this.type}"); //берём у объекта его тип
            Console.WriteLine($"\n Средний пробег на всех полных бензобаках без дозаправки: {Math.Round((this.Vb * kb)/rb,0)}"); //выводим средний пробег. округление использую чтобы не было запредельных чисел
            Console.WriteLine($"\n Стоимость всех полных бензобаков: {(this.Vb*this.kb)*this.slb}"); //вывод цены за все полные баки
            Console.WriteLine("_____________________________________________________________");


        }
    }
}
