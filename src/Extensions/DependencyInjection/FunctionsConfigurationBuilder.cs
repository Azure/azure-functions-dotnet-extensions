// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Configuration;

namespace Microsoft.Azure.Functions.Extensions.DependencyInjection
{
    internal class FunctionsConfigurationBuilder : IFunctionsConfigurationBuilder, IFunctionsHostBuilderExt
    {
        public FunctionsConfigurationBuilder(IConfigurationBuilder configurationBuilder, WebJobsBuilderContext webJobsBuilderContext)
        {
            ConfigurationBuilder = configurationBuilder ?? throw new ArgumentNullException(nameof(configurationBuilder));
            Context = new DefaultFunctionsHostBuilderContext(webJobsBuilderContext);
        }

        public IConfigurationBuilder ConfigurationBuilder { get; }

        public FunctionsHostBuilderContext Context { get; }
    }
}