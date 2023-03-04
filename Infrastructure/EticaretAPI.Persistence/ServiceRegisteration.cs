using Microsoft.EntityFrameworkCore;
using EticaretAPI.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EticaretAPI.Application.Repositories;
using EticaretAPI.Persistence.Repositories;

namespace EticaretAPI.Persistence
{
    public static class ServiceRegisteration
    {
        //API da yer alan IOC eklemek için kullanılır. 
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<EticaretAPIDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));
            services.AddScoped<ICustomerReadRepository,CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
        }
    }
}
