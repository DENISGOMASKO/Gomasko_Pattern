using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    abstract class ICrator
    {
        protected List<IParcing> _parkings = new List<IParcing>{};

        public abstract IParcing CreateParking();
        public abstract ICar CreateCar();
        public abstract ICar CreateCar(IParcing parking);       
        public void Log()
        {
            Console.WriteLine($"{this} работает с {this.CreateCar()}");
        }
    }

    class SportCarCreator : ICrator
    {
        public override IParcing CreateParking()
        {
            SportCarParking parking = new SportCarParking();
            _parkings.Add(parking);
            return parking;
        }
        public override ICar CreateCar()
        {
            return new SportCar();
        }
        public override ICar CreateCar(IParcing parking)
        {
            return new SportCar();
        }
    }

    class BaseCarCreator : ICrator //TODO реализуй методы
    {
        public override ICar CreateCar()
        {
            return new BaseCar();
        }
    }
}
