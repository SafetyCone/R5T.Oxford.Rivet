using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.Oxford.Rivet
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="RivetOrganizationProvider"/> implementation of <see cref="IOrganizationProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddRivetOrganizationProvider(this IServiceCollection services)
        {
            services.AddSingleton<IOrganizationProvider, RivetOrganizationProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="RivetOrganizationProvider"/> implementation of <see cref="IOrganizationProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<IOrganizationProvider> AddRivetOrganizationProviderAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<IOrganizationProvider>(() => services.AddRivetOrganizationProvider());
            return serviceAction;
        }
    }
}
