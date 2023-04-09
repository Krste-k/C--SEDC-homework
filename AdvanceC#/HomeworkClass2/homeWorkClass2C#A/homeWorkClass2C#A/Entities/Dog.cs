using homeWorkClass2C_A.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkClass2C_A.Entities
{
    public class Dog : Animal, IDog
    {
        public Dog(string name, int age) : base(name, age)
        {
            this.name = name;
            this.age = age;

        }

        public void DogBark()
        {
            Console.WriteLine($"Is Barking bark bark bark");
        }

        public override void PrintAnimal()
        {
            Console.WriteLine($"{name} is {age} years old");
        }
    
    
    }
}
