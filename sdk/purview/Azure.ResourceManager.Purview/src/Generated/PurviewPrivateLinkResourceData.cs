// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Purview.Models;

namespace Azure.ResourceManager.Purview
{
    /// <summary>
    /// A class representing the PurviewPrivateLinkResource data model.
    /// A privately linkable resource.
    /// </summary>
    public partial class PurviewPrivateLinkResourceData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PurviewPrivateLinkResourceData"/>. </summary>
        internal PurviewPrivateLinkResourceData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PurviewPrivateLinkResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The private link resource properties. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PurviewPrivateLinkResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, PurviewPrivateLinkResourceProperties properties, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The private link resource properties. </summary>
        public PurviewPrivateLinkResourceProperties Properties { get; }
    }
}
