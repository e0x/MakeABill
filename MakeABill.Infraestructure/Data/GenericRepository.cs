
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MakeABill.Application.Interfaces;
using MakeABill.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;

namespace MakeABill.Infraestructure.Data
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private MakeABillApiDbContext _context;
        private DbSet<T> _entities;
        public GenericRepository(MakeABillApiDbContext context)
        {
            _entities = _context.Set<T>();
            _context = context;

        }

        public Task Delete(Guid id)
        {
            T entitty = _entities.Find(id);
            _context.Entry(entitty).State = EntityState.Modified;
            return Task.CompletedTask;

        }

        public async Task<T> Find(Expression<Func<T, bool>> Predicate)
        {

   
            return await _entities.Where(Predicate).FirstOrDefaultAsync();


        }

        public async Task<List<T>> GetAll()
        {
            return await _entities.AsNoTracking().ToListAsync();
        }

        public async Task<T> GetById(object Id)
        {
            return await _context.Set<T>().FindAsync(Id).AsTask();


        }

        public async Task<T> Insert(T obj)
        {

            await _context.Set<T>().AddAsync(obj);
            return obj;

        }

        public async Task<bool> SaveAsync()
        {
            if (await _context.SaveChangesAsync() > 0)

                return true;
            else

                return false;

        }

        public async Task<T> Update(T obj)
        {
            await Task.Run(() => _context.Entry(obj).CurrentValues.SetValues(obj));
            _context.Entry(obj).State = EntityState.Modified;
            return Task.FromResult(obj).Result;


        }
    }
}
