// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> The status of the Batch private endpoint connection. </summary>
    public enum BatchPrivateLinkServiceConnectionStatus
    {
        /// <summary> The private endpoint connection is approved and can be used to access Batch account. </summary>
        Approved,
        /// <summary> The private endpoint connection is pending and cannot be used to access Batch account. </summary>
        Pending,
        /// <summary> The private endpoint connection is rejected and cannot be used to access Batch account. </summary>
        Rejected,
        /// <summary> The private endpoint connection is disconnected and cannot be used to access Batch account. </summary>
        Disconnected
    }
}
