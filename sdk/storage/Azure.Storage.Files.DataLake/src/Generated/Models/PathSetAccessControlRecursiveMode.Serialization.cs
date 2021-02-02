// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Storage.Files.DataLake.Models
{
    internal static class PathSetAccessControlRecursiveModeExtensions
    {
        public static string ToSerialString(this PathSetAccessControlRecursiveMode value) => value switch
        {
            PathSetAccessControlRecursiveMode.Set => "set",
            PathSetAccessControlRecursiveMode.Modify => "modify",
            PathSetAccessControlRecursiveMode.Remove => "remove",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown PathSetAccessControlRecursiveMode value.")
        };

        public static PathSetAccessControlRecursiveMode ToPathSetAccessControlRecursiveMode(this string value)
        {
            if (string.Equals(value, "set", StringComparison.InvariantCultureIgnoreCase)) return PathSetAccessControlRecursiveMode.Set;
            if (string.Equals(value, "modify", StringComparison.InvariantCultureIgnoreCase)) return PathSetAccessControlRecursiveMode.Modify;
            if (string.Equals(value, "remove", StringComparison.InvariantCultureIgnoreCase)) return PathSetAccessControlRecursiveMode.Remove;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown PathSetAccessControlRecursiveMode value.");
        }
    }
}
