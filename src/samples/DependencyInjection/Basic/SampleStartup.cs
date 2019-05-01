// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(Microsoft.Azure.Functions.Samples.DependencyInjectionBasic.SampleStartup))]

namespace Microsoft.Azure.Functions.Samples.DependencyInjectionBasic
{
    public class SampleStartup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddScoped<IGreeter, SampleGreeter>();
        }
    }
}
