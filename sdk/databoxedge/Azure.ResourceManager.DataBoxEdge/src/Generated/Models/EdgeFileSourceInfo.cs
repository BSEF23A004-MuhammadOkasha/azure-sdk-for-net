// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> File source details. </summary>
    public partial class EdgeFileSourceInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="EdgeFileSourceInfo"/>. </summary>
        /// <param name="shareId"> File share ID. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="shareId"/> is null. </exception>
        public EdgeFileSourceInfo(ResourceIdentifier shareId)
        {
            Argument.AssertNotNull(shareId, nameof(shareId));

            ShareId = shareId;
        }

        /// <summary> Initializes a new instance of <see cref="EdgeFileSourceInfo"/>. </summary>
        /// <param name="shareId"> File share ID. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal EdgeFileSourceInfo(ResourceIdentifier shareId, Dictionary<string, BinaryData> rawData)
        {
            ShareId = shareId;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="EdgeFileSourceInfo"/> for deserialization. </summary>
        internal EdgeFileSourceInfo()
        {
        }

        /// <summary> File share ID. </summary>
        public ResourceIdentifier ShareId { get; set; }
    }
}
