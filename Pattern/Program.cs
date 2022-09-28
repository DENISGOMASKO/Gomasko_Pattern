using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SportCarCreator sportCarCreator = new SportCarCreator();
            sportCarCreator.Log();
            BaseCarCreator baseCarCreator = new BaseCarCreator();
            baseCarCreator.Log();


            Console.WriteLine("\n\n//---------------------------\n");


            IParking TempParking0 = sportCarCreator.CreateParking(typplacement_types.Parallel);

            Console.WriteLine(sportCarCreator.StatsOfParkings());

            TempParking0.CreateCar();
            TempParking0.CreateCar();
            Console.WriteLine(TempParking0.StatOfCars());


            Console.WriteLine("\n\n//---------------------------\n");


            baseCarCreator.CreateParking(typplacement_types.Parallel, protection_types.NotGuarded, cover_types.Open);
            IParking TempParking1 = baseCarCreator.CreateParking(typplacement_types.Perpendicular, protection_types.Guarded, cover_types.Open);
            IParking TempParking2 = baseCarCreator.CreateParking(typplacement_types.Diagonally, protection_types.Guarded, cover_types.Covered);

            Console.WriteLine(baseCarCreator.StatsOfParkings());

            TempParking1.CreateCar();
            Console.WriteLine(TempParking1.StatOfCars());

            TempParking2.CreateCar();
            TempParking2.CreateCar();
            Console.WriteLine(TempParking2.StatOfCars());


            Console.WriteLine("\n\n//---------------------------\n");


            Console.ReadKey();
        }
    }
}

