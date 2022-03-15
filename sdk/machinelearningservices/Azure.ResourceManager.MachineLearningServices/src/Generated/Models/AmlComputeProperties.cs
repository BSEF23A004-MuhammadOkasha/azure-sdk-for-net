// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> AML Compute properties. </summary>
    public partial class AmlComputeProperties
    {
        /// <summary> Initializes a new instance of AmlComputeProperties. </summary>
        public AmlComputeProperties()
        {
            Errors = new ChangeTrackingList<ErrorResponse>();
            PropertyBag = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of AmlComputeProperties. </summary>
        /// <param name="osType"> Compute OS Type. </param>
        /// <param name="vmSize"> Virtual Machine Size. </param>
        /// <param name="vmPriority"> Virtual Machine priority. </param>
        /// <param name="virtualMachineImage"> Virtual Machine image for AML Compute - windows only. </param>
        /// <param name="isolatedNetwork"> Network is isolated or not. </param>
        /// <param name="scaleSettings"> Scale settings for AML Compute. </param>
        /// <param name="userAccountCredentials"> Credentials for an administrator user account that will be created on each compute node. </param>
        /// <param name="subnet"> Virtual network subnet resource ID the compute nodes belong to. </param>
        /// <param name="remoteLoginPortPublicAccess"> State of the public SSH port. Possible values are: Disabled - Indicates that the public ssh port is closed on all nodes of the cluster. Enabled - Indicates that the public ssh port is open on all nodes of the cluster. NotSpecified - Indicates that the public ssh port is closed on all nodes of the cluster if VNet is defined, else is open all public nodes. It can be default only during cluster creation time, after creation it will be either enabled or disabled. </param>
        /// <param name="allocationState"> Allocation state of the compute. Possible values are: steady - Indicates that the compute is not resizing. There are no changes to the number of compute nodes in the compute in progress. A compute enters this state when it is created and when no operations are being performed on the compute to change the number of compute nodes. resizing - Indicates that the compute is resizing; that is, compute nodes are being added to or removed from the compute. </param>
        /// <param name="allocationStateTransitionTime"> The time at which the compute entered its current allocation state. </param>
        /// <param name="errors"> Collection of errors encountered by various compute nodes during node setup. </param>
        /// <param name="currentNodeCount"> The number of compute nodes currently assigned to the compute. </param>
        /// <param name="targetNodeCount"> The target number of compute nodes for the compute. If the allocationState is resizing, this property denotes the target node count for the ongoing resize operation. If the allocationState is steady, this property denotes the target node count for the previous resize operation. </param>
        /// <param name="nodeStateCounts"> Counts of various node states on the compute. </param>
        /// <param name="enableNodePublicIp"> Enable or disable node public IP address provisioning. Possible values are: Possible values are: true - Indicates that the compute nodes will have public IPs provisioned. false - Indicates that the compute nodes will have a private endpoint and no public IPs. </param>
        /// <param name="propertyBag"> A property bag containing additional properties. </param>
        internal AmlComputeProperties(OsType? osType, string vmSize, VmPriority? vmPriority, WritableSubResource virtualMachineImage, bool? isolatedNetwork, ScaleSettings scaleSettings, UserAccountCredentials userAccountCredentials, WritableSubResource subnet, RemoteLoginPortPublicAccess? remoteLoginPortPublicAccess, AllocationState? allocationState, DateTimeOffset? allocationStateTransitionTime, IReadOnlyList<ErrorResponse> errors, int? currentNodeCount, int? targetNodeCount, NodeStateCounts nodeStateCounts, bool? enableNodePublicIp, IDictionary<string, object> propertyBag)
        {
            OsType = osType;
            VmSize = vmSize;
            VmPriority = vmPriority;
            VirtualMachineImage = virtualMachineImage;
            IsolatedNetwork = isolatedNetwork;
            ScaleSettings = scaleSettings;
            UserAccountCredentials = userAccountCredentials;
            Subnet = subnet;
            RemoteLoginPortPublicAccess = remoteLoginPortPublicAccess;
            AllocationState = allocationState;
            AllocationStateTransitionTime = allocationStateTransitionTime;
            Errors = errors;
            CurrentNodeCount = currentNodeCount;
            TargetNodeCount = targetNodeCount;
            NodeStateCounts = nodeStateCounts;
            EnableNodePublicIp = enableNodePublicIp;
            PropertyBag = propertyBag;
        }

        /// <summary> Compute OS Type. </summary>
        public OsType? OsType { get; set; }
        /// <summary> Virtual Machine Size. </summary>
        public string VmSize { get; set; }
        /// <summary> Virtual Machine priority. </summary>
        public VmPriority? VmPriority { get; set; }
        /// <summary> Virtual Machine image for AML Compute - windows only. </summary>
        internal WritableSubResource VirtualMachineImage { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier VirtualMachineImageId
        {
            get => VirtualMachineImage is null ? default : VirtualMachineImage.Id;
            set
            {
                if (VirtualMachineImage is null)
                    VirtualMachineImage = new WritableSubResource();
                VirtualMachineImage.Id = value;
            }
        }

        /// <summary> Network is isolated or not. </summary>
        public bool? IsolatedNetwork { get; set; }
        /// <summary> Scale settings for AML Compute. </summary>
        public ScaleSettings ScaleSettings { get; set; }
        /// <summary> Credentials for an administrator user account that will be created on each compute node. </summary>
        public UserAccountCredentials UserAccountCredentials { get; set; }
        /// <summary> Virtual network subnet resource ID the compute nodes belong to. </summary>
        internal WritableSubResource Subnet { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier SubnetId
        {
            get => Subnet is null ? default : Subnet.Id;
            set
            {
                if (Subnet is null)
                    Subnet = new WritableSubResource();
                Subnet.Id = value;
            }
        }

        /// <summary> State of the public SSH port. Possible values are: Disabled - Indicates that the public ssh port is closed on all nodes of the cluster. Enabled - Indicates that the public ssh port is open on all nodes of the cluster. NotSpecified - Indicates that the public ssh port is closed on all nodes of the cluster if VNet is defined, else is open all public nodes. It can be default only during cluster creation time, after creation it will be either enabled or disabled. </summary>
        public RemoteLoginPortPublicAccess? RemoteLoginPortPublicAccess { get; set; }
        /// <summary> Allocation state of the compute. Possible values are: steady - Indicates that the compute is not resizing. There are no changes to the number of compute nodes in the compute in progress. A compute enters this state when it is created and when no operations are being performed on the compute to change the number of compute nodes. resizing - Indicates that the compute is resizing; that is, compute nodes are being added to or removed from the compute. </summary>
        public AllocationState? AllocationState { get; }
        /// <summary> The time at which the compute entered its current allocation state. </summary>
        public DateTimeOffset? AllocationStateTransitionTime { get; }
        /// <summary> Collection of errors encountered by various compute nodes during node setup. </summary>
        public IReadOnlyList<ErrorResponse> Errors { get; }
        /// <summary> The number of compute nodes currently assigned to the compute. </summary>
        public int? CurrentNodeCount { get; }
        /// <summary> The target number of compute nodes for the compute. If the allocationState is resizing, this property denotes the target node count for the ongoing resize operation. If the allocationState is steady, this property denotes the target node count for the previous resize operation. </summary>
        public int? TargetNodeCount { get; }
        /// <summary> Counts of various node states on the compute. </summary>
        public NodeStateCounts NodeStateCounts { get; }
        /// <summary> Enable or disable node public IP address provisioning. Possible values are: Possible values are: true - Indicates that the compute nodes will have public IPs provisioned. false - Indicates that the compute nodes will have a private endpoint and no public IPs. </summary>
        public bool? EnableNodePublicIp { get; set; }
        /// <summary> A property bag containing additional properties. </summary>
        public IDictionary<string, object> PropertyBag { get; }
    }
}
