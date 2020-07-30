// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Azure.Functions.Extensions.DependencyInjection
{
    internal class FunctionsHostBuilder : IFunctionsHostBuilder, IFunctionsHostBuilderExt
    {
        public FunctionsHostBuilder(IServiceCollection services, WebJobsBuilderContext webJobsBuilderContext)
        {
            Services = services ?? throw new ArgumentNullException(nameof(services));
            Context = new DefaultFunctionsHostBuilderContext(webJobsBuilderContext);
        }

        public IServiceCollection Services { get; }

        public FunctionsHostBuilderContext Context { get; }
    }
}
