using HotelAdesso.Domain.Entities;
using HotelAdesso.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdesso.Infrastructure.Data.Repositories
{
    public class HotelRepository: RepositoryBase<Hotel>,IHotelRepository
    {
        public HotelRepository(EFContext dbContext):base(dbContext)
        {

        }
    }
}
