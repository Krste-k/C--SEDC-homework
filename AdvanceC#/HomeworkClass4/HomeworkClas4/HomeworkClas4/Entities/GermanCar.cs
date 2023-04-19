using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClas4.Entities
{
    class GermanCar : BaseEntity
    {
        public override void Drive(string destinationName)
        {
            Console.WriteLine($"Driving to {destinationName} in a {Brand} {Model} (Japanese Car)");
        }
    }
}
