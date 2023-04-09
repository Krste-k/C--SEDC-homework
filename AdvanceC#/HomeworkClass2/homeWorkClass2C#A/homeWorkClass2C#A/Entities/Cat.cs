using homeWorkClass2C_A.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkClass2C_A.Entities
{
    public class Cat : Animal, ICat
    {
        public Cat(string name, int age) : base(name, age)
        {
        }

        public void Eat(string food)
        {
            Console.WriteLine($"{name} is eating {food}");
        }

        public override void PrintAnimal()
        {
            Console.WriteLine($"{name} is {age} years old");

        }
    }

}
