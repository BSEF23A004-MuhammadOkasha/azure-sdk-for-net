﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.Monitor.Query.Models;
using NUnit.Framework;
using NUnit.Framework.Internal.Commands;

namespace Azure.Monitor.Query.Tests
{
    public class MetricsClientLiveTests : RecordedTestBase<MonitorQueryTestEnvironment>
    {
        private MetricsTestData _testData;

        public MetricsClientLiveTests(bool isAsync) : base(isAsync, RecordedTestMode.Live)
        {
        }

        private MetricsClient CreateMetricsClient()
        {
            return InstrumentClient(new MetricsClient(
                new Uri(TestEnvironment.ConstructMetricsClientUri()),
                TestEnvironment.Credential,
                InstrumentClientOptions(new MetricsClientOptions()
                {
                    Audience = TestEnvironment.GetMetricsClientAudience()
                })
            ));
        }

        [SetUp]
        public void SetUp()
        {
            _testData = new MetricsTestData(TestEnvironment, DateTimeOffset.UtcNow);
            // await _testData.InitializeAsync();
        }

        [RecordedTest]
        public async Task MetricsQueryResourcesAsync()
        {
            MetricsClient client = CreateMetricsClient();

            var resourceId = TestEnvironment.StorageAccountId;

            Response<MetricsQueryResourcesResult> metricsResultsResponse = await client.QueryResourcesAsync(
                resourceIds: new List<ResourceIdentifier> { new ResourceIdentifier(resourceId) },
                metricNames: new List<string> { "Ingress" },
                metricNamespace: "Microsoft.Storage/storageAccounts").ConfigureAwait(false);

            MetricsQueryResourcesResult metricsQueryResults = metricsResultsResponse.Value;
            Assert.AreEqual(1, metricsQueryResults.Values.Count);
            Assert.AreEqual(TestEnvironment.StorageAccountId + "/providers/Microsoft.Insights/metrics/Ingress", metricsQueryResults.Values[0].Metrics[0].Id);
            Assert.AreEqual("Microsoft.Storage/storageAccounts", metricsQueryResults.Values[0].Namespace);
            for (int i = 0; i < metricsQueryResults.Values.Count; i++)
            {
                foreach (MetricResult value in metricsQueryResults.Values[i].Metrics)
                {
                    for (int j = 0; j < value.TimeSeries.Count; j++)
                    {
                        Assert.GreaterOrEqual(value.TimeSeries[j].Values[i].Total, 0);
                    }
                }
            }
        }

        [RecordedTest]
        public async Task MetricsQueryResourcesWithOptionsAsync()
        {
            MetricsClient client = CreateMetricsClient();

            var resourceId = TestEnvironment.StorageAccountId;

            var timeRange = new QueryTimeRange(
                start: DateTimeOffset.UtcNow,
                end: DateTimeOffset.UtcNow.AddHours(4)
            );

            Response<MetricsQueryResourcesResult> metricsResultsResponse = await client.QueryResourcesAsync(
                resourceIds: new List<ResourceIdentifier> { new ResourceIdentifier(resourceId) },
                metricNames: new List<string> { "Ingress" },
                metricNamespace: "Microsoft.Storage/storageAccounts",
                options: new MetricsQueryResourcesOptions { TimeRange = timeRange} ).ConfigureAwait(false);

            MetricsQueryResourcesResult metricsQueryResults = metricsResultsResponse.Value;
            Assert.AreEqual(1, metricsQueryResults.Values.Count);
            Assert.AreEqual(TestEnvironment.StorageAccountId + "/providers/Microsoft.Insights/metrics/Ingress", metricsQueryResults.Values[0].Metrics[0].Id);
            Assert.AreEqual("Microsoft.Storage/storageAccounts", metricsQueryResults.Values[0].Namespace);
            for (int i = 0; i < metricsQueryResults.Values.Count; i++)
            {
                foreach (MetricResult value in metricsQueryResults.Values[i].Metrics)
                {
                    for (int j = 0; j < value.TimeSeries.Count; j++)
                    {
                        Assert.GreaterOrEqual(value.TimeSeries[j].Values[i].Total, 0);
                    }
                }
            }
        }

        [Test]
        [SyncOnly]
        public void MetricsQueryResourcesInvalid()
        {
            MetricsClient client = CreateMetricsClient();

            Assert.Throws<ArgumentException>(() =>
                client.QueryResources(
                resourceIds: new List<ResourceIdentifier>(),
                metricNames: new List<string> { "Ingress" },
                metricNamespace: "Microsoft.Storage/storageAccounts"));
        }
    }
}
