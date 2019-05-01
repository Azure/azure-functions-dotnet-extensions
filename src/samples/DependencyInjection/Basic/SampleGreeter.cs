// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Microsoft.Azure.Functions.Samples.DependencyInjectionBasic
{
    public class SampleGreeter : IGreeter
    {
        public string CreateGreeting(string name)
        {
            return $"Hello, {name}. I'm a sample greeter.";
        }
    }
}
