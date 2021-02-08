using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternVehicle
{
    static class VehicleFactory
    {

        public static IVehicle GetVehicle (int wheelCount)
        {
            switch (wheelCount)
            {
                case 2:
                    return new Motocycle();
                case 3:
                    return new Tuktuk();
                case 4:
                    return new Car();
                default:
                    return new Car();
            }
        }
    }
}
