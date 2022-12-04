using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdesso.Application.Dto
{
    public class RoomTypeDto : BaseEntityDto
    {
        public string Description { get; set; }
        public double AdditionalPriceRatio { get; set; }

    }
}
