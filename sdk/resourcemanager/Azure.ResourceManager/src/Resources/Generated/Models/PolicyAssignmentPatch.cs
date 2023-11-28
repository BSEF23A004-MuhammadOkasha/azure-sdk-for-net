// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> The policy assignment for Patch request. </summary>
    public partial class PolicyAssignmentPatch
    {
        /// <summary> Initializes a new instance of <see cref="PolicyAssignmentPatch"/>. </summary>
        public PolicyAssignmentPatch()
        {
            ResourceSelectors = new ChangeTrackingList<ResourceSelector>();
            Overrides = new ChangeTrackingList<PolicyOverride>();
        }

        /// <summary> The location of the policy assignment. Only required when utilizing managed identity. </summary>
        public AzureLocation? Location { get; set; }
        /// <summary> The managed identity associated with the policy assignment. Current supported identity types: None, SystemAssigned, UserAssigned. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The resource selector list to filter policies by resource properties. </summary>
        public IList<ResourceSelector> ResourceSelectors { get; }
        /// <summary> The policy property value override. </summary>
        public IList<PolicyOverride> Overrides { get; }
    }
}
