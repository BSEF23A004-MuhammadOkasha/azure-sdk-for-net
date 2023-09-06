// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary>
    /// A class representing the ProximityPlacementGroup data model.
    /// Specifies information about the proximity placement group.
    /// </summary>
    public partial class ProximityPlacementGroupData : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ProximityPlacementGroupData"/>. </summary>
        /// <param name="location"> The location. </param>
        public ProximityPlacementGroupData(AzureLocation location) : base(location)
        {
            Zones = new ChangeTrackingList<string>();
            VirtualMachines = new ChangeTrackingList<ComputeSubResourceDataWithColocationStatus>();
            VirtualMachineScaleSets = new ChangeTrackingList<ComputeSubResourceDataWithColocationStatus>();
            AvailabilitySets = new ChangeTrackingList<ComputeSubResourceDataWithColocationStatus>();
        }

        /// <summary> Initializes a new instance of <see cref="ProximityPlacementGroupData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="zones"> Specifies the Availability Zone where virtual machine, virtual machine scale set or availability set associated with the  proximity placement group can be created. </param>
        /// <param name="proximityPlacementGroupType"> Specifies the type of the proximity placement group. Possible values are: **Standard** : Co-locate resources within an Azure region or Availability Zone. **Ultra** : For future use. </param>
        /// <param name="virtualMachines"> A list of references to all virtual machines in the proximity placement group. </param>
        /// <param name="virtualMachineScaleSets"> A list of references to all virtual machine scale sets in the proximity placement group. </param>
        /// <param name="availabilitySets"> A list of references to all availability sets in the proximity placement group. </param>
        /// <param name="colocationStatus"> Describes colocation status of the Proximity Placement Group. </param>
        /// <param name="intent"> Specifies the user intent of the proximity placement group. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ProximityPlacementGroupData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, IList<string> zones, ProximityPlacementGroupType? proximityPlacementGroupType, IReadOnlyList<ComputeSubResourceDataWithColocationStatus> virtualMachines, IReadOnlyList<ComputeSubResourceDataWithColocationStatus> virtualMachineScaleSets, IReadOnlyList<ComputeSubResourceDataWithColocationStatus> availabilitySets, InstanceViewStatus colocationStatus, ProximityPlacementGroupPropertiesIntent intent, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Zones = zones;
            ProximityPlacementGroupType = proximityPlacementGroupType;
            VirtualMachines = virtualMachines;
            VirtualMachineScaleSets = virtualMachineScaleSets;
            AvailabilitySets = availabilitySets;
            ColocationStatus = colocationStatus;
            Intent = intent;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ProximityPlacementGroupData"/> for deserialization. </summary>
        internal ProximityPlacementGroupData()
        {
        }

        /// <summary> Specifies the Availability Zone where virtual machine, virtual machine scale set or availability set associated with the  proximity placement group can be created. </summary>
        public IList<string> Zones { get; }
        /// <summary> Specifies the type of the proximity placement group. Possible values are: **Standard** : Co-locate resources within an Azure region or Availability Zone. **Ultra** : For future use. </summary>
        public ProximityPlacementGroupType? ProximityPlacementGroupType { get; set; }
        /// <summary> A list of references to all virtual machines in the proximity placement group. </summary>
        public IReadOnlyList<ComputeSubResourceDataWithColocationStatus> VirtualMachines { get; }
        /// <summary> A list of references to all virtual machine scale sets in the proximity placement group. </summary>
        public IReadOnlyList<ComputeSubResourceDataWithColocationStatus> VirtualMachineScaleSets { get; }
        /// <summary> A list of references to all availability sets in the proximity placement group. </summary>
        public IReadOnlyList<ComputeSubResourceDataWithColocationStatus> AvailabilitySets { get; }
        /// <summary> Describes colocation status of the Proximity Placement Group. </summary>
        public InstanceViewStatus ColocationStatus { get; set; }
        /// <summary> Specifies the user intent of the proximity placement group. </summary>
        internal ProximityPlacementGroupPropertiesIntent Intent { get; set; }
        /// <summary> Specifies possible sizes of virtual machines that can be created in the proximity placement group. </summary>
        public IList<string> IntentVmSizes
        {
            get
            {
                if (Intent is null)
                    Intent = new ProximityPlacementGroupPropertiesIntent();
                return Intent.VmSizes;
            }
        }
    }
}
