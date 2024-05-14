// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ArcScVmm.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ArcScVmm
{
    /// <summary>
    /// A class representing the ScVmmVirtualMachine data model.
    /// The VirtualMachines resource definition.
    /// </summary>
    public partial class ScVmmVirtualMachineData : TrackedResourceData
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

        /// <summary> Initializes a new instance of <see cref="ScVmmVirtualMachineData"/>. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation"> The extended location. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="extendedLocation"/> is null. </exception>
        public ScVmmVirtualMachineData(AzureLocation location, ExtendedLocation extendedLocation) : base(location)
        {
            Argument.AssertNotNull(extendedLocation, nameof(extendedLocation));

            ExtendedLocation = extendedLocation;
            Checkpoints = new ChangeTrackingList<Checkpoint>();
            AvailabilitySets = new ChangeTrackingList<AvailabilitySetListItem>();
        }

        /// <summary> Initializes a new instance of <see cref="ScVmmVirtualMachineData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation"> The extended location. </param>
        /// <param name="inventoryItemId"> Gets or sets the inventory Item ID for the resource. </param>
        /// <param name="vmmServerId"> ARM Id of the vmmServer resource in which this resource resides. </param>
        /// <param name="cloudId"> ARM Id of the cloud resource to use for deploying the vm. </param>
        /// <param name="templateId"> ARM Id of the template resource to use for deploying the vm. </param>
        /// <param name="checkpointType"> Type of checkpoint supported for the vm. </param>
        /// <param name="checkpoints"> Checkpoints in the vm. </param>
        /// <param name="availabilitySets"> Availability Sets in vm. </param>
        /// <param name="osProfile"> OS properties. </param>
        /// <param name="hardwareProfile"> Hardware properties. </param>
        /// <param name="networkProfile"> Network properties. </param>
        /// <param name="storageProfile"> Storage properties. </param>
        /// <param name="vmName"> VMName is the name of VM on the SCVMM server. </param>
        /// <param name="uuid"> Unique ID of the virtual machine. </param>
        /// <param name="generation"> Gets or sets the generation for the vm. </param>
        /// <param name="powerState"> Gets the power state of the virtual machine. </param>
        /// <param name="provisioningState"> Gets or sets the provisioning state. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ScVmmVirtualMachineData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ExtendedLocation extendedLocation, string inventoryItemId, string vmmServerId, string cloudId, string templateId, string checkpointType, IList<Checkpoint> checkpoints, IList<AvailabilitySetListItem> availabilitySets, OSProfile osProfile, HardwareProfile hardwareProfile, NetworkProfile networkProfile, StorageProfile storageProfile, string vmName, string uuid, int? generation, string powerState, string provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            ExtendedLocation = extendedLocation;
            InventoryItemId = inventoryItemId;
            VmmServerId = vmmServerId;
            CloudId = cloudId;
            TemplateId = templateId;
            CheckpointType = checkpointType;
            Checkpoints = checkpoints;
            AvailabilitySets = availabilitySets;
            OSProfile = osProfile;
            HardwareProfile = hardwareProfile;
            NetworkProfile = networkProfile;
            StorageProfile = storageProfile;
            VmName = vmName;
            Uuid = uuid;
            Generation = generation;
            PowerState = powerState;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ScVmmVirtualMachineData"/> for deserialization. </summary>
        internal ScVmmVirtualMachineData()
        {
        }

        /// <summary> The extended location. </summary>
        public ExtendedLocation ExtendedLocation { get; set; }
        /// <summary> Gets or sets the inventory Item ID for the resource. </summary>
        public string InventoryItemId { get; set; }
        /// <summary> ARM Id of the vmmServer resource in which this resource resides. </summary>
        public string VmmServerId { get; set; }
        /// <summary> ARM Id of the cloud resource to use for deploying the vm. </summary>
        public string CloudId { get; set; }
        /// <summary> ARM Id of the template resource to use for deploying the vm. </summary>
        public string TemplateId { get; set; }
        /// <summary> Type of checkpoint supported for the vm. </summary>
        public string CheckpointType { get; set; }
        /// <summary> Checkpoints in the vm. </summary>
        public IList<Checkpoint> Checkpoints { get; }
        /// <summary> Availability Sets in vm. </summary>
        public IList<AvailabilitySetListItem> AvailabilitySets { get; }
        /// <summary> OS properties. </summary>
        public OSProfile OSProfile { get; set; }
        /// <summary> Hardware properties. </summary>
        public HardwareProfile HardwareProfile { get; set; }
        /// <summary> Network properties. </summary>
        internal NetworkProfile NetworkProfile { get; set; }
        /// <summary> Gets or sets the list of network interfaces associated with the virtual machine. </summary>
        public IList<NetworkInterfaces> NetworkInterfaces
        {
            get
            {
                if (NetworkProfile is null)
                    NetworkProfile = new NetworkProfile();
                return NetworkProfile.NetworkInterfaces;
            }
        }

        /// <summary> Storage properties. </summary>
        internal StorageProfile StorageProfile { get; set; }
        /// <summary> Gets or sets the list of virtual disks associated with the virtual machine. </summary>
        public IList<VirtualDisk> StorageDisks
        {
            get
            {
                if (StorageProfile is null)
                    StorageProfile = new StorageProfile();
                return StorageProfile.Disks;
            }
        }

        /// <summary> VMName is the name of VM on the SCVMM server. </summary>
        public string VmName { get; set; }
        /// <summary> Unique ID of the virtual machine. </summary>
        public string Uuid { get; set; }
        /// <summary> Gets or sets the generation for the vm. </summary>
        public int? Generation { get; set; }
        /// <summary> Gets the power state of the virtual machine. </summary>
        public string PowerState { get; }
        /// <summary> Gets or sets the provisioning state. </summary>
        public string ProvisioningState { get; }
    }
}
