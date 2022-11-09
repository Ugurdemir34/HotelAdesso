using HotelAdesso.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdesso.Domain.Entities
{
    public class Booking : BaseEntity
    {
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public Guid HotelId { get; set; }
        public Guid GuestId { get; set; }
        public virtual Hotel Hotel { get; set; }
        public virtual Guest Guest { get; set; }
    }
}
