using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using PeopleAreUs.Console.Mappers;
using PeopleAreUs.Console.Output;
using PeopleAreUs.Console.ViewModels;
using PeopleAreUs.Core;
using PeopleAreUs.Services;
using PeopleAreUs.Services.Responses;

namespace PeopleAreUs.Console
{
    public class Bootstrapper
    {
        public static IServiceProvider GetServiceProvider(IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            RegisterLogging(services);
            RegisterMediators(services);
            RegisterMappers(services);
            RegisterRenderers(services);
            
            services.UseServices();

            var serviceProvider = services.BuildServiceProvider();

            return serviceProvider;
        }

        private static void RegisterLogging(IServiceCollection services)
        {
            services.AddLogging(builder => builder.AddConsole());
        }

        private static void RegisterMediators(IServiceCollection services)
        {
            services.AddSingleton<IPeopleMediator, PeopleMediator>();
        }

        private static void RegisterMappers(IServiceCollection services)
        {
            services.AddSingleton<IMapper<GetPetOwnersResponse, PetsByOwnerGenderViewModel>, GetPetOwnersResponseToPetsByOwnerGenderViewModelMapper>();
        }

        private static void RegisterRenderers(IServiceCollection services)
        {
            services.AddSingleton<IRenderer<PetsByOwnerGenderViewModel>, PetsByOwnerGenderRenderer>();
        }
    }
}