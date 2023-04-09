using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClass3.Entities
{
    static class Validator
    {
        public static void Validate(Vehicle vehicle)
        {
            if (vehicle.Id == 0 || string.IsNullOrEmpty(vehicle.Type) || vehicle.YearsOfProduction == 0)
            {
                Console.WriteLine($"Invalid vehicle: {vehicle.Id} {vehicle.Type} {vehicle.YearsOfProduction}");
            }
            else
            {
                Console.WriteLine($"Valid vehicle: {vehicle.Id} {vehicle.Type} {vehicle.YearsOfProduction}");
            }
        }
    }
}
