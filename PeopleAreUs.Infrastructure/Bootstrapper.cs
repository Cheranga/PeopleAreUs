using System;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;

//[assembly: InternalsVisibleTo("PeopleAreUs.Infrastructure.Tests")]
[assembly: InternalsVisibleTo("PeopleAreUs.Infrastructure.Tests")]


namespace PeopleAreUs.Infrastructure
{
    public static class Bootstrapper
    {
        public static void UseInfrastructure(this IServiceCollection services, PeopleAreUsApiConfig config)
        {
            if (services == null || config == null)
            {
                throw new Exception("Insufficient configuration data");
            }

            services.AddSingleton(config);

            services.AddHttpClient<IPeopleAreUsHttpClient, PeopleAreUsHttpClient>();
            services.AddSingleton<IPeopleDataConverter, JsonPeopleDataConverter>();
        }
    }
}