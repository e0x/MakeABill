using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MakeABill.Application.Interfaces
{
    public interface IGenericRepository<T> where T: class
    {
        Task<T> Find(Expression<Func<T, bool>> Predicate);
        Task<List<T>> GetAll();

        Task<T> GetById(object Id);

        Task<T> Insert(T obj);

        Task<T> Update(T obj);
        Task Delete(Guid id);
        Task<bool> SaveAsync();
    }
}
