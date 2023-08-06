using GamesNexus.Data.Common;
using GamesNexus.Services.Data;
using GamesNexus.Services.Data.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;


namespace Microsoft.Extensions.DependencyInjection
{
    public static class WebApplicationBuilderExtensions
    {

        public static void AddApplicationServices(this  IServiceCollection services)
        {
            services.AddScoped<IRepository, Repository>();
            services.AddScoped<IGameService, GameServices>();
        }
    }
}

