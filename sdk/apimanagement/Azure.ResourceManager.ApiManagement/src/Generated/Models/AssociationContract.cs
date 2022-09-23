// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Association entity details. </summary>
    public partial class AssociationContract : ResourceData
    {
        /// <summary> Initializes a new instance of AssociationContract. </summary>
        public AssociationContract()
        {
        }

        /// <summary> Initializes a new instance of AssociationContract. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> Provisioning state. </param>
        internal AssociationContract(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AssociationEntityProvisioningState? provisioningState) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
        }

        /// <summary> Provisioning state. </summary>
        public AssociationEntityProvisioningState? ProvisioningState { get; set; }
    }
}
