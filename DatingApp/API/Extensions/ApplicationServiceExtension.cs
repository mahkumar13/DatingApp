﻿using API.Data;
using API.Interfaces;
using API.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Extensions
{
    public static  class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services,IConfiguration config)
        {
            services.AddScoped<ITokenService, TokenService>();

            services.AddDbContext<DataContext>(option =>
            {
                option.UseSqlite(config.GetConnectionString("DefaultConnection"));
            }
            );
            return services;
        }
    }
}
