using HotelAdesso.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdesso.Domain.Entities
{
    public class RoomType : BaseEntity
    {
        public string Description { get; set; }
        public double AdditionalPriceRatio { get; set; }       
    }
}
