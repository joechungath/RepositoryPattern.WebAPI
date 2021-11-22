using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EFCore
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly ApplicationContext _Context;

        public GenericRepository(ApplicationContext context)
        {
            this._Context = context;
        }
        public void Add(T entity)
        {
            _Context.Set<T>().Add(entity);
        }

        public void Addrange(IEnumerable<T> entities)
        {
            _Context.Set<T>().AddRange(entities);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return _Context.Set<T>().Where(expression);
        }

        public IEnumerable<T> GetAll()
        {
            return _Context.Set<T>().ToList();
        }

        public T GetByID(int Id)
        {
           return _Context.Set<T>().Find(Id);
        }

        public void Remove(T entity)
        {
            _Context.Set<T>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _Context.Set<T>().RemoveRange(entities);
        }
    }
}
