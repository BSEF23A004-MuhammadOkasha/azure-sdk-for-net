// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary> Describes the delta health policies for the cluster upgrade. </summary>
    public partial class ClusterUpgradeDeltaHealthPolicy
    {
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
        ///
        /// </param>
        public ClusterUpgradeDeltaHealthPolicy(int maxPercentDeltaUnhealthyNodes, int maxPercentUpgradeDomainDeltaUnhealthyNodes, int maxPercentDeltaUnhealthyApplications)
        {
            MaxPercentDeltaUnhealthyNodes = maxPercentDeltaUnhealthyNodes;
            MaxPercentUpgradeDomainDeltaUnhealthyNodes = maxPercentUpgradeDomainDeltaUnhealthyNodes;
            MaxPercentDeltaUnhealthyApplications = maxPercentDeltaUnhealthyApplications;
            ApplicationDeltaHealthPolicies = new ChangeTrackingDictionary<string, ApplicationDeltaHealthPolicy>();
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
        ///
        /// </param>
        /// <param name="applicationDeltaHealthPolicies"> Defines the application delta health policy map used to evaluate the health of an application or one of its child entities when upgrading the cluster. </param>
        internal ClusterUpgradeDeltaHealthPolicy(int maxPercentDeltaUnhealthyNodes, int maxPercentUpgradeDomainDeltaUnhealthyNodes, int maxPercentDeltaUnhealthyApplications, IDictionary<string, ApplicationDeltaHealthPolicy> applicationDeltaHealthPolicies)
        {
            MaxPercentDeltaUnhealthyNodes = maxPercentDeltaUnhealthyNodes;
            MaxPercentUpgradeDomainDeltaUnhealthyNodes = maxPercentUpgradeDomainDeltaUnhealthyNodes;
            MaxPercentDeltaUnhealthyApplications = maxPercentDeltaUnhealthyApplications;
            ApplicationDeltaHealthPolicies = applicationDeltaHealthPolicies;
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
        public int MaxPercentUpgradeDomainDeltaUnhealthyNodes { get; set; }
        /// <summary>
        /// The maximum allowed percentage of applications health degradation allowed during cluster upgrades.
        /// The delta is measured between the state of the applications at the beginning of upgrade and the state of the applications at the time of the health evaluation.
        /// The check is performed after every upgrade domain upgrade completion to make sure the global state of the cluster is within tolerated limits. System services are not included in this.
        ///
        /// </summary>
        public int MaxPercentDeltaUnhealthyApplications { get; set; }
        /// <summary> Defines the application delta health policy map used to evaluate the health of an application or one of its child entities when upgrading the cluster. </summary>
        public IDictionary<string, ApplicationDeltaHealthPolicy> ApplicationDeltaHealthPolicies { get; }
    }
}
