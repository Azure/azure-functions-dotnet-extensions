// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Azure.Functions.Extensions.DependencyInjection
{
    /// <summary>
    /// Interface defining a startup configuration action that should be performed
    /// as part of the Functions runtime startup.
    /// </summary>
    public interface IFunctionsStartup
    {
        /// <summary>
        /// Performs the startup configuration action. The runtime will call this
        /// method at the right time during initialization.
        /// </summary>
        /// <param name="builder">The <see cref="IWebJobsBuilder"/> that can be used to
        /// configure the host.</param>
        void Configure(IFunctionsHostBuilder builder);
    }
}
