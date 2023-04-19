using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClas4.Entities
{
    class Car : BaseEntity
    {
        public override void Drive(string destinationName)
        {
            Console.WriteLine($"Driving to {destinationName} in a {Brand} {Model}");
        }
        public virtual void Print()
        { 
          Console.WriteLine($"Id: {Id}, Brand: {Brand}, Model: {Model}, Max Speed: {MaxSpeed}, Horse Power: {HorsePower}, Fuel Type: {FuelType}");
        }

    }
}
