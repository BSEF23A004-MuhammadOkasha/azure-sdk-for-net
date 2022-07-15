// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Properties of a managed Cassandra data center. </summary>
    public partial class CassandraDataCenterProperties
    {
        /// <summary> Initializes a new instance of CassandraDataCenterProperties. </summary>
        public CassandraDataCenterProperties()
        {
            SeedNodes = new ChangeTrackingList<CassandraDataCenterSeedNode>();
        }

        /// <summary> Initializes a new instance of CassandraDataCenterProperties. </summary>
        /// <param name="provisioningState"> The status of the resource at the time the operation was called. </param>
        /// <param name="dataCenterLocation"> The region this data center should be created in. </param>
        /// <param name="delegatedSubnetId"> Resource id of a subnet the nodes in this data center should have their network interfaces connected to. The subnet must be in the same region specified in &apos;dataCenterLocation&apos; and must be able to route to the subnet specified in the cluster&apos;s &apos;delegatedManagementSubnetId&apos; property. This resource id will be of the form &apos;/subscriptions/&lt;subscription id&gt;/resourceGroups/&lt;resource group&gt;/providers/Microsoft.Network/virtualNetworks/&lt;virtual network&gt;/subnets/&lt;subnet&gt;&apos;. </param>
        /// <param name="nodeCount"> The number of nodes the data center should have. This is the desired number. After it is set, it may take some time for the data center to be scaled to match. To monitor the number of nodes and their status, use the fetchNodeStatus method on the cluster. </param>
        /// <param name="seedNodes"> IP addresses for seed nodes in this data center. This is for reference. Generally you will want to use the seedNodes property on the cluster, which aggregates the seed nodes from all data centers in the cluster. </param>
        /// <param name="base64EncodedCassandraYamlFragment"> A fragment of a cassandra.yaml configuration file to be included in the cassandra.yaml for all nodes in this data center. The fragment should be Base64 encoded, and only a subset of keys are allowed. </param>
        /// <param name="managedDiskCustomerKeyUri"> Key uri to use for encryption of managed disks. Ensure the system assigned identity of the cluster has been assigned appropriate permissions(key get/wrap/unwrap permissions) on the key. </param>
        /// <param name="backupStorageCustomerKeyUri"> Indicates the Key Uri of the customer key to use for encryption of the backup storage account. </param>
        /// <param name="sku"> Virtual Machine SKU used for data centers. Default value is Standard_DS14_v2. </param>
        /// <param name="diskSku"> Disk SKU used for data centers. Default value is P30. </param>
        /// <param name="diskCapacity"> Number of disk used for data centers. Default value is 4. </param>
        /// <param name="doesSupportAvailabilityZone"> If the azure data center has Availability Zone support, apply it to the Virtual Machine ScaleSet that host the cassandra data center virtual machines. </param>
        internal CassandraDataCenterProperties(ManagedCassandraProvisioningState? provisioningState, AzureLocation? dataCenterLocation, ResourceIdentifier delegatedSubnetId, int? nodeCount, IReadOnlyList<CassandraDataCenterSeedNode> seedNodes, string base64EncodedCassandraYamlFragment, Uri managedDiskCustomerKeyUri, Uri backupStorageCustomerKeyUri, string sku, string diskSku, int? diskCapacity, bool? doesSupportAvailabilityZone)
        {
            ProvisioningState = provisioningState;
            DataCenterLocation = dataCenterLocation;
            DelegatedSubnetId = delegatedSubnetId;
            NodeCount = nodeCount;
            SeedNodes = seedNodes;
            Base64EncodedCassandraYamlFragment = base64EncodedCassandraYamlFragment;
            ManagedDiskCustomerKeyUri = managedDiskCustomerKeyUri;
            BackupStorageCustomerKeyUri = backupStorageCustomerKeyUri;
            Sku = sku;
            DiskSku = diskSku;
            DiskCapacity = diskCapacity;
            DoesSupportAvailabilityZone = doesSupportAvailabilityZone;
        }

        /// <summary> The status of the resource at the time the operation was called. </summary>
        public ManagedCassandraProvisioningState? ProvisioningState { get; set; }
        /// <summary> The region this data center should be created in. </summary>
        public AzureLocation? DataCenterLocation { get; set; }
        /// <summary> Resource id of a subnet the nodes in this data center should have their network interfaces connected to. The subnet must be in the same region specified in &apos;dataCenterLocation&apos; and must be able to route to the subnet specified in the cluster&apos;s &apos;delegatedManagementSubnetId&apos; property. This resource id will be of the form &apos;/subscriptions/&lt;subscription id&gt;/resourceGroups/&lt;resource group&gt;/providers/Microsoft.Network/virtualNetworks/&lt;virtual network&gt;/subnets/&lt;subnet&gt;&apos;. </summary>
        public ResourceIdentifier DelegatedSubnetId { get; set; }
        /// <summary> The number of nodes the data center should have. This is the desired number. After it is set, it may take some time for the data center to be scaled to match. To monitor the number of nodes and their status, use the fetchNodeStatus method on the cluster. </summary>
        public int? NodeCount { get; set; }
        /// <summary> IP addresses for seed nodes in this data center. This is for reference. Generally you will want to use the seedNodes property on the cluster, which aggregates the seed nodes from all data centers in the cluster. </summary>
        public IReadOnlyList<CassandraDataCenterSeedNode> SeedNodes { get; }
        /// <summary> A fragment of a cassandra.yaml configuration file to be included in the cassandra.yaml for all nodes in this data center. The fragment should be Base64 encoded, and only a subset of keys are allowed. </summary>
        public string Base64EncodedCassandraYamlFragment { get; set; }
        /// <summary> Key uri to use for encryption of managed disks. Ensure the system assigned identity of the cluster has been assigned appropriate permissions(key get/wrap/unwrap permissions) on the key. </summary>
        public Uri ManagedDiskCustomerKeyUri { get; set; }
        /// <summary> Indicates the Key Uri of the customer key to use for encryption of the backup storage account. </summary>
        public Uri BackupStorageCustomerKeyUri { get; set; }
        /// <summary> Virtual Machine SKU used for data centers. Default value is Standard_DS14_v2. </summary>
        public string Sku { get; set; }
        /// <summary> Disk SKU used for data centers. Default value is P30. </summary>
        public string DiskSku { get; set; }
        /// <summary> Number of disk used for data centers. Default value is 4. </summary>
        public int? DiskCapacity { get; set; }
        /// <summary> If the azure data center has Availability Zone support, apply it to the Virtual Machine ScaleSet that host the cassandra data center virtual machines. </summary>
        public bool? DoesSupportAvailabilityZone { get; set; }
    }
}
