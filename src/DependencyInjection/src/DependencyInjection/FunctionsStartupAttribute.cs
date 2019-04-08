// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using Microsoft.Azure.WebJobs.Hosting;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Azure.Functions.Extensions.DependencyInjection
{
    /// <summary>
    /// Attribute used to declare <see cref="FunctionsStartup"/> Types that should be registered and invoked
    /// as part of host startup.
    /// </summary>
    [AttributeUsage(AttributeTargets.Assembly, Inherited = false, AllowMultiple = true)]
    public sealed class FunctionsStartupAttribute : WebJobsStartupAttribute
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// <param name="startupType">The Type of the <see cref="FunctionsStartup"/> class to register.</param>
        public FunctionsStartupAttribute(Type startupType) 
            : base(startupType, startupType?.Name)
        {
        }
    }
}
