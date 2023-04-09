using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClass3.Entities
{
     class Bike : Vehicle
    {
        public string Color { get; set; }

        public override void PrintVehicle()
        {
            Console.WriteLine($"Bike Year of Production: {YearsOfProduction} \n Color: {Color}");
        }
    }
}
