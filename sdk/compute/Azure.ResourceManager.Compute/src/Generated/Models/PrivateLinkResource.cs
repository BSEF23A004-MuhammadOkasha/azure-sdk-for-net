// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> A private link resource. </summary>
    public partial class PrivateLinkResource : Resource<TenantResourceIdentifier>
    {
        /// <summary> Initializes a new instance of PrivateLinkResource. </summary>
        internal PrivateLinkResource()
        {
            RequiredMembers = new ChangeTrackingList<string>();
            RequiredZoneNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of PrivateLinkResource. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="groupId"> The private link resource group id. </param>
        /// <param name="requiredMembers"> The private link resource required member names. </param>
        /// <param name="requiredZoneNames"> The private link resource DNS zone name. </param>
        internal PrivateLinkResource(TenantResourceIdentifier id, string name, ResourceType type, string groupId, IReadOnlyList<string> requiredMembers, IReadOnlyList<string> requiredZoneNames) : base(id, name, type)
        {
            GroupId = groupId;
            RequiredMembers = requiredMembers;
            RequiredZoneNames = requiredZoneNames;
        }

        /// <summary> The private link resource group id. </summary>
        public string GroupId { get; }
        /// <summary> The private link resource required member names. </summary>
        public IReadOnlyList<string> RequiredMembers { get; }
        /// <summary> The private link resource DNS zone name. </summary>
        public IReadOnlyList<string> RequiredZoneNames { get; }
    }
}
