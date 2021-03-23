﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.Test.Perf;

namespace Azure.Template.Perf
{
    public class CacheReadWithDiskPersistencePerf : PerfTest<CountOptions>
    {
        private ClientSecretCredential _credential;
        private readonly TokenRequestContext _tokenRequestContext = new(new[] { "https://storage.azure.com/.default" });

        public CacheReadWithDiskPersistencePerf(CountOptions options) : base(options)
        {
            _credential = new ClientSecretCredential(
                Environment.GetEnvironmentVariable("AZURE_TENANT_ID"),
                Environment.GetEnvironmentVariable("AZURE_CLIENT_ID"),
                Environment.GetEnvironmentVariable("AZURE_CLIENT_SECRET"),
                new ClientSecretCredentialOptions{ TokenCachePersistenceOptions = new TokenCachePersistenceOptions()}
                );

            _credential.GetToken(_tokenRequestContext);
        }

        public override void Run(CancellationToken cancellationToken)
        {
            _credential.GetToken(_tokenRequestContext);
        }

        public override async Task RunAsync(CancellationToken cancellationToken)
        {
            await _credential.GetTokenAsync(_tokenRequestContext).ConfigureAwait(false);
        }
    }
}
