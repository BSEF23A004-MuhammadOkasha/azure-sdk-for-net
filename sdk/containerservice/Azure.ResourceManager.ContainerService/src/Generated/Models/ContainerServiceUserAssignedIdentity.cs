// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Details about a user assigned identity. </summary>
    public partial class ContainerServiceUserAssignedIdentity
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ContainerServiceUserAssignedIdentity"/>. </summary>
        public ContainerServiceUserAssignedIdentity()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerServiceUserAssignedIdentity"/>. </summary>
        /// <param name="resourceId"> The resource ID of the user assigned identity. </param>
        /// <param name="clientId"> The client ID of the user assigned identity. </param>
        /// <param name="objectId"> The object ID of the user assigned identity. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerServiceUserAssignedIdentity(ResourceIdentifier resourceId, Guid? clientId, Guid? objectId, Dictionary<string, BinaryData> rawData)
        {
            ResourceId = resourceId;
            ClientId = clientId;
            ObjectId = objectId;
            _rawData = rawData;
        }

        /// <summary> The resource ID of the user assigned identity. </summary>
        public ResourceIdentifier ResourceId { get; set; }
        /// <summary> The client ID of the user assigned identity. </summary>
        public Guid? ClientId { get; set; }
        /// <summary> The object ID of the user assigned identity. </summary>
        public Guid? ObjectId { get; set; }
    }
}
