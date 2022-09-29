// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Search.Models
{
    internal static partial class SharedSearchServicePrivateLinkResourceStatusExtensions
    {
        public static string ToSerialString(this SharedSearchServicePrivateLinkResourceStatus value) => value switch
        {
            SharedSearchServicePrivateLinkResourceStatus.Pending => "Pending",
            SharedSearchServicePrivateLinkResourceStatus.Approved => "Approved",
            SharedSearchServicePrivateLinkResourceStatus.Rejected => "Rejected",
            SharedSearchServicePrivateLinkResourceStatus.Disconnected => "Disconnected",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SharedSearchServicePrivateLinkResourceStatus value.")
        };

        public static SharedSearchServicePrivateLinkResourceStatus ToSharedSearchServicePrivateLinkResourceStatus(this string value)
        {
            if (string.Equals(value, "Pending", StringComparison.InvariantCultureIgnoreCase)) return SharedSearchServicePrivateLinkResourceStatus.Pending;
            if (string.Equals(value, "Approved", StringComparison.InvariantCultureIgnoreCase)) return SharedSearchServicePrivateLinkResourceStatus.Approved;
            if (string.Equals(value, "Rejected", StringComparison.InvariantCultureIgnoreCase)) return SharedSearchServicePrivateLinkResourceStatus.Rejected;
            if (string.Equals(value, "Disconnected", StringComparison.InvariantCultureIgnoreCase)) return SharedSearchServicePrivateLinkResourceStatus.Disconnected;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SharedSearchServicePrivateLinkResourceStatus value.");
        }
    }
}
