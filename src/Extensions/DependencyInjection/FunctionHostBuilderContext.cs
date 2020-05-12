// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.IO;

namespace Microsoft.Azure.Functions.Extensions.DependencyInjection
{
    public abstract class FunctionHostBuilderContext
    {
        private string _rootPath;

        public string RootPath
        {
            get
            {
                if (_rootPath == null)
                {
                    string home = Environment.GetEnvironmentVariable("HOME");

                    if (home != null)
                    {
                        _rootPath = Path.Combine(home, "site", "wwwroot");
                    }
                    else
                    {
                        _rootPath = Environment.GetEnvironmentVariable("AzureWebJobsScriptRoot");
                    }
                }

                return _rootPath;
            }
        }
    }
}
