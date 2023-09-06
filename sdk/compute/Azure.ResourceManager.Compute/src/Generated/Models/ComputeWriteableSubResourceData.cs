// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The ComputeWriteableSubResourceData. </summary>
    public partial class ComputeWriteableSubResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ComputeWriteableSubResourceData"/>. </summary>
        public ComputeWriteableSubResourceData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ComputeWriteableSubResourceData"/>. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ComputeWriteableSubResourceData(ResourceIdentifier id, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            _rawData = rawData;
        }
    }
}
