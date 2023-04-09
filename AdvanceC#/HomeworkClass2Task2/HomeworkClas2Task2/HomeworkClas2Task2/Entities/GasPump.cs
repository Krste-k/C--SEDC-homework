using HomeworkClas2Task2.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClas2Task2.Entities
{
    public class GasPump : IGasPump
    {
        public void PumpGas(Vehicle vehicle)
        {
            Console.WriteLine($"Pumping gas for {vehicle.model}");
        }
    }
}
