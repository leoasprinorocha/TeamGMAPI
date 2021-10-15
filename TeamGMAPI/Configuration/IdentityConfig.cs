using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamGM.DOMAIN.ViewModels;
using TeamGMAPI.Data;

namespace TeamGMAPI.Configuration
{
    public static class IdentityConfig
    {
        public static IServiceCollection AddIdentityConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            options.UseOracle(configuration.GetConnectionString("TeamGmDbConnection")));

            services.AddIdentity<IdentityUser, IdentityRole>()
               .AddEntityFrameworkStores<AppDbContext>()
               .AddDefaultTokenProviders();

            return services;
        }
    }
}
