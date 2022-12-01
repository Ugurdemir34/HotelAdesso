using HotelAdesso.Application.Wrappers.Abstract;
using HotelAdesso.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdesso.Application.Interfaces.Repositories
{
    public interface IRepository<T> where T : BaseEntity, new()
    {
        IDataResult<T> Add(T entity);
        IDataResult<List<T>> List(Expression<Func<T, bool>> filter=null);
        IResult Delete(Guid id);
        IDataResult<T> Update(T entity);
        #region Async
        Task<IDataResult<T>> AddAsync(T entity);
        Task<IDataResult<List<T>>> ListAsync(Expression<Func<T, bool>> filter = null); 
        #endregion

    }
}
