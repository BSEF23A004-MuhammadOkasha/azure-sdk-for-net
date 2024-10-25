// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> Describes the delta health policies for the cluster upgrade. </summary>
    public partial class ClusterUpgradeDeltaHealthPolicy
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

        /// <summary> Initializes a new instance of <see cref="ClusterUpgradeDeltaHealthPolicy"/>. </summary>
        /// <param name="maxPercentDeltaUnhealthyNodes">
        /// The maximum allowed percentage of nodes health degradation allowed during cluster upgrades.
        /// The delta is measured between the state of the nodes at the beginning of upgrade and the state of the nodes at the time of the health evaluation.
        /// The check is performed after every upgrade domain upgrade completion to make sure the global state of the cluster is within tolerated limits.
        ///
        /// </param>
        public ClusterUpgradeDeltaHealthPolicy(int maxPercentDeltaUnhealthyNodes)
        {
            MaxPercentDeltaUnhealthyNodes = maxPercentDeltaUnhealthyNodes;
        }

        /// <summary> Initializes a new instance of <see cref="ClusterUpgradeDeltaHealthPolicy"/>. </summary>
        /// <param name="maxPercentDeltaUnhealthyNodes">
        /// The maximum allowed percentage of nodes health degradation allowed during cluster upgrades.
        /// The delta is measured between the state of the nodes at the beginning of upgrade and the state of the nodes at the time of the health evaluation.
        /// The check is performed after every upgrade domain upgrade completion to make sure the global state of the cluster is within tolerated limits.
        ///
        /// </param>
        /// <param name="maxPercentUpgradeDomainDeltaUnhealthyNodes">
        /// The maximum allowed percentage of upgrade domain nodes health degradation allowed during cluster upgrades.
        /// The delta is measured between the state of the upgrade domain nodes at the beginning of upgrade and the state of the upgrade domain nodes at the time of the health evaluation.
        /// The check is performed after every upgrade domain upgrade completion for all completed upgrade domains to make sure the state of the upgrade domains is within tolerated limits.
        ///
        /// </param>
        /// <param name="maxPercentDeltaUnhealthyApplications">
        /// The maximum allowed percentage of applications health degradation allowed during cluster upgrades.
        /// The delta is measured between the state of the applications at the beginning of upgrade and the state of the applications at the time of the health evaluation.
        /// The check is performed after every upgrade domain upgrade completion to make sure the global state of the cluster is within tolerated limits. System services are not included in this.
        /// NOTE: This value will overwrite the value specified in properties.UpgradeDescription.HealthPolicy.MaxPercentUnhealthyApplications
        ///
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ClusterUpgradeDeltaHealthPolicy(int maxPercentDeltaUnhealthyNodes, int? maxPercentUpgradeDomainDeltaUnhealthyNodes, int? maxPercentDeltaUnhealthyApplications, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MaxPercentDeltaUnhealthyNodes = maxPercentDeltaUnhealthyNodes;
            MaxPercentUpgradeDomainDeltaUnhealthyNodes = maxPercentUpgradeDomainDeltaUnhealthyNodes;
            MaxPercentDeltaUnhealthyApplications = maxPercentDeltaUnhealthyApplications;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ClusterUpgradeDeltaHealthPolicy"/> for deserialization. </summary>
        internal ClusterUpgradeDeltaHealthPolicy()
        {
        }

        /// <summary>
        /// The maximum allowed percentage of nodes health degradation allowed during cluster upgrades.
        /// The delta is measured between the state of the nodes at the beginning of upgrade and the state of the nodes at the time of the health evaluation.
        /// The check is performed after every upgrade domain upgrade completion to make sure the global state of the cluster is within tolerated limits.
        ///
        /// </summary>
        public int MaxPercentDeltaUnhealthyNodes { get; set; }
        /// <summary>
        /// The maximum allowed percentage of upgrade domain nodes health degradation allowed during cluster upgrades.
        /// The delta is measured between the state of the upgrade domain nodes at the beginning of upgrade and the state of the upgrade domain nodes at the time of the health evaluation.
        /// The check is performed after every upgrade domain upgrade completion for all completed upgrade domains to make sure the state of the upgrade domains is within tolerated limits.
        ///
        /// </summary>
        public int? MaxPercentUpgradeDomainDeltaUnhealthyNodes { get; set; }
        /// <summary>
        /// The maximum allowed percentage of applications health degradation allowed during cluster upgrades.
        /// The delta is measured between the state of the applications at the beginning of upgrade and the state of the applications at the time of the health evaluation.
        /// The check is performed after every upgrade domain upgrade completion to make sure the global state of the cluster is within tolerated limits. System services are not included in this.
        /// NOTE: This value will overwrite the value specified in properties.UpgradeDescription.HealthPolicy.MaxPercentUnhealthyApplications
        ///
        /// </summary>
        public int? MaxPercentDeltaUnhealthyApplications { get; set; }
    }
}
