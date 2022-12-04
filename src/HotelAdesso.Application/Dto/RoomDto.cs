using HotelAdesso.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdesso.Application.Dto
{
    public class RoomDto:BaseEntityDto
    {
        public int Floor { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public Guid RoomStatusId { get; set; }
        public Guid RoomTypeId { get; set; }
        public Guid HotelId { get; set; }
    }
}
