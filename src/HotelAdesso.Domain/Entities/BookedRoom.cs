using HotelAdesso.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdesso.Domain.Entities
{
    public class BookedRoom : BaseEntity
    {
        public Guid BookingId { get; set; }
        public Guid RoomId { get; set; }
        public virtual Booking Booking { get; set; }
        public virtual Room Room { get; set; }
    }
}
