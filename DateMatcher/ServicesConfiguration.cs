using DateMatcher.LevelMatcher;
using Microsoft.Extensions.DependencyInjection;

namespace DateMatcher
{
    public static class ServicesConfiguration
    {
        public static IServiceCollection AddDateMatcher(this IServiceCollection services)
        {
            services.Scan(ts => ts
                .FromAssemblyOf<ILevelMatcher>()
                .AddClasses(c => c.AssignableTo<ILevelMatcher>(), false)
                .As<ILevelMatcher>()
                .WithLifetime(ServiceLifetime.Singleton)
            );
            services.AddSingleton<IDateMatcher, Services.DateMatcher>();
            return services;
        }
    }
}