using AutoMapper;
using HotelAdesso.Application.Dto;
using HotelAdesso.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdesso.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<HotelDto, Hotel>();
            CreateMap<GuestDto, Guest>();
            CreateMap<RoomDto, Room>();
            CreateMap<RoomTypeDto, RoomType>();
            CreateMap<RoomStatusDto, RoomStatus>();
            CreateMap<BookingDto, Booking>();
        }
    }
}
