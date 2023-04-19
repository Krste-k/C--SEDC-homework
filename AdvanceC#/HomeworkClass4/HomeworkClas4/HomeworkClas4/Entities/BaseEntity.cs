using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClas4.Entities
{
    abstract class BaseEntity
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int MaxSpeed { get; set; }
        public int HorsePower { get; set; }
        public string FuelType { get; set; }

        public abstract void Drive(string destinationName);
        internal abstract Car Print();
    }
}
