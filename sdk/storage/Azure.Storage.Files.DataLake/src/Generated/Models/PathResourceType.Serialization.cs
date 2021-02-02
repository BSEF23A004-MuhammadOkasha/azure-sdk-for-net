// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Storage.Files.DataLake.Models
{
    internal static class PathResourceTypeExtensions
    {
        public static string ToSerialString(this PathResourceType value) => value switch
        {
            PathResourceType.Directory => "directory",
            PathResourceType.File => "file",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown PathResourceType value.")
        };

        public static PathResourceType ToPathResourceType(this string value)
        {
            if (string.Equals(value, "directory", StringComparison.InvariantCultureIgnoreCase)) return PathResourceType.Directory;
            if (string.Equals(value, "file", StringComparison.InvariantCultureIgnoreCase)) return PathResourceType.File;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown PathResourceType value.");
        }
    }
}
