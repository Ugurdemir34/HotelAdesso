using HotelAdesso.Application.Wrappers;
using HotelAdesso.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdesso.Application.Interfaces.Repositories
{
    public interface IRepository<T> where T:BaseEntity,new()
    {
        T Add(T entity);
        Task<T> AddAsync(T entity);
        List<T> List(Expression<Func<T, bool>> filter);
        Task<List<T>> ListAsync(Expression<Func<T, bool>> filter);
    }
}
