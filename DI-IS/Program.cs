
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using DI_IS.Interfaces;
using DI_IS;
using DI_IS.Implements;
using DI_IS.Implements.Examples;
using DI_IS.Implements.Entrenador;
using DI_IS.Implements.Pokemon;
using DI_IS.Implements.Batalla;

using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddSingleton<IEntrenador, EntrenadorElectrico>();
        services.AddSingleton<IEntrenador, EntrenadorFuego>();
        services.AddTransient<IPokemon, PokemonElectrico>();
        services.AddTransient<IPokemon, PokemonFuego>();
        services.AddScoped<IBatalla, Batalla>();
        services.AddTransient<ServiceLifetimeReporter>();
    })
    .Build();

ExemplifyServiceLifetime(host.Services, "Lifetime 1");
ExemplifyServiceLifetime(host.Services, "Lifetime 2");

await host.RunAsync();

static void ExemplifyServiceLifetime(IServiceProvider hostProvider, string lifetime)
{
    using IServiceScope serviceScope = hostProvider.CreateScope();
    IServiceProvider provider = serviceScope.ServiceProvider;
    ServiceLifetimeReporter logger = provider.GetRequiredService<ServiceLifetimeReporter>();
    logger.ReportServiceLifetimeDetails(
        $"{lifetime}: Call 1 to provider.GetRequiredService<ServiceLifetimeLogger>()");

    Console.WriteLine("...");

    logger = provider.GetRequiredService<ServiceLifetimeReporter>();
    logger.ReportServiceLifetimeDetails(
        $"{lifetime}: Call 2 to provider.GetRequiredService<ServiceLifetimeLogger>()");

    Console.WriteLine();
}