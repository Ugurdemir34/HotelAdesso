using HotelAdesso.Application.Dto;
using HotelAdesso.Application.Interfaces.Repositories;
using HotelAdesso.Application.Messages;
using HotelAdesso.Application.Wrappers.Abstract;
using HotelAdesso.Application.Wrappers.Concrete;
using HotelAdesso.Domain.Entities;
using HotelAdesso.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdesso.Persistence.Repositories
{
    public class BookingRepository : Repository<Booking>, IBookingRepository
    {
        private EFContext _context;
        private ResultMessages _resultMessage;
        public BookingRepository(EFContext context, ResultMessages resultMessage) : base(context)
        {
            _context = context;
            _resultMessage = resultMessage;
        }
        public IDataResult<List<BookingListDto>> getAllBooking()
        {
            var bookingList = _context.Bookings.Select(booking => new BookingListDto
            {
                CreatedDate = booking.CreatedDate,
                Id = booking.Id,
                ModifiedDate = booking.ModifiedDate,
                HotelName = booking.Hotel.Name,
                GuestName = booking.Guest.FirstName + " " + booking.Guest.LastName
            }).ToList();
            return new SuccessDataResult<List<BookingListDto>>(bookingList, _resultMessage.SuccessList);
        }
    }
}
