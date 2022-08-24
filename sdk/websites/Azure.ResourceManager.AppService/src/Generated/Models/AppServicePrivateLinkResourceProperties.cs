// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary>
    /// Properties of a private link resource
    /// Serialized Name: PrivateLinkResourceProperties
    /// </summary>
    public partial class AppServicePrivateLinkResourceProperties
    {
        /// <summary> Initializes a new instance of AppServicePrivateLinkResourceProperties. </summary>
        internal AppServicePrivateLinkResourceProperties()
        {
            RequiredMembers = new ChangeTrackingList<string>();
            RequiredZoneNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of AppServicePrivateLinkResourceProperties. </summary>
        /// <param name="groupId">
        /// GroupId of a private link resource
        /// Serialized Name: PrivateLinkResourceProperties.groupId
        /// </param>
        /// <param name="requiredMembers">
        /// RequiredMembers of a private link resource
        /// Serialized Name: PrivateLinkResourceProperties.requiredMembers
        /// </param>
        /// <param name="requiredZoneNames">
        /// RequiredZoneNames of a private link resource
        /// Serialized Name: PrivateLinkResourceProperties.requiredZoneNames
        /// </param>
        internal AppServicePrivateLinkResourceProperties(string groupId, IReadOnlyList<string> requiredMembers, IReadOnlyList<string> requiredZoneNames)
        {
            GroupId = groupId;
            RequiredMembers = requiredMembers;
            RequiredZoneNames = requiredZoneNames;
        }

        /// <summary>
        /// GroupId of a private link resource
        /// Serialized Name: PrivateLinkResourceProperties.groupId
        /// </summary>
        public string GroupId { get; }
        /// <summary>
        /// RequiredMembers of a private link resource
        /// Serialized Name: PrivateLinkResourceProperties.requiredMembers
        /// </summary>
        public IReadOnlyList<string> RequiredMembers { get; }
        /// <summary>
        /// RequiredZoneNames of a private link resource
        /// Serialized Name: PrivateLinkResourceProperties.requiredZoneNames
        /// </summary>
        public IReadOnlyList<string> RequiredZoneNames { get; }
    }
}
