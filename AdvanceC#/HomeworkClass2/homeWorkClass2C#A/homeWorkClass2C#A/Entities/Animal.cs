using homeWorkClass2C_A.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkClass2C_A.Entities
{
    public abstract class Animal : IAnimal
    { 
       public string name { get; set; } 
        public int age { get; set; }

       public Animal(string name ,int age )
        {
         this.name = name;
            this.age = age;
        }

        public abstract void PrintAnimal();
    
    }
}
