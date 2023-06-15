/* 
ОСНОВНАЯ ИДЕЯ: 
ОБЪЕКТ класса Напиток может хранить в себе ЛИСТ из объектов другого класса( жидкость)
Классс напиток имеет ограничение по ёмкости, + есть поля, 
которые рассчитываются автоматически про изменении ЛИСТА с жидкостями, 
(кол-во паленого алкоголя, кол-во алкоголя в целом)
Класс напиток имеет поле для типа жидкости (енум)
кол-во жидкости в милилитрах булевая переменная (паленая или нет)
При обращении клиента с запросом создается объект класса Напиток со списком внутри,
, потом мы его будем сравнивать с нашим НАпитком (по листу(листы кстати хорошо бы сортировать по енуму)) 
и выдавать реакцию клиента на это
*/
/*
1) Beverage (напиток) - хранит в себе лист из объектов жидкости
поле с максимальным количеством жидкости
поле с количеством полёного алкоголя
поле с количеством алкоголя в целом (и что это за алкоголь)
2) Liquid (жидкость) 
поле с полёным алкоголем или нет 
поле с типом алкоголя
*/
namespace testDrink
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Start");
            Beverage _beverage;
            List<Liquid> _liquid = new List<Liquid>(1);
            Console.WriteLine("Сколько видов жидкостей?");
            Int32 types = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < types; j++)
            {
                TypeDrinks _typeDrink = TypeDrinks.vodka;
                Int32 test = rnd.Next(0, 10);
                bool pal = true;
                if (test <= 5)
                {
                    pal = true;
                }
                else
                {
                    pal = false;
                }
                Console.WriteLine("Сколько жидкости добавили?");
                double weight = Convert.ToDouble(Console.ReadLine());
                Liquid _object = new Liquid(pal, _typeDrink, weight);
                _liquid.Add(_object);
            }
            Beverage objectsss = new Beverage(_liquid, Convert.ToDouble(25));
            _beverage = objectsss;
            _beverage.PrintInfo();
        }
    }
}