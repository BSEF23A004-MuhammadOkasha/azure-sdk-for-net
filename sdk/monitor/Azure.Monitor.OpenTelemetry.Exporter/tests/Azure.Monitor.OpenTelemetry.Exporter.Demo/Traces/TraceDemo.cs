﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using Azure.Monitor.OpenTelemetry.Exporter.Tracing.Customization;
using OpenTelemetry;
using OpenTelemetry.Extensions.AzureMonitor;
using OpenTelemetry.Resources;
using OpenTelemetry.Trace;

namespace Azure.Monitor.OpenTelemetry.Exporter.Demo.Traces
{
    internal class TraceDemo : IDisposable
    {
        private const string activitySourceName = "MyCompany.MyProduct.MyLibrary";
        private static readonly ActivitySource activitySource = new(activitySourceName);

        private readonly TracerProvider tracerProvider;

        public TraceDemo(string connectionString)
        {
            var resourceAttributes = new Dictionary<string, object>
            {
                { "service.name", "my-service" },
                { "service.namespace", "my-namespace" },
                { "service.instance.id", "my-instance" },
            };

            var resourceBuilder = ResourceBuilder.CreateDefault().AddAttributes(resourceAttributes);

            this.tracerProvider = Sdk.CreateTracerProviderBuilder()
                            .SetResourceBuilder(resourceBuilder)
                            .AddSource(activitySourceName)
                            .AddProcessor(new ActivityFilteringProcessor())
                            .AddProcessor(new ActivityEnrichingProcessor())
                            .SetSampler(new ApplicationInsightsSampler(1.0F))
                            .AddAzureMonitorTraceExporter(o => o.ConnectionString = connectionString)
                            .Build();
        }

        public void GenerateTraces()
        {
            using (var testActivity1 = activitySource.StartActivity("TestInternalActivity", ActivityKind.Internal))
            {
                // Note: This activity will be dropped due to
                // the ActivityFilteringProcessor filtering Internal Activities.
                testActivity1?.SetTag("CustomTag1", "Value1");
                testActivity1?.SetTag("CustomTag2", "Value2");
            }

            using (var activity = activitySource.StartActivity("SayHello", ActivityKind.Client))
            {
                activity?.SetTag("foo", 1);
                activity?.SetTag("baz", new int[] { 1, 2, 3 });
                activity?.SetStatus(ActivityStatusCode.Ok);

                using (var nestedActivity = activitySource.StartActivity("SayHelloAgain", ActivityKind.Client))
                {
                    nestedActivity?.SetTag("bar", "Hello, World!");
                    nestedActivity?.SetStatus(ActivityStatusCode.Ok);
                }
            }
        }

        public void Dispose()
        {
            this.tracerProvider.Shutdown();
            this.tracerProvider.Dispose();
        }
    }
}
