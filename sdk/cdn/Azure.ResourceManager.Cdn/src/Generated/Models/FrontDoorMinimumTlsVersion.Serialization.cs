// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Cdn.Models
{
    internal static partial class FrontDoorMinimumTlsVersionExtensions
    {
        public static string ToSerialString(this FrontDoorMinimumTlsVersion value) => value switch
        {
            FrontDoorMinimumTlsVersion.Tls1_0 => "TLS10",
            FrontDoorMinimumTlsVersion.Tls1_2 => "TLS12",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown FrontDoorMinimumTlsVersion value.")
        };

        public static FrontDoorMinimumTlsVersion ToFrontDoorMinimumTlsVersion(this string value)
        {
            if (string.Equals(value, "TLS10", StringComparison.InvariantCultureIgnoreCase)) return FrontDoorMinimumTlsVersion.Tls1_0;
            if (string.Equals(value, "TLS12", StringComparison.InvariantCultureIgnoreCase)) return FrontDoorMinimumTlsVersion.Tls1_2;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown FrontDoorMinimumTlsVersion value.");
        }
    }
}
