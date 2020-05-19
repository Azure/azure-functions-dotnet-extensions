// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Hosting;

namespace Microsoft.Azure.Functions.Extensions.DependencyInjection
{
    /// <summary>
    /// Interface defining a startup configuration action that should be performed
    /// as part of the Functions runtime startup.
    /// </summary>
    public abstract class FunctionsStartup : IWebJobsStartup2, IWebJobsConfigurationStartup
    {
        public void Configure(IWebJobsBuilder builder)
        {
            Configure(null, builder);
        }

        public void Configure(WebJobsBuilderContext context, IWebJobsBuilder builder)
        {
            var functionsBuilder = new FunctionsHostBuilder(builder.Services, context);

            Configure(functionsBuilder);
        }

        public void Configure(WebJobsBuilderContext context, IWebJobsConfigurationBuilder builder)
        {
            var functionsConfigBuilder = new FunctionsConfigurationBuilder(builder.ConfigurationBuilder, context);

            ConfigureAppConfiguration(functionsConfigBuilder);
        }

        /// <summary>
        /// Performs the startup configuration action. The runtime will call this
        /// method at the right time during initialization.
        /// </summary>
        /// <param name="builder">The <see cref="IFunctionsHostBuilder"/> that can be used to
        /// configure the host.</param>
        public abstract void Configure(IFunctionsHostBuilder builder);

        /// <summary>
        /// Performs the startup configuration action for configuring application configuration.
        /// The runtime will call this method at the right time during initialization.
        /// </summary>
        /// <param name="builder">The <see cref="IFunctionsConfigurationBuilder"/> that can be used to
        /// configure the application configuration.</param>
        public virtual void ConfigureAppConfiguration(IFunctionsConfigurationBuilder builder)
        {
        }
    }
}
