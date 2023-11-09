// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> The resource type aliases definition. </summary>
    public partial class ResourceTypeAliases
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ResourceTypeAliases"/>. </summary>
        internal ResourceTypeAliases()
        {
            Aliases = new ChangeTrackingList<ResourceTypeAlias>();
        }

        /// <summary> Initializes a new instance of <see cref="ResourceTypeAliases"/>. </summary>
        /// <param name="resourceType"> The resource type name. </param>
        /// <param name="aliases"> The aliases for property names. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceTypeAliases(string resourceType, IReadOnlyList<ResourceTypeAlias> aliases, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ResourceType = resourceType;
            Aliases = aliases;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The resource type name. </summary>
        public string ResourceType { get; }
        /// <summary> The aliases for property names. </summary>
        public IReadOnlyList<ResourceTypeAlias> Aliases { get; }
    }
}
