using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClass3.Entities
{
    public class Vehicle
    { 
       public int Id { get; set; }
       public string Type { get; set; }
       public int YearsOfProduction { get; set; }   
       public string BatchNumber { get; set; }
         
        public virtual void PrintVehicle ()
        {
            Console.WriteLine($"Vehicle ID:{Id} \n Type {Type} \nYears of production {YearsOfProduction}");
        }
    }
}
