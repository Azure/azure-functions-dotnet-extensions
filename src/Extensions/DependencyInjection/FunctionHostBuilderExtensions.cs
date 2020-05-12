// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Azure.Functions.Extensions.DependencyInjection
{
    public static class FunctionHostBuilderExtensions
    {
        public static FunctionHostBuilderContext GetContext(this IFunctionsHostBuilder builder)
        {
            if (builder is IFunctionsHostBuilderExt hostBuilder)
            {
                return hostBuilder.Context;
            }

            return new DefaultFunctionHostBuilderContext();
        }
    }
}
