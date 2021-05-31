using Decorator.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.DataAccess.Concrete
{
    public class Repository<T> : IRepository<T>
        where T : class
    {
        public void Add(T model)
        {
            Console.WriteLine($"{model} Added.");
        }

        public void Delete(T model)
        {
            Console.WriteLine($"{model} Deleted.");
        }

        public T GetById(int id)
        {
            Console.WriteLine("Data has been taken by id.");
            return null;
        }

        public List<T> GetAll()
        {
            Console.WriteLine("Datas listed.");
            return null;
        }

        public void Update(T model)
        {
            Console.WriteLine($"{model} Updated.");
          
        }
    }
}
