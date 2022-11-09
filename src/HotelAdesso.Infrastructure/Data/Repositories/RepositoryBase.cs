using HotelAdesso.Domain.Base;
using HotelAdesso.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdesso.Infrastructure.Data.Repositories
{
    public class RepositoryBase<T> : IRepository<T> where T : BaseEntity
    {
        private readonly DbSet<T> _dbSet;
        public RepositoryBase(EFContext context)
        {
            _dbSet = context.Set<T>();
        }
        public T Add(T entity)
        {
            _dbSet.Add(entity);
            return entity;
        }

        public bool Delete(T entity)
        {
            //_dbSet.Remove(entity);
            return false;
        }

        public T Get(Expression<Func<T, bool>> expression)
        {
            return _dbSet.FirstOrDefault(expression);
        }

        public List<T> GetList(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Where(expression).ToList();
        }

        public T Update(T entity)
        {
            _dbSet.Update(entity);
            return entity;
        }
    }
}
