using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdesso.Application.Dto
{
    public class BookingDto : BaseEntityDto
    {
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public Guid HotelId { get; set; }
        public Guid GuestId { get; set; }
    }
}
