using Microsoft.Extensions.DependencyInjection;


namespace DI_IS.Interfaces
{
    public interface IBatalla : IReportServiceLifetime
    {
        ServiceLifetime IReportServiceLifetime.Lifetime => ServiceLifetime.Scoped;
        void IniciarBatalla();
    }
}
