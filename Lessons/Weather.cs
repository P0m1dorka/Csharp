using System;

namespace Lessons
{
    public class Weather
    {
        public void Holod(){ //метод для холодной погоды
            Console.WriteLine("Одевайтесь теплее)");
        }
        public void Rain(){ //метод для дождя
            Console.WriteLine("Возьмите зонт");
        }
        public void Hot(){ //метод для жары
            Console.WriteLine("не забывайте головной убор");
        }
    }
}
