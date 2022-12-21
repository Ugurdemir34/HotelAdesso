using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdesso.Application.Dto
{
    public class BookedRoomDto : BaseEntityDto
    {
        public Guid BookingId { get; set; }
        public Guid RoomId { get; set; }
    }
}
