﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Hosting;

namespace Microsoft.Azure.Functions.Extensions.DependencyInjection
{
    /// <summary>
    /// Interface defining a startup configuration action that should be performed
    /// as part of the Functions runtime startup.
    /// </summary>
    public abstract class FunctionsStartup : IWebJobsStartup
    {
        public void Configure(IWebJobsBuilder builder)
        {
            var functionsBuilder = new FunctionsHostBuilder(builder.Services);

            Configure(functionsBuilder);
        }

        /// <summary>
        /// Performs the startup configuration action. The runtime will call this
        /// method at the right time during initialization.
        /// </summary>
        /// <param name="builder">The <see cref="IWebJobsBuilder"/> that can be used to
        /// configure the host.</param>
        public abstract void Configure(IFunctionsHostBuilder builder);
    }
}
