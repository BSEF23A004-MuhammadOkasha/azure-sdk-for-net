// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Batch.Models
{
    internal static partial class BatchAccountKeyTypeExtensions
    {
        public static string ToSerialString(this BatchAccountKeyType value) => value switch
        {
            BatchAccountKeyType.Primary => "Primary",
            BatchAccountKeyType.Secondary => "Secondary",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown BatchAccountKeyType value.")
        };

        public static BatchAccountKeyType ToBatchAccountKeyType(this string value)
        {
            if (string.Equals(value, "Primary", StringComparison.InvariantCultureIgnoreCase)) return BatchAccountKeyType.Primary;
            if (string.Equals(value, "Secondary", StringComparison.InvariantCultureIgnoreCase)) return BatchAccountKeyType.Secondary;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown BatchAccountKeyType value.");
        }
    }
}
