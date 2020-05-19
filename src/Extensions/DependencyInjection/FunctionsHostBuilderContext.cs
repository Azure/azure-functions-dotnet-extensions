// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Configuration;

namespace Microsoft.Azure.Functions.Extensions.DependencyInjection
{
    public abstract class FunctionsHostBuilderContext
    {
        private readonly WebJobsBuilderContext _webJobsBuilderContext;

        public FunctionsHostBuilderContext(WebJobsBuilderContext webJobsBuilderContext)
        {
            _webJobsBuilderContext = webJobsBuilderContext ?? throw new ArgumentNullException(nameof(webJobsBuilderContext));
        }

        public string EnvironmentName => _webJobsBuilderContext.EnvironmentName;

        public IConfiguration Configuration => _webJobsBuilderContext.Configuration;

        public string ApplicationRootPath => _webJobsBuilderContext.ApplicationRootPath;
    }
}
