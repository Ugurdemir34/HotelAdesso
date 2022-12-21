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
    public class BookedRoomRepository : Repository<BookedRoom>, IBookedRoomRepository
    {
        private EFContext _context;
        public BookedRoomRepository(EFContext context) : base(context)
        {
            _context = context;
        }

        public IDataResult<List<BookedRoomListDto>> getAllBookedRooms()
        {
            var bookedRoomList = _context.BookedRooms.Select(br => new BookedRoomListDto
            {
                CreatedDate = br.CreatedDate,
                Id = br.Id,
                ModifiedDate = br.ModifiedDate,
                HotelName = br.Room.Hotel.Name,
                RoomPrice = br.Room.Price,
                RoomStatus = br.Room.RoomStatus.Description,
                RoomTitle = br.Room.Description
            }).ToList();
            return new SuccessDataResult<List<BookedRoomListDto>>(bookedRoomList, this._messages.SuccessList);
        }
    }
}
