using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern
{
    enum typplacement_types
    {
        Parallel,
        Diagonally,
        Perpendicular
    }
    enum protection_types
    {
        Guarded,
        NotGuarded
    } 
    enum cover_types
    {
        Covered,
        Open
    }
    abstract class IParking
    {
        //protected int _number_of_parking_spaces;
        //protected string _address;

        protected typplacement_types _typplacement_type;
        protected protection_types _protection_type;
        protected cover_types _cover_type;
        protected List<ICar> _cars = new List<ICar> { };

        public abstract ICar CreateCar();
        public string StatOfCars()
        {
            string str = "";
            foreach (var i in _cars)
            {
                str += i.InfOfCar() + ' ';
            }
            return "\n\n" + this.InfOfParking() + '\n' + _cars.Count.ToString() + '\n' + str;
        }
        public string InfOfParking()
        {
            return this.ToString() + " (" + _typplacement_type.ToString() + ' ' + _protection_type.ToString() + ' ' + _cover_type.ToString() + ')';
        }
    }

    class SportCarParking : IParking
    {
        public SportCarParking(typplacement_types tp_t, protection_types p_t = protection_types.Guarded, cover_types c_t = cover_types.Covered)
        {
            _typplacement_type = tp_t;
            _protection_type = p_t;
            _cover_type = c_t;
        }
        public SportCarParking() {;}
        public override ICar CreateCar()
        {
            SportCar car = new SportCar();
            _cars.Add(car);
            return car;
        }
    }

    class BaseCarParking : IParking
    {
        public BaseCarParking(typplacement_types tp_t, protection_types p_t, cover_types c_t)
        {
            _typplacement_type = tp_t;
            _protection_type = p_t;
            _cover_type = c_t;
        }
        public BaseCarParking() {;}
        public override ICar CreateCar()
        {
            BaseCar car = new BaseCar();
            _cars.Add(car);
            return car;
        }
    }
}
