using EticaretAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretAPI.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<EticaretAPIDbContext>
    {
        public EticaretAPIDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<EticaretAPIDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseNpgsql(Configuration.ConnectionString); 
            return new EticaretAPIDbContext(dbContextOptionsBuilder.Options);
        }
    }
}
