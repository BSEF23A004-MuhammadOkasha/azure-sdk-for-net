// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.TestFramework;

namespace Azure.AI.MetricsAdvisor.Tests
{
    public class MetricsAdvisorTestEnvironment : TestEnvironment
    {
        public MetricsAdvisorTestEnvironment() : base("metricsadvisor")
        { }

        public const string DefaultEndpointSuffix = "azure.com";
        public string MetricsAdvisorApiKey => GetRecordedVariable("METRICSADVISOR_PRIMARY_API_KEY", options => options.IsSecret());
        public string MetricsAdvisorSubscriptionKey => GetRecordedVariable("METRICSADVISOR_SUBSCRIPTION_KEY", options => options.IsSecret());
        public string MetricsAdvisorAccountName => GetRecordedVariable("METRICSADVISOR_ACCOUNT_NAME");
        public string MetricsAdvisorEndpointSuffix => GetRecordedOptionalVariable("METRICSADVISOR_ENDPOINT_SUFFIX") ?? DefaultEndpointSuffix;
        public string MetricsAdvisorUri => $"https://{MetricsAdvisorAccountName}.cognitiveservices.{MetricsAdvisorEndpointSuffix}";

        // Data feed sources
        public const string DefaultStorageSuffix = "core.windows.net";
        public string PrimaryStorageAccountKey => GetRecordedVariable("METRICSADVISOR_PRIMARY_STORAGE_ACCOUNT_KEY", options => options.IsSecret(SanitizedValue.Base64));
        public string StorageAccountName => GetRecordedVariable("METRICSADVISOR_STORAGE_ACCOUNT_NAME");
        public string StorageUri => $"https://{StorageAccountName}.table.{StorageEndpointSuffix ?? DefaultStorageSuffix}";

        public string SqlServerConnectionString => GetRecordedVariable("METRICSADVISOR_SQL_SERVER_CONNECTION_STRING", options => options.IsSecret(SanitizedValue.Base64));
        public string SqlServerQuery => GetRecordedVariable("METRICSADVISOR_SQL_SERVER_QUERY");

        // Samples
        public string DataFeedId => GetRecordedVariable("METRICSADVISOR_DATA_FEED_ID");
        public string MetricId => GetRecordedVariable("METRICSADVISOR_METRIC_ID");
        public string HookId => GetRecordedVariable("METRICSADVISOR_HOOK_ID");
        public string DetectionConfigurationId => GetRecordedVariable("METRICSADVISOR_DETECTION_CONFIGURATION_ID");
        public string AlertConfigurationId => GetRecordedVariable("METRICSADVISOR_ALERT_CONFIGURATION_ID");
    }
}
