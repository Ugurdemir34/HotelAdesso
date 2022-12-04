using HotelAdesso.Application.Interfaces.Repositories;
using HotelAdesso.Application.UnitOfWork;
using HotelAdesso.Persistence.Context;
using HotelAdesso.Persistence.Repositories;
using HotelAdesso.Persistence.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdesso.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddServices(this IServiceCollection serviceCollection,IConfiguration configuration = null)
        {
            serviceCollection.AddDbContext<EFContext>(opt =>
            {
                opt.UseSqlServer("name=ConnectionStrings:HotelConnection");
            });
            using (var scope = serviceCollection.BuildServiceProvider().CreateScope())
            {
                var scopedProvider = scope.ServiceProvider;
                var efContext = scopedProvider.GetRequiredService<EFContext>();
                EFContextSeed.Seed(efContext);
            }
            serviceCollection.AddTransient<IHotelRepository, HotelRepository>();
            serviceCollection.AddTransient<IGuestRepository, GuestRepository>();
            serviceCollection.AddTransient<IRoomRepository, RoomRepository>();
            serviceCollection.AddTransient<IRoomTypeRepository, RoomTypeRepository>();
            serviceCollection.AddTransient<IRoomStatusRepository, RoomStatusRepository>();
            serviceCollection.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
