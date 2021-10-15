using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamGM.CROSSCUTTING.UnitOfWork;
using TeamGM.DATA.UnitOfWork;

namespace TeamGMAPI.Configuration
{
    public static class IoCConfig
    {
        public static IServiceCollection AddTeamGmService(this IServiceCollection services)
        {
            services.AddRepositoryService();

            return services;
        }


        private static IServiceCollection AddRepositoryService(this IServiceCollection service)
        {
            service.AddScoped<IDapperUnitOfWork, DapperUnitOfWork>();
            service.AddScoped<DbSession>();

            return service;
        }
    }
}
