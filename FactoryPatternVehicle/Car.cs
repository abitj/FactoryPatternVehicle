using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternVehicle
{
    class Car : IVehicle
    {
        public Car()
        {
        }

        public void Drive()
        {
            Console.WriteLine();
            Console.WriteLine(" Holy Cow!, It's a car and it is driving, vroom!");
            Console.WriteLine("------------------------------------------------");
        }

     }
}
