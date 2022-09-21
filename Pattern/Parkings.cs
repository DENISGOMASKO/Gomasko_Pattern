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
    abstract class IParcing
    {
        protected int _number_of_parking_spaces;
        protected string _address;

        protected typplacement_types _typplacement_type;
        protected protection_types _protection_type;
        protected cover_types _cover_type;
        protected List<ICar> _cars = new List<ICar> { }; 
    }

    class SportCarParking : IParcing
    {
        public SportCarParking()
        {
            _protection_type = protection_types.Guarded;
            _cover_type = cover_types.Covered;
        }
    }

    class BaseCarParking : IParcing
    {
        public BaseCarParking
    }
}
