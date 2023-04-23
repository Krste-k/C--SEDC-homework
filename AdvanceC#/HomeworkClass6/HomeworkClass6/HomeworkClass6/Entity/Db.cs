using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClass6.Entity
{
    public static class Db
    {
        public static List<Person> Persons { get; set; } = new List<Person>();
        public static List<Dog> Dogs { get; set; } = new List<Dog>();
    }
}
