using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClass3.Entities
{
    public class Car : Vehicle
    {
        public int FurlTank { get; set; }   
        public List<string> Countries { get; set; } 

        public override void PrintVehicle()
        {
            Console.WriteLine($"Car Type: {Type} \n Produced in: {string.Join(", ", Countries)}");
        }
    }
}
