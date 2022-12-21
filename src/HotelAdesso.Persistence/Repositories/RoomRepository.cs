using HotelAdesso.Application.Dto;
using HotelAdesso.Application.Interfaces.Repositories;
using HotelAdesso.Application.Wrappers.Abstract;
using HotelAdesso.Application.Wrappers.Concrete;
using HotelAdesso.Domain.Entities;
using HotelAdesso.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdesso.Persistence.Repositories
{
    public class RoomRepository : Repository<Room>, IRoomRepository
    {
        private EFContext _context;
        public RoomRepository(EFContext context) : base(context)
        {
            _context = context;
        }

        public IDataResult<List<RoomListDto>> GetAllRoom()
        {
            var roomList = _context.Rooms.Select(room => new RoomListDto
            {
                CreatedDate = room.CreatedDate,
                Description = room.Description,
                Floor = room.Floor,
                Id = room.Id,
                ModifiedDate = room.ModifiedDate,
                Price = room.Price,
                HotelName = room.Hotel.Name,
                RoomStatusDescription = room.RoomStatus.Description,
                RoomTypeDescription = room.RoomType.Description,
            }).ToList();
            return new SuccessDataResult<List<RoomListDto>>(roomList, "asd");
        }
    }
}
