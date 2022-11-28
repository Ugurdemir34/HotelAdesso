using HotelAdesso.Application.Interfaces.Repositories;
using HotelAdesso.Application.Messages;
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
        private readonly ResultMessages _messages;
        public Repository(EFContext context)
        {
            _messages = new ResultMessages(typeof(T).Name);
            _context = context;
        }
        private DbSet<T> Table { get => _context.Set<T>(); }

        public IDataResult<T> Add(T entity)
        {
            var addedResult = Table.Add(entity);
            if (addedResult !=null)
            {
                return new SuccessDataResult<T>(entity, _messages.SuccessAdded);
            }
            return new ErrorDataResult<T>(entity, _messages.ErrorAdded);
        }

        public Task<IDataResult<T>> AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<T>> List(Expression<Func<T, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<List<T>>> ListAsync(Expression<Func<T, bool>> filter)
        {
            throw new NotImplementedException();
        }

        //public T Add(T entity)
        //{
        //    Table.Add(entity);
        //    return entity;
        //}

        //public async Task<T> AddAsync(T entity)
        //{
        //    await Table.AddAsync(entity);
        //    return await Task.FromResult<T>(entity);
        //}

        //public List<T> List(Expression<Func<T, bool>> filter)
        //{
        //    return Table.Where(filter).ToList();
        //}

        //public async Task<List<T>> ListAsync(Expression<Func<T, bool>> filter)
        //{
        //    var result = await Table.Where(filter).ToListAsync();
        //    return await Task.FromResult(result);
        //}
    }
}
