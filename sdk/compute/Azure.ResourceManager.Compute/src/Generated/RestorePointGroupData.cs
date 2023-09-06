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
    /// A class representing the RestorePointGroup data model.
    /// Create or update Restore Point collection parameters.
    /// </summary>
    public partial class RestorePointGroupData : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RestorePointGroupData"/>. </summary>
        /// <param name="location"> The location. </param>
        public RestorePointGroupData(AzureLocation location) : base(location)
        {
            RestorePoints = new ChangeTrackingList<RestorePointData>();
        }

        /// <summary> Initializes a new instance of <see cref="RestorePointGroupData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="source"> The properties of the source resource that this restore point collection is created from. </param>
        /// <param name="provisioningState"> The provisioning state of the restore point collection. </param>
        /// <param name="restorePointGroupId"> The unique id of the restore point collection. </param>
        /// <param name="restorePoints"> A list containing all restore points created under this restore point collection. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RestorePointGroupData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, RestorePointGroupSource source, string provisioningState, string restorePointGroupId, IReadOnlyList<RestorePointData> restorePoints, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Source = source;
            ProvisioningState = provisioningState;
            RestorePointGroupId = restorePointGroupId;
            RestorePoints = restorePoints;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="RestorePointGroupData"/> for deserialization. </summary>
        internal RestorePointGroupData()
        {
        }

        /// <summary> The properties of the source resource that this restore point collection is created from. </summary>
        public RestorePointGroupSource Source { get; set; }
        /// <summary> The provisioning state of the restore point collection. </summary>
        public string ProvisioningState { get; }
        /// <summary> The unique id of the restore point collection. </summary>
        public string RestorePointGroupId { get; }
        /// <summary> A list containing all restore points created under this restore point collection. </summary>
        public IReadOnlyList<RestorePointData> RestorePoints { get; }
    }
}
