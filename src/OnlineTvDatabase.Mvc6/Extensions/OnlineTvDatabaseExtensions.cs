using Microsoft.Framework.DependencyInjection;
using OnlineTvDatabase.Core.Abstractions;
using OnlineTvDatabase.Core.Builders;
using OnlineTvDatabase.Core.Factory;
using OnlineTvDatabase.Core.Http;
using OnlineTvDatabase.Core.Http.Abstractions;
using OnlineTvDatabase.Core.Models;
using OnlineTvDatabase.Mvc6.Factory;

namespace OnlineTvDatabase.Mvc6.Extensions
{
    public static class OnlineTvDatabaseExtensions
    {
        public static IServiceCollection AddOnlineTvDatabase(this IServiceCollection services)
        {
            services.AddSingleton<IOnlineTvDatabase, OnlineTvDatabaseClient>();
            services.AddScoped<IHttpClient, HttpClient>();
            services.AddSingleton<IObjectUrlFactory, ObjectUrlFactory>();
            services.AddScoped<IObjectUrlBuilder<GetSeriesInput>, GetSeriesUrlBuilder>();
            return services;
        }
    }
}
