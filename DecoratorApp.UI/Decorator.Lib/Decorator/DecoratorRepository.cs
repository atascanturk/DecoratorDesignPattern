using Decorator.Lib.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Lib.Decorator
{
    //Decorator
    public class DecoratorRepository<T> : IRepository<T>
        where T: class
    {
        private readonly IRepository<T> _repository;

        public DecoratorRepository(IRepository<T> repository)
        {
            _repository = repository;
        }

        public virtual void Add(T model)
        {
            _repository.Add(model);
        }

        public virtual void Delete(T model)
        {
            _repository.Delete(model);
        }

        public virtual List<T> GetAll()
        {
          return _repository.GetAll();
          
        }

        public virtual T GetById(int id)
        {
            return _repository.GetById(id);
        }

        public virtual void Update(T model)
        {
            _repository.Update(model);
        }
    }
}
