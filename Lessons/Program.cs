using Lessons;


WashPlace ws = new WashPlace();
Test ts = new (ws.Wash);
ts();
Console.WriteLine("Сколько всего было машин?");
int _razmer = Convert.ToInt32(Console.ReadLine());
ACar[] _cars = new ACar[_razmer];
List<LightCar> _lcar = new List<LightCar>{};
List<HardCar> _hcar = new List<HardCar>{};
for(int i = 0; i < _cars.Length;i++){
    Console.WriteLine("Какой тип у машины (light/weight)");
    string type = Console.ReadLine();
    if(type == "light")
    {
        Console.WriteLine("");
    }
    else if (type == "weight")
    {

    }
    else
    {
        throw new Exception("Нет такого типа машины");
    }
}
public delegate void Test();


