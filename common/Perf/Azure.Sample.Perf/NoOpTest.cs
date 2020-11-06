﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Test.Perf;
using System.Threading;
using System.Threading.Tasks;

namespace System.PerfStress
{
    // Used for measuring the overhead of the perf framework with the fastest possible test
    public class NoOpTest : PerfStressTest<PerfStressOptions>
    {
        public NoOpTest(PerfStressOptions options) : base(options) { }

        public override void Run(CancellationToken cancellationToken)
        {
        }

        public override Task RunAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
