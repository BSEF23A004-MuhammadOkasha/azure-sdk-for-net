// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> User assigned identity properties. </summary>
    internal partial class DataBoxUserAssignedIdentity
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DataBoxUserAssignedIdentity"/>. </summary>
        public DataBoxUserAssignedIdentity()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataBoxUserAssignedIdentity"/>. </summary>
        /// <param name="resourceId"> Arm resource id for user assigned identity to be used to fetch MSI token. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DataBoxUserAssignedIdentity(ResourceIdentifier resourceId, Dictionary<string, BinaryData> rawData)
        {
            ResourceId = resourceId;
            _rawData = rawData;
        }

        /// <summary> Arm resource id for user assigned identity to be used to fetch MSI token. </summary>
        public ResourceIdentifier ResourceId { get; set; }
    }
}
