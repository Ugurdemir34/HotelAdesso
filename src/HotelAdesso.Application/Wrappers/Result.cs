using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdesso.Application.Wrappers
{
    public class Result : IResult
    {
        public Result(bool isSuccess,string message)
        {
            IsSuccess = IsSuccess;
            Message = message;
        }
        public bool IsSuccess { get; }

        public string Message { get; }
    }
}
