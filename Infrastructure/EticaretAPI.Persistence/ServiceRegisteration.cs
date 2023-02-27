using Microsoft.EntityFrameworkCore;
using EticaretAPI.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretAPI.Persistence
{
    public static class ServiceRegisteration
    {
        //API da yer alan IOC eklemek için kullanılır. 
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<EticaretAPIDbContext>(options => options.UseNpgsql("User ID=postgres;Password=postgrespw;Host=localhost;Port=32768;Database=EticaretAPI"));
        }
    }
}
