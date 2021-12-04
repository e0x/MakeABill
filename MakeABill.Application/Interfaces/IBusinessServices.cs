using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MakeABill.Application.Interfaces
{

    public interface IBusinessService<T>
    {
        Task<T> Find(Expression<Func<T, bool>> Predicate);
        Task<List<T>> GetAll();

        Task<T> GetById(object Id);

        Task<T> Insert(T obj);

        Task<T> Update(T obj);
        Task Delete(Guid id);

    }
}
