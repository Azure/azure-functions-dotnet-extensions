// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Azure.WebJobs;

namespace Microsoft.Azure.Functions.Extensions.DependencyInjection
{
    public static class FunctionsBuilderExtensions
    {
        public static FunctionsHostBuilderContext GetContext(this IFunctionsHostBuilder builder)
        {
            if (builder is IFunctionsHostBuilderExt hostBuilder)
            {
                return hostBuilder.Context;
            }

            return new DefaultFunctionHostBuilderContext(new WebJobsBuilderContext());
        }

        public static FunctionsHostBuilderContext GetContext(this IFunctionsConfigurationBuilder builder)
        {
            if (builder is IFunctionsHostBuilderExt hostBuilder)
            {
                return hostBuilder.Context;
            }

            return new DefaultFunctionHostBuilderContext(new WebJobsBuilderContext());
        }
    }
}
