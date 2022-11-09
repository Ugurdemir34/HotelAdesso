using HotelAdesso.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdesso.Domain.Interfaces
{
    public  interface IRepository<T> where T: BaseEntity
    {
        T Add(T entity);
        T Update(T entity);
        bool Delete(T entity);
        T Get(Expression<Func<T, bool>> expression);
        List<T> GetList(Expression<Func<T, bool>> expression);      
    }
}
