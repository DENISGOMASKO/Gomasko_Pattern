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
            Console.ReadKey();
        }
    }
}

