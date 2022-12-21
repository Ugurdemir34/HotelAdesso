using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdesso.Application.Dto
{
    public class BookedRoomListDto:BaseEntityDto
    {
        public Guid BookingId { get; set; }
        public Guid RoomId { get; set; }
        public string RoomTitle { get; set; }
        public string RoomStatus { get; set; }
        public double RoomPrice { get; set; }
        public string HotelName { get; set; }
    }
}
