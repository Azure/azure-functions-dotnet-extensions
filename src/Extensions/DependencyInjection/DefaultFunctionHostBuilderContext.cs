// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Azure.WebJobs;

namespace Microsoft.Azure.Functions.Extensions.DependencyInjection
{
    internal class DefaultFunctionHostBuilderContext : FunctionsHostBuilderContext
    {
        public DefaultFunctionHostBuilderContext(WebJobsBuilderContext webJobsBuilderContext)
            : base(webJobsBuilderContext)
        {
        }
    }
}
