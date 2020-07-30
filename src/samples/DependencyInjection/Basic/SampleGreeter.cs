// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Microsoft.Azure.Functions.Samples.DependencyInjectionBasic
{
    public class SampleGreeter : IGreeter
    {
        public string CreateGreeting(string name, string settingValue)
        {
            return $"Hello, {name}. I'm a sample greeter. The value of {nameof(SampleOptions.SampleSetting)} is '{settingValue}'.";
        }
    }
}
