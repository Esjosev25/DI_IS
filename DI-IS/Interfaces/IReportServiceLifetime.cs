using Microsoft.Extensions.DependencyInjection;


namespace DI_IS.Interfaces
{
    public interface IReportServiceLifetime
    {
        Guid Id { get; }
        ServiceLifetime Lifetime { get; }
    }
}
