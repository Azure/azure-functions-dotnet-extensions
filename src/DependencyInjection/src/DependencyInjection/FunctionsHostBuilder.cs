using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Azure.Functions.Extensions.DependencyInjection
{
    internal class FunctionsHostBuilder : IFunctionsHostBuilder
    {
        public FunctionsHostBuilder(IServiceCollection services)
        {
            Services = services ?? throw new ArgumentNullException(nameof(services));
        }

        public IServiceCollection Services { get; }
    }
}
