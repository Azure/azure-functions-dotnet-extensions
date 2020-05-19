// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Configuration;

namespace Microsoft.Azure.Functions.Extensions.DependencyInjection
{
    /// <summary>
    /// Context containing the common services and settings for the Functions host.
    /// </summary>
    public abstract class FunctionsHostBuilderContext
    {
        private readonly WebJobsBuilderContext _webJobsBuilderContext;

        public FunctionsHostBuilderContext(WebJobsBuilderContext webJobsBuilderContext)
        {
            _webJobsBuilderContext = webJobsBuilderContext ?? throw new ArgumentNullException(nameof(webJobsBuilderContext));
        }

        /// <summary>
        /// Gets the name of the environment. This is "Development" when running in the Azure Functions Core Tools and "Production" when deployed to Azure.
        /// </summary>
        public string EnvironmentName => _webJobsBuilderContext.EnvironmentName;

        /// <summary>
        /// Gets the <see cref="IConfiguration"/> containing the merged configuration of the application and the host.
        /// </summary>
        public IConfiguration Configuration => _webJobsBuilderContext.Configuration;

        /// <summary>
        /// Gets or sets the absolute path to the directory that contains the application content files.
        /// </summary>
        public string ApplicationRootPath => _webJobsBuilderContext.ApplicationRootPath;
    }
}
