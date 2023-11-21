// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataLakeAnalytics.Models
{
    /// <summary>
    /// The parameters that can be used to update an existing Data Lake Analytics account.
    /// Serialized Name: UpdateDataLakeAnalyticsAccountParameters
    /// </summary>
    public partial class DataLakeAnalyticsAccountPatch
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DataLakeAnalyticsAccountPatch"/>. </summary>
        public DataLakeAnalyticsAccountPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            DataLakeStoreAccounts = new ChangeTrackingList<DataLakeStoreForDataLakeAnalyticsAccountUpdateContent>();
            StorageAccounts = new ChangeTrackingList<StorageAccountForDataLakeAnalyticsAccountUpdateContent>();
            ComputePolicies = new ChangeTrackingList<ComputePolicyForDataLakeAnalyticsAccountUpdateContent>();
            FirewallRules = new ChangeTrackingList<FirewallRuleForDataLakeAnalyticsAccountUpdateContent>();
        }

        /// <summary> Initializes a new instance of <see cref="DataLakeAnalyticsAccountPatch"/>. </summary>
        /// <param name="tags">
        /// The resource tags.
        /// Serialized Name: UpdateDataLakeAnalyticsAccountParameters.tags
        /// </param>
        /// <param name="dataLakeStoreAccounts">
        /// The list of Data Lake Store accounts associated with this account.
        /// Serialized Name: UpdateDataLakeAnalyticsAccountParameters.properties.dataLakeStoreAccounts
        /// </param>
        /// <param name="storageAccounts">
        /// The list of Azure Blob storage accounts associated with this account.
        /// Serialized Name: UpdateDataLakeAnalyticsAccountParameters.properties.storageAccounts
        /// </param>
        /// <param name="computePolicies">
        /// The list of compute policies associated with this account.
        /// Serialized Name: UpdateDataLakeAnalyticsAccountParameters.properties.computePolicies
        /// </param>
        /// <param name="firewallRules">
        /// The list of firewall rules associated with this account.
        /// Serialized Name: UpdateDataLakeAnalyticsAccountParameters.properties.firewallRules
        /// </param>
        /// <param name="firewallState">
        /// The current state of the IP address firewall for this account. Disabling the firewall does not remove existing rules, they will just be ignored until the firewall is re-enabled.
        /// Serialized Name: UpdateDataLakeAnalyticsAccountParameters.properties.firewallState
        /// </param>
        /// <param name="firewallAllowAzureIPs">
        /// The current state of allowing or disallowing IPs originating within Azure through the firewall. If the firewall is disabled, this is not enforced.
        /// Serialized Name: UpdateDataLakeAnalyticsAccountParameters.properties.firewallAllowAzureIps
        /// </param>
        /// <param name="newTier">
        /// The commitment tier to use for next month.
        /// Serialized Name: UpdateDataLakeAnalyticsAccountParameters.properties.newTier
        /// </param>
        /// <param name="maxJobCount">
        /// The maximum supported jobs running under the account at the same time.
        /// Serialized Name: UpdateDataLakeAnalyticsAccountParameters.properties.maxJobCount
        /// </param>
        /// <param name="maxDegreeOfParallelism">
        /// The maximum supported degree of parallelism for this account.
        /// Serialized Name: UpdateDataLakeAnalyticsAccountParameters.properties.maxDegreeOfParallelism
        /// </param>
        /// <param name="maxDegreeOfParallelismPerJob">
        /// The maximum supported degree of parallelism per job for this account.
        /// Serialized Name: UpdateDataLakeAnalyticsAccountParameters.properties.maxDegreeOfParallelismPerJob
        /// </param>
        /// <param name="minPriorityPerJob">
        /// The minimum supported priority per job for this account.
        /// Serialized Name: UpdateDataLakeAnalyticsAccountParameters.properties.minPriorityPerJob
        /// </param>
        /// <param name="queryStoreRetention">
        /// The number of days that job metadata is retained.
        /// Serialized Name: UpdateDataLakeAnalyticsAccountParameters.properties.queryStoreRetention
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataLakeAnalyticsAccountPatch(IDictionary<string, string> tags, IList<DataLakeStoreForDataLakeAnalyticsAccountUpdateContent> dataLakeStoreAccounts, IList<StorageAccountForDataLakeAnalyticsAccountUpdateContent> storageAccounts, IList<ComputePolicyForDataLakeAnalyticsAccountUpdateContent> computePolicies, IList<FirewallRuleForDataLakeAnalyticsAccountUpdateContent> firewallRules, DataLakeAnalyticsFirewallState? firewallState, DataLakeAnalyticsFirewallAllowAzureIPsState? firewallAllowAzureIPs, DataLakeAnalyticsCommitmentTierType? newTier, int? maxJobCount, int? maxDegreeOfParallelism, int? maxDegreeOfParallelismPerJob, int? minPriorityPerJob, int? queryStoreRetention, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Tags = tags;
            DataLakeStoreAccounts = dataLakeStoreAccounts;
            StorageAccounts = storageAccounts;
            ComputePolicies = computePolicies;
            FirewallRules = firewallRules;
            FirewallState = firewallState;
            FirewallAllowAzureIPs = firewallAllowAzureIPs;
            NewTier = newTier;
            MaxJobCount = maxJobCount;
            MaxDegreeOfParallelism = maxDegreeOfParallelism;
            MaxDegreeOfParallelismPerJob = maxDegreeOfParallelismPerJob;
            MinPriorityPerJob = minPriorityPerJob;
            QueryStoreRetention = queryStoreRetention;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// The resource tags.
        /// Serialized Name: UpdateDataLakeAnalyticsAccountParameters.tags
        /// </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary>
        /// The list of Data Lake Store accounts associated with this account.
        /// Serialized Name: UpdateDataLakeAnalyticsAccountParameters.properties.dataLakeStoreAccounts
        /// </summary>
        public IList<DataLakeStoreForDataLakeAnalyticsAccountUpdateContent> DataLakeStoreAccounts { get; }
        /// <summary>
        /// The list of Azure Blob storage accounts associated with this account.
        /// Serialized Name: UpdateDataLakeAnalyticsAccountParameters.properties.storageAccounts
        /// </summary>
        public IList<StorageAccountForDataLakeAnalyticsAccountUpdateContent> StorageAccounts { get; }
        /// <summary>
        /// The list of compute policies associated with this account.
        /// Serialized Name: UpdateDataLakeAnalyticsAccountParameters.properties.computePolicies
        /// </summary>
        public IList<ComputePolicyForDataLakeAnalyticsAccountUpdateContent> ComputePolicies { get; }
        /// <summary>
        /// The list of firewall rules associated with this account.
        /// Serialized Name: UpdateDataLakeAnalyticsAccountParameters.properties.firewallRules
        /// </summary>
        public IList<FirewallRuleForDataLakeAnalyticsAccountUpdateContent> FirewallRules { get; }
        /// <summary>
        /// The current state of the IP address firewall for this account. Disabling the firewall does not remove existing rules, they will just be ignored until the firewall is re-enabled.
        /// Serialized Name: UpdateDataLakeAnalyticsAccountParameters.properties.firewallState
        /// </summary>
        public DataLakeAnalyticsFirewallState? FirewallState { get; set; }
        /// <summary>
        /// The current state of allowing or disallowing IPs originating within Azure through the firewall. If the firewall is disabled, this is not enforced.
        /// Serialized Name: UpdateDataLakeAnalyticsAccountParameters.properties.firewallAllowAzureIps
        /// </summary>
        public DataLakeAnalyticsFirewallAllowAzureIPsState? FirewallAllowAzureIPs { get; set; }
        /// <summary>
        /// The commitment tier to use for next month.
        /// Serialized Name: UpdateDataLakeAnalyticsAccountParameters.properties.newTier
        /// </summary>
        public DataLakeAnalyticsCommitmentTierType? NewTier { get; set; }
        /// <summary>
        /// The maximum supported jobs running under the account at the same time.
        /// Serialized Name: UpdateDataLakeAnalyticsAccountParameters.properties.maxJobCount
        /// </summary>
        public int? MaxJobCount { get; set; }
        /// <summary>
        /// The maximum supported degree of parallelism for this account.
        /// Serialized Name: UpdateDataLakeAnalyticsAccountParameters.properties.maxDegreeOfParallelism
        /// </summary>
        public int? MaxDegreeOfParallelism { get; set; }
        /// <summary>
        /// The maximum supported degree of parallelism per job for this account.
        /// Serialized Name: UpdateDataLakeAnalyticsAccountParameters.properties.maxDegreeOfParallelismPerJob
        /// </summary>
        public int? MaxDegreeOfParallelismPerJob { get; set; }
        /// <summary>
        /// The minimum supported priority per job for this account.
        /// Serialized Name: UpdateDataLakeAnalyticsAccountParameters.properties.minPriorityPerJob
        /// </summary>
        public int? MinPriorityPerJob { get; set; }
        /// <summary>
        /// The number of days that job metadata is retained.
        /// Serialized Name: UpdateDataLakeAnalyticsAccountParameters.properties.queryStoreRetention
        /// </summary>
        public int? QueryStoreRetention { get; set; }
    }
}
