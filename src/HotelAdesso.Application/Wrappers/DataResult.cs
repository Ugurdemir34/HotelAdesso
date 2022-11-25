using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdesso.Application.Wrappers
{
    public class DataResult<T> : IDataResult<T>
    {
        public DataResult(T data,bool isSuccess,string message)
        {
            Data = data;
            IsSuccess = isSuccess;
            Message = message;
        }
        public DataResult(T data, bool isSuccess)
        {
            Data = data;
            IsSuccess = isSuccess;
        }
        public bool IsSuccess { get; }

        public string Message { get; }
        public T Data { get; }
    }
}
