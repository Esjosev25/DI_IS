using System;
using System.Collections.Generic;
using System.Text;
using DI_IS.Interfaces;

namespace DI_IS.Implements
{
    internal sealed class ExampleTransientService : IExampleTransientService
    {
        Guid IReportServiceLifetime.Id { get; } = Guid.NewGuid();
    }
}
