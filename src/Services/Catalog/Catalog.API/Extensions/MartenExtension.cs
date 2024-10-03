using Marten;

namespace Catalog.API.Extensions
{
    public static class MartenExtension
    {
        public static IServiceCollection AddMartenExtension(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMarten(opt =>
            {
                opt.Connection(configuration.GetConnectionString("Database")!);
            }).UseLightweightSessions();

            return services;
        }
    }
}
