using System;

namespace Lessons
{
    public class FuelTank
    {
        public double Vb;
        public virtual void PrintInfo(){
            Console.WriteLine("Базовый метод");
        }
    }
}
