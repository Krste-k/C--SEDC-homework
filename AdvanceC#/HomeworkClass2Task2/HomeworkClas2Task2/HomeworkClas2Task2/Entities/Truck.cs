using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClas2Task2.Entities
{
    public class Truck : Vehicle
    {
        public Truck(string model, int year) : base(model, year)
        {
        }

        public override void Drive()
        {
            Console.WriteLine($"Driving truck {model} from {year}");
        }
    }
}
