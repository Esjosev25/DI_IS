using DI_IS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_IS.Implements.Entrenador
{
    internal sealed class EntrenadorFuego:IEntrenador
    {


        private readonly IEnumerable<IPokemon> _pokemonesTransient;

        public EntrenadorFuego(IEnumerable<IPokemon> PokemonesTransient)
        {
            _pokemonesTransient = PokemonesTransient;
        }

        Guid IReportServiceLifetime.Id { get; } = Guid.NewGuid();

        string IEntrenador.Nombre => "Rayo";

        public void PasearPoke()
        {
            foreach (var pokemon in _pokemonesTransient)
            {
                LogService(pokemon, "Pokemones Transient");
                pokemon.MoverCola();

            }
        }
        private static void LogService<T>(T service, string message)
           where T : IReportServiceLifetime =>
           Console.WriteLine(
               $"    {typeof(T).Name}: {service.Id} ({message})");
    }
}
