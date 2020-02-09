using Microsoft.Extensions.DependencyInjection;
using ProjectManager.Application.Interfaces.Core;
using ProjectManager.Application.Services.Core;
using ProjectManager.Domain.Interfaces;
using ProjectManager.Domain.Interfaces.Core;
using ProjectManager.Infrastructure.Context;
using ProjectManager.Infrastructure.Repository.Core;
using ProjectManager.Infrastructure.UoW;

namespace ProjectManager.Infrastructure.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            #region Application

            services.AddScoped<IAccountAppService, AccountAppService>();

            #endregion Application

            #region Infrastructure

            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ProjectManagerContext>();

            #endregion Infrastructure

            return services;
        }
    }
}