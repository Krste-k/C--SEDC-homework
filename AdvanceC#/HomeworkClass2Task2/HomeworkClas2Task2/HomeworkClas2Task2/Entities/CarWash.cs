using HomeworkClas2Task2.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClas2Task2.Entities
{
    public class CarWash : ICarWash
    {
        public void WashCar(Car car)
        {
            Console.WriteLine($"Washing car {car.model}");
        }

        public void WashTrailer(Truck truck)
        {
            Console.WriteLine($"Washing truck {truck.model}");
        }
    }
}
