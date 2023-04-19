using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClas4.Entities
{
    class GenericDb<T> where T : BaseEntity
    {
        private List<T> _data = new List<T>();

        public void Insert(T entity)
        {
            _data.Add(entity);
        }

        public T GetById(int id)
        {
            return _data.FirstOrDefault(x => x.Id == id);
        }

        public void PrintAll()
        {
            foreach (T entity in _data)
            {
                entity.Drive("somewhere");
                if (entity is Car)
                {
                    (Car)entity.Print();
                }
            }
        }
    }

    public static class StringExtensions
    {
        public static string Colorize(this string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            string result = message;
            Console.ResetColor();
            return result;
        }
    }
}
  
