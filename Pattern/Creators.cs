using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    abstract class ICreator
    {
        protected List<IParking> _parkings = new List<IParking>{};

        //public abstract IParking CreateParking(typplacement_types tp_t, protection_types p_t, cover_types c_t);
        public abstract IParking CreateParking(typplacement_types tp_t, protection_types p_t, cover_types c_t);
        public abstract IParking CreateParking(typplacement_types tp_t);
        public abstract IParking CreateParking();
        public abstract ICar CreateCar();
        public abstract ICar CreateCar(IParking parking);       
        public void Log()
        {
            Console.WriteLine($"{this} работает с {this.CreateCar()} и размещает на {this.CreateParking()}");
        }
        public string StatsOfParkings()
        {
            string str = "";
            foreach (var i in _parkings)
            {
                str += i.InfOfParking() + '\n';
            }
            return "\n\n" + this.ToString() + '\n' + _parkings.Count.ToString() + '\n' + str;
        }
    }

    class SportCarCreator : ICreator
    {

        public override IParking CreateParking(typplacement_types tp_t)
        {
            SportCarParking parking = new SportCarParking(tp_t);
            _parkings.Add(parking);
            return parking;
        }
        public override IParking CreateParking()
        {
            return new SportCarParking();
        }
        public override IParking CreateParking(typplacement_types tp_t, protection_types p_t, cover_types c_t) { return null; }
        public override ICar CreateCar()
        {
            return new SportCar();
        }
        public override ICar CreateCar(IParking parking)
        {
            return parking.CreateCar();
        }
    }

    class BaseCarCreator : ICreator 
    {
        public override IParking CreateParking(typplacement_types tp_t, protection_types p_t, cover_types c_t)
        {
            BaseCarParking parking = new BaseCarParking(tp_t, p_t, c_t);
            _parkings.Add(parking);
            return parking;
        }
        public override IParking CreateParking()
        {
            return new SportCarParking();
        }
        public override IParking CreateParking(typplacement_types tp_t) { return null; }
        public override ICar CreateCar()
        {
            return new BaseCar();
        }
        public override ICar CreateCar(IParking parking)
        {
            return parking.CreateCar();
        }
    }
}
