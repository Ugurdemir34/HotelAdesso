using HotelAdesso.Persistence.Context;
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

        }
    }
}
