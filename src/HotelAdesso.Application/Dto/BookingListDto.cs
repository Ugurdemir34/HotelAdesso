using HotelAdesso.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdesso.Application.Dto
{
    public class BookingListDto : BaseEntityDto
    {
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public Guid HotelId { get; set; }
        public Guid GuestId { get; set; }
        public string HotelName { get; set; }
        public string GuestName { get; set; }
    }
}
