using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelAdesso.Application.Wrappers.Abstract;

namespace HotelAdesso.Application.Wrappers.Concrete
{
    public class Result : IResult
    {
        public Result(bool isSuccess, string message)
        {
            IsSuccess = isSuccess;
            Message = message;
        }
        public bool IsSuccess { get; }

        public string Message { get; }
    }
}
