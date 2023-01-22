using DI_IS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_IS.Implements.Pokemon
{
    internal class PokemonFuego : IPokemon
    {
        public string Nombre => $"Fueguito {Guid.NewGuid().ToString()[..4]}";

        public int Hp => 100;

        Guid IReportServiceLifetime.Id { get; } = Guid.NewGuid();

        public void MoverCola()
        {
            Console.WriteLine($"{Nombre} Mueve cola  quemando el pasto");
        }
    }
}
