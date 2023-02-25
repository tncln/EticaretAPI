﻿using EticaretAPI.Application.Abstractions;
using EticaretAPI.Persistence.Concretes;
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
            services.AddSingleton<IProductService, ProductService>();
        }
    }
}
