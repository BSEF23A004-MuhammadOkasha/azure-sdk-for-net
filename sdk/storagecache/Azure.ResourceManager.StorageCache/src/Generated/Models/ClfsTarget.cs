// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary> Properties pertaining to the ClfsTarget. </summary>
    internal partial class ClfsTarget
    {
        /// <summary> Initializes a new instance of ClfsTarget. </summary>
        public ClfsTarget()
        {
        }

        /// <summary> Initializes a new instance of ClfsTarget. </summary>
        /// <param name="target"> Resource ID of storage container. </param>
        internal ClfsTarget(ResourceIdentifier target)
        {
            Target = target;
        }

        /// <summary> Resource ID of storage container. </summary>
        public ResourceIdentifier Target { get; set; }
    }
}
