using Confitec.RaphaelCampos.Api.Domain.Shared;
using Confitec.RaphaelCampos.Api.Persistence.Context;
using Confitec.RaphaelCampos.Api.Persistence.Interfaces.Repositories;
using Confitec.RaphaelCampos.Api.Persistence.Repositories;
using Confitec.RaphaelCampos.Api.Service.Interfaces.Services;
using Confitec.RaphaelCampos.Api.Service.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Confitec.RaphaelCampos.Api.Service.IoC
{
    public static class NativeInjectorConfig
    {
        public static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString(Constants.CONNECTION_STRING))
            );

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddTransient<ILogger>(s => s.GetRequiredService<ILogger<Program>>());
        }
    }
}

