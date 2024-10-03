using FluentValidation;

namespace Catalog.API.Extensions
{
    public static class ValidatorExtension
    {
        public static IServiceCollection AddValidatorExtension(this IServiceCollection services)
        {
            services.AddValidatorsFromAssembly(typeof(ValidatorExtension).Assembly); 

            return services;
        }
    }
}
