using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using ProjectManager.Application.AutoMapper;
using System;

namespace ProjectManager.Api.Configurations
{
    public static class AutoMapperSetup
    {
        public static void AddAutoMapperSetup(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddAutoMapper(typeof(Startup));

            // Registering Mappings automatically only works if the
            // Automapper Profile classes are in ASP.NET project
            AutoMapperConfig.RegisterMappings();
        }
    }
}