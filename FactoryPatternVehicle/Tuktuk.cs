using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternVehicle
{
    class Tuktuk : IVehicle    
    {
        public Tuktuk()
        { 
        }
            public void Drive ()
        {
            Console.WriteLine();
            Console.WriteLine("Wow! Tuktuk. This tuktuk drives slow!");
            Console.WriteLine("---------------------------------------------");
        }
            

    }
}
