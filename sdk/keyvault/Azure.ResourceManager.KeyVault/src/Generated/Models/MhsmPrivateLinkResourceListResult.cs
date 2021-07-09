// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.KeyVault
{
    /// <summary> A list of private link resources. </summary>
    public partial class MhsmPrivateLinkResourceListResult
    {
        /// <summary> Initializes a new instance of MhsmPrivateLinkResourceListResult. </summary>
        internal MhsmPrivateLinkResourceListResult()
        {
            Value = new ChangeTrackingList<MhsmPrivateLinkResource>();
        }

        /// <summary> Initializes a new instance of MhsmPrivateLinkResourceListResult. </summary>
        /// <param name="value"> Array of private link resources. </param>
        internal MhsmPrivateLinkResourceListResult(IReadOnlyList<MhsmPrivateLinkResource> value)
        {
            Value = value;
        }

        /// <summary> Array of private link resources. </summary>
        public IReadOnlyList<MhsmPrivateLinkResource> Value { get; }
    }
}
