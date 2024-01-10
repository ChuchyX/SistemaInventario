using Microsoft.Extensions.DependencyInjection;
using SistemaInventario.Application.Interfaces;
using SistemaInventario.Application.Mappings;
using SistemaInventario.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);
            services.AddScoped<IUserService, UserService>();
            return services;
        }
    }
}
