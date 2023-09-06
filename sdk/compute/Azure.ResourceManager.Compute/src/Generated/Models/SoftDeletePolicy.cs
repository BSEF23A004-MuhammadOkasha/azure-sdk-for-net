// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Contains information about the soft deletion policy of the gallery. </summary>
    internal partial class SoftDeletePolicy
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SoftDeletePolicy"/>. </summary>
        public SoftDeletePolicy()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SoftDeletePolicy"/>. </summary>
        /// <param name="isSoftDeleteEnabled"> Enables soft-deletion for resources in this gallery, allowing them to be recovered within retention time. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SoftDeletePolicy(bool? isSoftDeleteEnabled, Dictionary<string, BinaryData> rawData)
        {
            IsSoftDeleteEnabled = isSoftDeleteEnabled;
            _rawData = rawData;
        }

        /// <summary> Enables soft-deletion for resources in this gallery, allowing them to be recovered within retention time. </summary>
        public bool? IsSoftDeleteEnabled { get; set; }
    }
}
