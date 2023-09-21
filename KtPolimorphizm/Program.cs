// See https://aka.ms/new-console-template for more information
using KtPolimorphizm;
Random rnd = new Random();
Property[] mass = new Property[10];
for(int i = 0; i < mass.Length; i++)
{
    switch (i)
    {
        case <3:
            mass[i] = new Appartament(rnd.Next(25,100), rnd.Next(50,400) , "Appartment");
            break;
        case <5:
            mass[i] = new Car(rnd.Next(35,50), rnd.Next(50,300), "Car");
            break;
        case <8:
            mass[i] = new Boat(rnd.Next(100,200), rnd.Next(300,1000), "Boat");
            break;
        default:
            mass[i] = new CountryHouse(rnd.Next(100,500), rnd.Next(400,1500), "CounryHouse");
            break;
    } 
}

foreach (Property prop in mass)
{
    Console.WriteLine(prop.ToString());
}