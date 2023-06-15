using System;
namespace testDrink
{
    public class Liquid // жидкость
    {
        public bool _fake;
        public TypeDrinks _typeDrink;
        public double _weight;
        public Liquid(bool fake, TypeDrinks typeDrink, double weight)
        {
            _fake = fake;
            _typeDrink = typeDrink;
            _weight = weight;
        }
    }
}
