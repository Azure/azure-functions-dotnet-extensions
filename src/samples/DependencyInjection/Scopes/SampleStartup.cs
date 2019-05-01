// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(Microsoft.Azure.Functions.Samples.DependencyInjectionScopes.SampleStartup))]

namespace Microsoft.Azure.Functions.Samples.DependencyInjectionScopes
{
    public class SampleStartup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {

            // Register MyServiceA as transient.
            // A new instance will be returned every
            // time a service request is made
            builder.Services.AddTransient<MyServiceA>();

            // Register MyServiceB as scoped.
            // The same instance will be returned
            // within the scope of a function invocation
            builder.Services.AddScoped<MyServiceB>();

            // Register ICommonIdProvider as scoped.
            // The same instance will be returned
            // within the scope of a function invocation
            builder.Services.AddScoped<ICommonIdProvider, CommonIdProvider>();


            // Register IGlobalIdProvider as singleton.
            // A single instance will be created and reused
            // with every service request
            builder.Services.AddSingleton<IGlobalIdProvider, CommonIdProvider>();
        }
    }
}
