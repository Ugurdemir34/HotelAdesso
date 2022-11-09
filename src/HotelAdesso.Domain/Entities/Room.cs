using HotelAdesso.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdesso.Domain.Entities
{
    public class Room : BaseEntity
    {
        public int Floor { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public Guid RoomStatusId { get; set; }
        public Guid RoomTypeId { get; set; }
        public Guid HotelId { get; set; }
        public virtual RoomStatus RoomStatus { get; set; }
        public virtual RoomType RoomType { get; set; }
        public virtual Hotel Hotel { get; set; }
    }
}
