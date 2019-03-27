// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Azure.Functions.Extensions.DependencyInjection
{
    public interface IFunctionsHostBuilder
    {
        IServiceCollection Services { get; }
    }
}