using MakeABill.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MakeABill.Application.Services
{
    
    public class BusinessServices<T> : IBusinessService<T> where T: class
    {
        protected readonly IGenericRepository<T> _repository;

        public BusinessServices(IGenericRepository<T> repository)
        {
            _repository = repository;
        }

        public Task Delete(Guid id)
        {
            return _repository.Delete(id);
        }

        public Task<T> Find(Expression<Func<T, bool>> Predicate)
        {
            return _repository.Find(Predicate);
        }

        public Task<List<T>> GetAll()
        {
            return _repository.GetAll();
        }

        public Task<T> GetById(object Id)
        {
            return _repository.GetById(Id);
        }

        public Task<T> Insert(T obj)
        {
            return _repository.Insert(obj);
        }

        public Task<T> Update(T obj)
        {
            return _repository.Update(obj);
        }
    }
}
