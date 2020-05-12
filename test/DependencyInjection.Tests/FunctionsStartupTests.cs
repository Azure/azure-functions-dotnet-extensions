// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.DependencyInjection;
using System;
using Xunit;

namespace DependencyInjection.Tests
{
    public partial class FunctionsHostBuilderTests
    {
        [Fact]
        public void Configure_ConfiguresServices()
        {
            var builder = new TestStartup();

            var webJobsBuilder = new TestWebJobsBuilder();
            builder.Configure(webJobsBuilder);

            Assert.Collection(webJobsBuilder.Services, t => Assert.Equal(typeof(Foo), t.ImplementationType));
        }

        private class TestStartup : FunctionsStartup
        {
            public override void Configure(IFunctionsHostBuilder builder)
            {
                builder.Services.AddSingleton<IFoo, Foo>();
            }
        }

        public interface IFoo { }

        public class Foo : IFoo { }

    }
}
