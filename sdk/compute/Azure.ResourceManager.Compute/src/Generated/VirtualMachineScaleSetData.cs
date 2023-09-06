// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary>
    /// A class representing the VirtualMachineScaleSet data model.
    /// Describes a Virtual Machine Scale Set.
    /// </summary>
    public partial class VirtualMachineScaleSetData : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetData"/>. </summary>
        /// <param name="location"> The location. </param>
        public VirtualMachineScaleSetData(AzureLocation location) : base(location)
        {
            Zones = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> The virtual machine scale set sku. </param>
        /// <param name="plan"> Specifies information about the marketplace image used to create the virtual machine. This element is only used for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use.  In the Azure portal, find the marketplace image that you want to use and then click **Want to deploy programmatically, Get Started -&gt;**. Enter any required information and then click **Save**. </param>
        /// <param name="identity"> The identity of the virtual machine scale set, if configured. </param>
        /// <param name="zones"> The virtual machine scale set zones. NOTE: Availability zones can only be set when you create the scale set. </param>
        /// <param name="extendedLocation"> The extended location of the Virtual Machine Scale Set. </param>
        /// <param name="upgradePolicy"> The upgrade policy. </param>
        /// <param name="automaticRepairsPolicy"> Policy for automatic repairs. </param>
        /// <param name="virtualMachineProfile"> The virtual machine profile. </param>
        /// <param name="provisioningState"> The provisioning state, which only appears in the response. </param>
        /// <param name="overprovision"> Specifies whether the Virtual Machine Scale Set should be overprovisioned. </param>
        /// <param name="doNotRunExtensionsOnOverprovisionedVms"> When Overprovision is enabled, extensions are launched only on the requested number of VMs which are finally kept. This property will hence ensure that the extensions do not run on the extra overprovisioned VMs. </param>
        /// <param name="uniqueId"> Specifies the ID which uniquely identifies a Virtual Machine Scale Set. </param>
        /// <param name="singlePlacementGroup"> When true this limits the scale set to a single placement group, of max size 100 virtual machines. NOTE: If singlePlacementGroup is true, it may be modified to false. However, if singlePlacementGroup is false, it may not be modified to true. </param>
        /// <param name="zoneBalance"> Whether to force strictly even Virtual Machine distribution cross x-zones in case there is zone outage. zoneBalance property can only be set if the zones property of the scale set contains more than one zone. If there are no zones or only one zone specified, then zoneBalance property should not be set. </param>
        /// <param name="platformFaultDomainCount"> Fault Domain count for each placement group. </param>
        /// <param name="proximityPlacementGroup"> Specifies information about the proximity placement group that the virtual machine scale set should be assigned to. Minimum api-version: 2018-04-01. </param>
        /// <param name="hostGroup"> Specifies information about the dedicated host group that the virtual machine scale set resides in. Minimum api-version: 2020-06-01. </param>
        /// <param name="additionalCapabilities"> Specifies additional capabilities enabled or disabled on the Virtual Machines in the Virtual Machine Scale Set. For instance: whether the Virtual Machines have the capability to support attaching managed data disks with UltraSSD_LRS storage account type. </param>
        /// <param name="scaleInPolicy"> Specifies the policies applied when scaling in Virtual Machines in the Virtual Machine Scale Set. </param>
        /// <param name="orchestrationMode"> Specifies the orchestration mode for the virtual machine scale set. </param>
        /// <param name="spotRestorePolicy"> Specifies the Spot Restore properties for the virtual machine scale set. </param>
        /// <param name="priorityMixPolicy"> Specifies the desired targets for mixing Spot and Regular priority VMs within the same VMSS Flex instance. </param>
        /// <param name="timeCreated"> Specifies the time at which the Virtual Machine Scale Set resource was created. Minimum api-version: 2021-11-01. </param>
        /// <param name="isMaximumCapacityConstrained"> Optional property which must either be set to True or omitted. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualMachineScaleSetData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ComputeSku sku, ComputePlan plan, ManagedServiceIdentity identity, IList<string> zones, ExtendedLocation extendedLocation, VirtualMachineScaleSetUpgradePolicy upgradePolicy, AutomaticRepairsPolicy automaticRepairsPolicy, VirtualMachineScaleSetVmProfile virtualMachineProfile, string provisioningState, bool? overprovision, bool? doNotRunExtensionsOnOverprovisionedVms, string uniqueId, bool? singlePlacementGroup, bool? zoneBalance, int? platformFaultDomainCount, WritableSubResource proximityPlacementGroup, WritableSubResource hostGroup, AdditionalCapabilities additionalCapabilities, ScaleInPolicy scaleInPolicy, OrchestrationMode? orchestrationMode, SpotRestorePolicy spotRestorePolicy, VirtualMachineScaleSetPriorityMixPolicy priorityMixPolicy, DateTimeOffset? timeCreated, bool? isMaximumCapacityConstrained, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Sku = sku;
            Plan = plan;
            Identity = identity;
            Zones = zones;
            ExtendedLocation = extendedLocation;
            UpgradePolicy = upgradePolicy;
            AutomaticRepairsPolicy = automaticRepairsPolicy;
            VirtualMachineProfile = virtualMachineProfile;
            ProvisioningState = provisioningState;
            Overprovision = overprovision;
            DoNotRunExtensionsOnOverprovisionedVms = doNotRunExtensionsOnOverprovisionedVms;
            UniqueId = uniqueId;
            SinglePlacementGroup = singlePlacementGroup;
            ZoneBalance = zoneBalance;
            PlatformFaultDomainCount = platformFaultDomainCount;
            ProximityPlacementGroup = proximityPlacementGroup;
            HostGroup = hostGroup;
            AdditionalCapabilities = additionalCapabilities;
            ScaleInPolicy = scaleInPolicy;
            OrchestrationMode = orchestrationMode;
            SpotRestorePolicy = spotRestorePolicy;
            PriorityMixPolicy = priorityMixPolicy;
            TimeCreated = timeCreated;
            IsMaximumCapacityConstrained = isMaximumCapacityConstrained;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetData"/> for deserialization. </summary>
        internal VirtualMachineScaleSetData()
        {
        }

        /// <summary> The virtual machine scale set sku. </summary>
        public ComputeSku Sku { get; set; }
        /// <summary> Specifies information about the marketplace image used to create the virtual machine. This element is only used for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use.  In the Azure portal, find the marketplace image that you want to use and then click **Want to deploy programmatically, Get Started -&gt;**. Enter any required information and then click **Save**. </summary>
        public ComputePlan Plan { get; set; }
        /// <summary> The identity of the virtual machine scale set, if configured. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The virtual machine scale set zones. NOTE: Availability zones can only be set when you create the scale set. </summary>
        public IList<string> Zones { get; }
        /// <summary> The extended location of the Virtual Machine Scale Set. </summary>
        public ExtendedLocation ExtendedLocation { get; set; }
        /// <summary> The upgrade policy. </summary>
        public VirtualMachineScaleSetUpgradePolicy UpgradePolicy { get; set; }
        /// <summary> Policy for automatic repairs. </summary>
        public AutomaticRepairsPolicy AutomaticRepairsPolicy { get; set; }
        /// <summary> The virtual machine profile. </summary>
        public VirtualMachineScaleSetVmProfile VirtualMachineProfile { get; set; }
        /// <summary> The provisioning state, which only appears in the response. </summary>
        public string ProvisioningState { get; }
        /// <summary> Specifies whether the Virtual Machine Scale Set should be overprovisioned. </summary>
        public bool? Overprovision { get; set; }
        /// <summary> When Overprovision is enabled, extensions are launched only on the requested number of VMs which are finally kept. This property will hence ensure that the extensions do not run on the extra overprovisioned VMs. </summary>
        public bool? DoNotRunExtensionsOnOverprovisionedVms { get; set; }
        /// <summary> Specifies the ID which uniquely identifies a Virtual Machine Scale Set. </summary>
        public string UniqueId { get; }
        /// <summary> When true this limits the scale set to a single placement group, of max size 100 virtual machines. NOTE: If singlePlacementGroup is true, it may be modified to false. However, if singlePlacementGroup is false, it may not be modified to true. </summary>
        public bool? SinglePlacementGroup { get; set; }
        /// <summary> Whether to force strictly even Virtual Machine distribution cross x-zones in case there is zone outage. zoneBalance property can only be set if the zones property of the scale set contains more than one zone. If there are no zones or only one zone specified, then zoneBalance property should not be set. </summary>
        public bool? ZoneBalance { get; set; }
        /// <summary> Fault Domain count for each placement group. </summary>
        public int? PlatformFaultDomainCount { get; set; }
        /// <summary> Specifies information about the proximity placement group that the virtual machine scale set should be assigned to. Minimum api-version: 2018-04-01. </summary>
        internal WritableSubResource ProximityPlacementGroup { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier ProximityPlacementGroupId
        {
            get => ProximityPlacementGroup is null ? default : ProximityPlacementGroup.Id;
            set
            {
                if (ProximityPlacementGroup is null)
                    ProximityPlacementGroup = new WritableSubResource();
                ProximityPlacementGroup.Id = value;
            }
        }

        /// <summary> Specifies information about the dedicated host group that the virtual machine scale set resides in. Minimum api-version: 2020-06-01. </summary>
        internal WritableSubResource HostGroup { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier HostGroupId
        {
            get => HostGroup is null ? default : HostGroup.Id;
            set
            {
                if (HostGroup is null)
                    HostGroup = new WritableSubResource();
                HostGroup.Id = value;
            }
        }

        /// <summary> Specifies additional capabilities enabled or disabled on the Virtual Machines in the Virtual Machine Scale Set. For instance: whether the Virtual Machines have the capability to support attaching managed data disks with UltraSSD_LRS storage account type. </summary>
        public AdditionalCapabilities AdditionalCapabilities { get; set; }
        /// <summary> Specifies the policies applied when scaling in Virtual Machines in the Virtual Machine Scale Set. </summary>
        public ScaleInPolicy ScaleInPolicy { get; set; }
        /// <summary> Specifies the orchestration mode for the virtual machine scale set. </summary>
        public OrchestrationMode? OrchestrationMode { get; set; }
        /// <summary> Specifies the Spot Restore properties for the virtual machine scale set. </summary>
        public SpotRestorePolicy SpotRestorePolicy { get; set; }
        /// <summary> Specifies the desired targets for mixing Spot and Regular priority VMs within the same VMSS Flex instance. </summary>
        public VirtualMachineScaleSetPriorityMixPolicy PriorityMixPolicy { get; set; }
        /// <summary> Specifies the time at which the Virtual Machine Scale Set resource was created. Minimum api-version: 2021-11-01. </summary>
        public DateTimeOffset? TimeCreated { get; }
        /// <summary> Optional property which must either be set to True or omitted. </summary>
        public bool? IsMaximumCapacityConstrained { get; set; }
    }
}
