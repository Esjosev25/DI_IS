using System;
using System.Collections.Generic;
using System.Text;
using DI_IS.Interfaces;

namespace DI_IS.Implements.Examples
{

    internal sealed class ExampleScopedService : IExampleScopedService
    {
        Guid IReportServiceLifetime.Id { get; } = Guid.NewGuid();
    }

}
