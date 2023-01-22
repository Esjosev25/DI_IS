using DI_IS.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DI_IS.Implements
{

    internal sealed class ServiceLifetimeReporter
    {
        private readonly IBatalla _batallaScoped;


        public ServiceLifetimeReporter(IBatalla BatallaScoped) => _batallaScoped = BatallaScoped;

        public void ReportServiceLifetimeDetails(string lifetimeDetails)
        {
            Console.WriteLine(lifetimeDetails);

            LogService(_batallaScoped, "Batalla Scoped (Ida y Vuelta)");
            _batallaScoped.IniciarBatalla();

        }

        private static void LogService<T>(T service, string message)
            where T : IReportServiceLifetime =>
            Console.WriteLine(
                $"    {typeof(T).Name}: {service.Id} ({message})");
    }
}
