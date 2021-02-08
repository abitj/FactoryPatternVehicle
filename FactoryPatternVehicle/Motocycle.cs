using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternVehicle
{
    class Motocycle : IVehicle
    {

        public Motocycle()
        {

        }
        public void Drive()
        {
            Console.WriteLine();
            Console.WriteLine("Oops! This motorcyle, its engine makes nosie");
            Console.WriteLine("------------------------------------------------");
        }
    }
}
