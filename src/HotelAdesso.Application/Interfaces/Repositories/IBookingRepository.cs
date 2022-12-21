using HotelAdesso.Application.Dto;
using HotelAdesso.Application.Wrappers.Abstract;
using HotelAdesso.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdesso.Application.Interfaces.Repositories
{
    public interface IBookingRepository : IRepository<Booking>
    {
        IDataResult<List<BookingListDto>> getAllBooking();

    }
}
