using HomeworkClas2Task2.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClas2Task2.Entities
{
    public class RepairService : IRepairService
    {
        public void CheckVehicle(Vehicle vehicle)
        {
            Console.WriteLine($"Checking {vehicle.model} for issues");
        }

        public void FixVehicle(Vehicle vehicle)
        {
            Console.WriteLine($"Fixing issues for {vehicle.model}");
        }
    }
}
