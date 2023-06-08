using System;

namespace Lessons
{
    public class LightCar : ACar
    {
        
        private string _name;
        private int _nomer;
        
        private TypeCar _type;
        private bool _needwash;
        public LightCar(string name, int nomer, TypeCar type,bool needwash)
        {
            this._name = name;
            this._nomer = nomer;
            this._type = type;
            this._needwash = needwash;
        }
    }
}
