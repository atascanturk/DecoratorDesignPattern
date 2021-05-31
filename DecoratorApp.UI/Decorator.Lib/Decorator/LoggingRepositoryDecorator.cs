using Decorator.Lib.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Lib.Decorator
{
    //ConcreteDecorator
    public class LoggingRepositoryDecorator<T> : DecoratorRepository<T> where T : class
    {
        private readonly IRepository<T> _repository;

        public LoggingRepositoryDecorator(IRepository<T> repository) : base(repository)
        {
            _repository = repository;
        }

        public override void Add(T model)
        {
            Console.WriteLine($"LOG : {typeof(T).Name} is added.");
            base.Add(model);
        }

        public override void Delete(T model)
        {
            Console.WriteLine($"LOG : {typeof(T).Name} is deleted.");
            base.Delete(model);
        }

        public override List<T> GetAll()
        {
            Console.WriteLine($"LOG : {typeof(T).Name} is listed.");
            return base.GetAll();
        }

        public override T GetById(int id)
        {
            Console.WriteLine($"LOG : {typeof(T).Name} is shown.");
            return base.GetById(id);
        }

        public override void Update(T model)
        {
            Console.WriteLine($"LOG : {typeof(T).Name} is updated.");
            base.Update(model);
        }
    }
}
