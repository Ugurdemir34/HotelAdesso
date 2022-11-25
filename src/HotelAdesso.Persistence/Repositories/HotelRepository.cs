using HotelAdesso.Application.Interfaces.Repositories;
using HotelAdesso.Domain.Entities;
using HotelAdesso.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdesso.Persistence.Repositories
{
    public class HotelRepository : Repository<Hotel>,IHotelRepository
    {
        public HotelRepository(EFContext context) : base(context)
        {
        }
    }
}
