// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Azure.Functions.Extensions.DependencyInjection
{
    internal class FunctionsHostBuilder : IFunctionsHostBuilder, IFunctionsHostBuilderExt
    {
        public FunctionsHostBuilder()
        {
            Context = new DefaultFunctionHostBuilderContext();
        }

        public FunctionsHostBuilder(IServiceCollection services)
            : this()
        {
            Services = services ?? throw new ArgumentNullException(nameof(services));
        }

        public IServiceCollection Services { get; }

        public FunctionHostBuilderContext Context { get; private set; }
    }
}
