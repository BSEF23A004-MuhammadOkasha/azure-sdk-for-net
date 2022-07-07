// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Batch.Models
{
    internal static partial class AutoStorageAuthenticationModeExtensions
    {
        public static string ToSerialString(this AutoStorageAuthenticationMode value) => value switch
        {
            AutoStorageAuthenticationMode.StorageKeys => "StorageKeys",
            AutoStorageAuthenticationMode.BatchAccountManagedIdentity => "BatchAccountManagedIdentity",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AutoStorageAuthenticationMode value.")
        };

        public static AutoStorageAuthenticationMode ToAutoStorageAuthenticationMode(this string value)
        {
            if (string.Equals(value, "StorageKeys", StringComparison.InvariantCultureIgnoreCase)) return AutoStorageAuthenticationMode.StorageKeys;
            if (string.Equals(value, "BatchAccountManagedIdentity", StringComparison.InvariantCultureIgnoreCase)) return AutoStorageAuthenticationMode.BatchAccountManagedIdentity;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AutoStorageAuthenticationMode value.");
        }
    }
}
