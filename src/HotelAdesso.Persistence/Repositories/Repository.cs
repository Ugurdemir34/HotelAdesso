using HotelAdesso.Application.Interfaces.Repositories;
using HotelAdesso.Application.Wrappers;
using HotelAdesso.Domain.Base;
using HotelAdesso.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdesso.Persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity, new()
    {
        private readonly EFContext _context;
        public Repository(EFContext context)
        {
            _context = context;
        }
        private DbSet<T> Table { get => _context.Set<T>(); }

        public T Add(T entity)
        {
            Table.Add(entity);
            return entity;
        }

        public async Task<T> AddAsync(T entity)
        {
            await Table.AddAsync(entity);
            return await Task.FromResult<T>(entity);
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return Table.Where(filter).ToList();
        }

        public async Task<List<T>> ListAsync(Expression<Func<T, bool>> filter)
        {
            var result = await Table.Where(filter).ToListAsync();
            return await Task.FromResult(result);
        }
    }
}
