using DevBoost.JWT.Contract;
using DevBoost.JWT.Model;
using DevBoost.JWT.Service;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevBoost.JWT.IoC
{
    public static class Container
    {
        public static  IServiceCollection  AddCustomServices(this IServiceCollection services)
        {

            services.AddRepository();
            services.AddServices();
            return services;

        }
        private static void AddRepository(this IServiceCollection services)
        {

            services.AddTransient<IUserRepository, UserRepository>();
        }

        private static void AddServices(this IServiceCollection services)
        {
            services.AddSingleton<JwtSettings>();
            services.AddTransient<ITokenService, TokenService>();
            services.AddTransient<IUserService, UserService>();
        }
    }
}
