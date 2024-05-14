// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> VM-Host placement policy properties. </summary>
    public partial class VmHostPlacementPolicyProperties : PlacementPolicyProperties
    {
        /// <summary> Initializes a new instance of <see cref="VmHostPlacementPolicyProperties"/>. </summary>
        /// <param name="vmMembers"> Virtual machine members list. </param>
        /// <param name="hostMembers"> Host members list. </param>
        /// <param name="affinityType"> placement policy affinity type. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vmMembers"/> or <paramref name="hostMembers"/> is null. </exception>
        public VmHostPlacementPolicyProperties(IEnumerable<ResourceIdentifier> vmMembers, IEnumerable<string> hostMembers, AvsPlacementPolicyAffinityType affinityType)
        {
            Argument.AssertNotNull(vmMembers, nameof(vmMembers));
            Argument.AssertNotNull(hostMembers, nameof(hostMembers));

            VmMembers = vmMembers.ToList();
            HostMembers = hostMembers.ToList();
            AffinityType = affinityType;
            PolicyType = PlacementPolicyType.VmHost;
        }

        /// <summary> Initializes a new instance of <see cref="VmHostPlacementPolicyProperties"/>. </summary>
        /// <param name="policyType"> placement policy type. </param>
        /// <param name="state"> Whether the placement policy is enabled or disabled. </param>
        /// <param name="displayName"> Display name of the placement policy. </param>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="vmMembers"> Virtual machine members list. </param>
        /// <param name="hostMembers"> Host members list. </param>
        /// <param name="affinityType"> placement policy affinity type. </param>
        /// <param name="affinityStrength"> vm-host placement policy affinity strength (should/must). </param>
        /// <param name="azureHybridBenefitType"> placement policy azure hybrid benefit opt-in type. </param>
        internal VmHostPlacementPolicyProperties(PlacementPolicyType policyType, PlacementPolicyState? state, string displayName, PlacementPolicyProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData, IList<ResourceIdentifier> vmMembers, IList<string> hostMembers, AvsPlacementPolicyAffinityType affinityType, VmHostPlacementPolicyAffinityStrength? affinityStrength, AzureHybridBenefitType? azureHybridBenefitType) : base(policyType, state, displayName, provisioningState, serializedAdditionalRawData)
        {
            VmMembers = vmMembers;
            HostMembers = hostMembers;
            AffinityType = affinityType;
            AffinityStrength = affinityStrength;
            AzureHybridBenefitType = azureHybridBenefitType;
            PolicyType = policyType;
        }

        /// <summary> Initializes a new instance of <see cref="VmHostPlacementPolicyProperties"/> for deserialization. </summary>
        internal VmHostPlacementPolicyProperties()
        {
        }

        /// <summary> Virtual machine members list. </summary>
        public IList<ResourceIdentifier> VmMembers { get; }
        /// <summary> Host members list. </summary>
        public IList<string> HostMembers { get; }
        /// <summary> placement policy affinity type. </summary>
        public AvsPlacementPolicyAffinityType AffinityType { get; set; }
        /// <summary> vm-host placement policy affinity strength (should/must). </summary>
        public VmHostPlacementPolicyAffinityStrength? AffinityStrength { get; set; }
        /// <summary> placement policy azure hybrid benefit opt-in type. </summary>
        public AzureHybridBenefitType? AzureHybridBenefitType { get; set; }
    }
}
