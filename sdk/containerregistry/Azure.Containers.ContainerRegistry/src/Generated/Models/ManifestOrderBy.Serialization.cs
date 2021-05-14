// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Containers.ContainerRegistry
{
    internal static partial class ManifestOrderByExtensions
    {
        public static string ToSerialString(this ManifestOrderBy value) => value switch
        {
            ManifestOrderBy.None => "none",
            ManifestOrderBy.LastUpdatedOnDescending => "timedesc",
            ManifestOrderBy.LastUpdatedOnAscending => "timeasc",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ManifestOrderBy value.")
        };

        public static ManifestOrderBy ToManifestOrderBy(this string value)
        {
            if (string.Equals(value, "none", StringComparison.InvariantCultureIgnoreCase)) return ManifestOrderBy.None;
            if (string.Equals(value, "timedesc", StringComparison.InvariantCultureIgnoreCase)) return ManifestOrderBy.LastUpdatedOnDescending;
            if (string.Equals(value, "timeasc", StringComparison.InvariantCultureIgnoreCase)) return ManifestOrderBy.LastUpdatedOnAscending;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ManifestOrderBy value.");
        }
    }
}
