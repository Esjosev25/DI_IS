using DI_IS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_IS.Implements.Batalla
{
    internal sealed class Batalla : IBatalla
    {
        Guid IReportServiceLifetime.Id { get; } = Guid.NewGuid();
        private readonly IEnumerable<IEntrenador> _entrenadoresSingleton;

        public Batalla(IEnumerable<IEntrenador> entrenadoresSingleton)
        {
            _entrenadoresSingleton = entrenadoresSingleton;
        }
        public void IniciarBatalla()
        {
            foreach (var Entrenador in _entrenadoresSingleton)
            {
                LogService(Entrenador, "Entrenador Singleton");
                Entrenador.PasearPoke();
            }
        }

        private static void LogService<T>(T service, string message)
           where T : IReportServiceLifetime =>
           Console.WriteLine(
               $"    {typeof(T).Name}: {service.Id} ({message})");

    }
}
