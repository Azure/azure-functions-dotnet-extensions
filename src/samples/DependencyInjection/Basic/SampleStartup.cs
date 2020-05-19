// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.IO;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(Microsoft.Azure.Functions.Samples.DependencyInjectionBasic.SampleStartup))]

namespace Microsoft.Azure.Functions.Samples.DependencyInjectionBasic
{
    public class SampleStartup : FunctionsStartup
    {
        public override void ConfigureAppConfiguration(IFunctionsConfigurationBuilder builder)
        {
            FunctionsHostBuilderContext context = builder.GetContext();

            // Note that these files are not automatically copied on build or publish. 
            // See the csproj file to for the correct setup.
            builder.ConfigurationBuilder
                .AddJsonFile(Path.Combine(context.ApplicationRootPath, "appsettings.json"), optional: true, reloadOnChange: false)
                .AddJsonFile(Path.Combine(context.ApplicationRootPath, $"appsettings.{context.EnvironmentName}.json"), optional: true, reloadOnChange: false);
        }

        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddScoped<IGreeter, SampleGreeter>();

            FunctionsHostBuilderContext context = builder.GetContext();
            builder.Services.Configure<SampleOptions>(context.Configuration);
        }
    }
}
