﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Extensions.Configuration;

namespace Microsoft.Azure.Functions.Extensions.DependencyInjection
{
    public interface IFunctionsConfigurationBuilder
    {
        IConfigurationBuilder ConfigurationBuilder { get; }
    }
}