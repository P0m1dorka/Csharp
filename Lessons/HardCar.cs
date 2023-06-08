using System;

namespace Lessons
{
    public class HardCar : ACar
    {
        private string _name;
        private int _nomer;
        private TypeCar _type;
        public HardCar(string name, int nomer, TypeCar type)
        {
            this._name = name;
            this._nomer = nomer;
            this._type = TypeCar.weight;
        }
    }
}
