using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SistemaInventario.Infraestructure.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Infraestructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<UserAppDbContext>(options => {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")/*, b => b.MigrationsAssembly("SistemaInventario.API")*/).EnableSensitiveDataLogging();
            });

            //services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
