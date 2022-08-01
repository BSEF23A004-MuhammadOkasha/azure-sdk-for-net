// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HDInsight;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary>
    /// The properties of cluster.
    /// Serialized Name: ClusterGetProperties
    /// </summary>
    public partial class HDInsightClusterProperties
    {
        /// <summary> Initializes a new instance of HDInsightClusterProperties. </summary>
        /// <param name="clusterDefinition">
        /// The cluster definition.
        /// Serialized Name: ClusterGetProperties.clusterDefinition
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterDefinition"/> is null. </exception>
        public HDInsightClusterProperties(HDInsightClusterDefinition clusterDefinition)
        {
            if (clusterDefinition == null)
            {
                throw new ArgumentNullException(nameof(clusterDefinition));
            }

            ClusterDefinition = clusterDefinition;
            Errors = new ChangeTrackingList<Errors>();
            ConnectivityEndpoints = new ChangeTrackingList<ConnectivityEndpoint>();
            PrivateLinkConfigurations = new ChangeTrackingList<PrivateLinkConfiguration>();
            PrivateEndpointConnections = new ChangeTrackingList<HDInsightPrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of HDInsightClusterProperties. </summary>
        /// <param name="clusterVersion">
        /// The version of the cluster.
        /// Serialized Name: ClusterGetProperties.clusterVersion
        /// </param>
        /// <param name="clusterHdpVersion">
        /// The hdp version of the cluster.
        /// Serialized Name: ClusterGetProperties.clusterHdpVersion
        /// </param>
        /// <param name="osType">
        /// The type of operating system.
        /// Serialized Name: ClusterGetProperties.osType
        /// </param>
        /// <param name="tier">
        /// The cluster tier.
        /// Serialized Name: ClusterGetProperties.tier
        /// </param>
        /// <param name="clusterId">
        /// The cluster id.
        /// Serialized Name: ClusterGetProperties.clusterId
        /// </param>
        /// <param name="clusterDefinition">
        /// The cluster definition.
        /// Serialized Name: ClusterGetProperties.clusterDefinition
        /// </param>
        /// <param name="kafkaRestProperties">
        /// The cluster kafka rest proxy configuration.
        /// Serialized Name: ClusterGetProperties.kafkaRestProperties
        /// </param>
        /// <param name="securityProfile">
        /// The security profile.
        /// Serialized Name: ClusterGetProperties.securityProfile
        /// </param>
        /// <param name="computeProfile">
        /// The compute profile.
        /// Serialized Name: ClusterGetProperties.computeProfile
        /// </param>
        /// <param name="provisioningState">
        /// The provisioning state, which only appears in the response.
        /// Serialized Name: ClusterGetProperties.provisioningState
        /// </param>
        /// <param name="createdDate">
        /// The date on which the cluster was created.
        /// Serialized Name: ClusterGetProperties.createdDate
        /// </param>
        /// <param name="clusterState">
        /// The state of the cluster.
        /// Serialized Name: ClusterGetProperties.clusterState
        /// </param>
        /// <param name="quotaInfo">
        /// The quota information.
        /// Serialized Name: ClusterGetProperties.quotaInfo
        /// </param>
        /// <param name="errors">
        /// The list of errors.
        /// Serialized Name: ClusterGetProperties.errors
        /// </param>
        /// <param name="connectivityEndpoints">
        /// The list of connectivity endpoints.
        /// Serialized Name: ClusterGetProperties.connectivityEndpoints
        /// </param>
        /// <param name="diskEncryptionProperties">
        /// The disk encryption properties.
        /// Serialized Name: ClusterGetProperties.diskEncryptionProperties
        /// </param>
        /// <param name="encryptionInTransitProperties">
        /// The encryption-in-transit properties.
        /// Serialized Name: ClusterGetProperties.encryptionInTransitProperties
        /// </param>
        /// <param name="storageProfile">
        /// The storage profile.
        /// Serialized Name: ClusterGetProperties.storageProfile
        /// </param>
        /// <param name="minSupportedTlsVersion">
        /// The minimal supported tls version.
        /// Serialized Name: ClusterGetProperties.minSupportedTlsVersion
        /// </param>
        /// <param name="excludedServicesConfig">
        /// The excluded services config.
        /// Serialized Name: ClusterGetProperties.excludedServicesConfig
        /// </param>
        /// <param name="networkProperties">
        /// The network properties.
        /// Serialized Name: ClusterGetProperties.networkProperties
        /// </param>
        /// <param name="computeIsolationProperties">
        /// The compute isolation properties.
        /// Serialized Name: ClusterGetProperties.computeIsolationProperties
        /// </param>
        /// <param name="privateLinkConfigurations">
        /// The private link configurations.
        /// Serialized Name: ClusterGetProperties.privateLinkConfigurations
        /// </param>
        /// <param name="privateEndpointConnections">
        /// The list of private endpoint connections.
        /// Serialized Name: ClusterGetProperties.privateEndpointConnections
        /// </param>
        internal HDInsightClusterProperties(string clusterVersion, string clusterHdpVersion, OSType? osType, HDInsightTier? tier, string clusterId, HDInsightClusterDefinition clusterDefinition, KafkaRestProperties kafkaRestProperties, SecurityProfile securityProfile, ComputeProfile computeProfile, HDInsightClusterProvisioningState? provisioningState, string createdDate, string clusterState, QuotaInfo quotaInfo, IList<Errors> errors, IList<ConnectivityEndpoint> connectivityEndpoints, DiskEncryptionProperties diskEncryptionProperties, EncryptionInTransitProperties encryptionInTransitProperties, StorageProfile storageProfile, string minSupportedTlsVersion, ExcludedServicesConfig excludedServicesConfig, NetworkProperties networkProperties, ComputeIsolationProperties computeIsolationProperties, IList<PrivateLinkConfiguration> privateLinkConfigurations, IReadOnlyList<HDInsightPrivateEndpointConnectionData> privateEndpointConnections)
        {
            ClusterVersion = clusterVersion;
            ClusterHdpVersion = clusterHdpVersion;
            OSType = osType;
            Tier = tier;
            ClusterId = clusterId;
            ClusterDefinition = clusterDefinition;
            KafkaRestProperties = kafkaRestProperties;
            SecurityProfile = securityProfile;
            ComputeProfile = computeProfile;
            ProvisioningState = provisioningState;
            CreatedDate = createdDate;
            ClusterState = clusterState;
            QuotaInfo = quotaInfo;
            Errors = errors;
            ConnectivityEndpoints = connectivityEndpoints;
            DiskEncryptionProperties = diskEncryptionProperties;
            EncryptionInTransitProperties = encryptionInTransitProperties;
            StorageProfile = storageProfile;
            MinSupportedTlsVersion = minSupportedTlsVersion;
            ExcludedServicesConfig = excludedServicesConfig;
            NetworkProperties = networkProperties;
            ComputeIsolationProperties = computeIsolationProperties;
            PrivateLinkConfigurations = privateLinkConfigurations;
            PrivateEndpointConnections = privateEndpointConnections;
        }

        /// <summary>
        /// The version of the cluster.
        /// Serialized Name: ClusterGetProperties.clusterVersion
        /// </summary>
        public string ClusterVersion { get; set; }
        /// <summary>
        /// The hdp version of the cluster.
        /// Serialized Name: ClusterGetProperties.clusterHdpVersion
        /// </summary>
        public string ClusterHdpVersion { get; set; }
        /// <summary>
        /// The type of operating system.
        /// Serialized Name: ClusterGetProperties.osType
        /// </summary>
        public OSType? OSType { get; set; }
        /// <summary>
        /// The cluster tier.
        /// Serialized Name: ClusterGetProperties.tier
        /// </summary>
        public HDInsightTier? Tier { get; set; }
        /// <summary>
        /// The cluster id.
        /// Serialized Name: ClusterGetProperties.clusterId
        /// </summary>
        public string ClusterId { get; set; }
        /// <summary>
        /// The cluster definition.
        /// Serialized Name: ClusterGetProperties.clusterDefinition
        /// </summary>
        public HDInsightClusterDefinition ClusterDefinition { get; set; }
        /// <summary>
        /// The cluster kafka rest proxy configuration.
        /// Serialized Name: ClusterGetProperties.kafkaRestProperties
        /// </summary>
        public KafkaRestProperties KafkaRestProperties { get; set; }
        /// <summary>
        /// The security profile.
        /// Serialized Name: ClusterGetProperties.securityProfile
        /// </summary>
        public SecurityProfile SecurityProfile { get; set; }
        /// <summary>
        /// The compute profile.
        /// Serialized Name: ClusterGetProperties.computeProfile
        /// </summary>
        internal ComputeProfile ComputeProfile { get; set; }
        /// <summary>
        /// The list of roles in the cluster.
        /// Serialized Name: ComputeProfile.roles
        /// </summary>
        public IList<HDInsightClusterRole> ComputeRoles
        {
            get
            {
                if (ComputeProfile is null)
                    ComputeProfile = new ComputeProfile();
                return ComputeProfile.Roles;
            }
        }

        /// <summary>
        /// The provisioning state, which only appears in the response.
        /// Serialized Name: ClusterGetProperties.provisioningState
        /// </summary>
        public HDInsightClusterProvisioningState? ProvisioningState { get; set; }
        /// <summary>
        /// The date on which the cluster was created.
        /// Serialized Name: ClusterGetProperties.createdDate
        /// </summary>
        public string CreatedDate { get; set; }
        /// <summary>
        /// The state of the cluster.
        /// Serialized Name: ClusterGetProperties.clusterState
        /// </summary>
        public string ClusterState { get; set; }
        /// <summary>
        /// The quota information.
        /// Serialized Name: ClusterGetProperties.quotaInfo
        /// </summary>
        internal QuotaInfo QuotaInfo { get; set; }
        /// <summary>
        /// The cores used by the cluster.
        /// Serialized Name: QuotaInfo.coresUsed
        /// </summary>
        public int? QuotaInfoCoresUsed
        {
            get => QuotaInfo is null ? default : QuotaInfo.CoresUsed;
            set
            {
                if (QuotaInfo is null)
                    QuotaInfo = new QuotaInfo();
                QuotaInfo.CoresUsed = value;
            }
        }

        /// <summary>
        /// The list of errors.
        /// Serialized Name: ClusterGetProperties.errors
        /// </summary>
        public IList<Errors> Errors { get; }
        /// <summary>
        /// The list of connectivity endpoints.
        /// Serialized Name: ClusterGetProperties.connectivityEndpoints
        /// </summary>
        public IList<ConnectivityEndpoint> ConnectivityEndpoints { get; }
        /// <summary>
        /// The disk encryption properties.
        /// Serialized Name: ClusterGetProperties.diskEncryptionProperties
        /// </summary>
        public DiskEncryptionProperties DiskEncryptionProperties { get; set; }
        /// <summary>
        /// The encryption-in-transit properties.
        /// Serialized Name: ClusterGetProperties.encryptionInTransitProperties
        /// </summary>
        internal EncryptionInTransitProperties EncryptionInTransitProperties { get; set; }
        /// <summary>
        /// Indicates whether or not inter cluster node communication is encrypted in transit.
        /// Serialized Name: EncryptionInTransitProperties.isEncryptionInTransitEnabled
        /// </summary>
        public bool? IsEncryptionInTransitEnabled
        {
            get => EncryptionInTransitProperties is null ? default : EncryptionInTransitProperties.IsEncryptionInTransitEnabled;
            set
            {
                if (EncryptionInTransitProperties is null)
                    EncryptionInTransitProperties = new EncryptionInTransitProperties();
                EncryptionInTransitProperties.IsEncryptionInTransitEnabled = value;
            }
        }

        /// <summary>
        /// The storage profile.
        /// Serialized Name: ClusterGetProperties.storageProfile
        /// </summary>
        internal StorageProfile StorageProfile { get; set; }
        /// <summary>
        /// The list of storage accounts in the cluster.
        /// Serialized Name: StorageProfile.storageaccounts
        /// </summary>
        public IList<StorageAccount> StorageStorageaccounts
        {
            get
            {
                if (StorageProfile is null)
                    StorageProfile = new StorageProfile();
                return StorageProfile.Storageaccounts;
            }
        }

        /// <summary>
        /// The minimal supported tls version.
        /// Serialized Name: ClusterGetProperties.minSupportedTlsVersion
        /// </summary>
        public string MinSupportedTlsVersion { get; set; }
        /// <summary>
        /// The excluded services config.
        /// Serialized Name: ClusterGetProperties.excludedServicesConfig
        /// </summary>
        public ExcludedServicesConfig ExcludedServicesConfig { get; set; }
        /// <summary>
        /// The network properties.
        /// Serialized Name: ClusterGetProperties.networkProperties
        /// </summary>
        public NetworkProperties NetworkProperties { get; set; }
        /// <summary>
        /// The compute isolation properties.
        /// Serialized Name: ClusterGetProperties.computeIsolationProperties
        /// </summary>
        public ComputeIsolationProperties ComputeIsolationProperties { get; set; }
        /// <summary>
        /// The private link configurations.
        /// Serialized Name: ClusterGetProperties.privateLinkConfigurations
        /// </summary>
        public IList<PrivateLinkConfiguration> PrivateLinkConfigurations { get; }
        /// <summary>
        /// The list of private endpoint connections.
        /// Serialized Name: ClusterGetProperties.privateEndpointConnections
        /// </summary>
        public IReadOnlyList<HDInsightPrivateEndpointConnectionData> PrivateEndpointConnections { get; }
    }
}
