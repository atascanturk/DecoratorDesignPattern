using Decorator.Entities.Concrete;
using Decorator.Lib.Concrete;
using Decorator.Lib.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorApp.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Repository");
            Repository<User> repository = new Repository<User> ();
            repository.GetById(1);
            repository.GetAll();
            repository.Add(new User());
            repository.Delete(new User());
            repository.Update(new User());

            Console.WriteLine("\n****************");

            Console.WriteLine("\nLoggingRepositoryDecorator");
          
            LoggingRepositoryDecorator<User> loggingRepositoryDecorator = new LoggingRepositoryDecorator<User>(repository);
            loggingRepositoryDecorator.GetById(1);
            loggingRepositoryDecorator.GetAll();
            loggingRepositoryDecorator.Add(new User());
            loggingRepositoryDecorator.Delete(new User());
            loggingRepositoryDecorator.Update(new User());

            Console.ReadLine();
        }
    }
}
