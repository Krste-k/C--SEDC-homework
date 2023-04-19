using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClas4.Entities
{
    public class AmericanCar : BaseEntity
    {
        public override void Drive(string destinationName)
        {
            Console.WriteLine($"Driving to {destinationName} in a {Brand} {Model} (Japanese Car)");
        }

        internal override Car Print()
        {
            Console.WriteLine();
        }
    }
}
