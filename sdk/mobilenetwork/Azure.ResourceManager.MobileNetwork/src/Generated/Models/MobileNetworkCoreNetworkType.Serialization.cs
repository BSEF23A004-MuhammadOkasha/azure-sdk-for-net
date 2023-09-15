// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    internal static partial class MobileNetworkCoreNetworkTypeExtensions
    {
        public static string ToSerialString(this MobileNetworkCoreNetworkType value) => value switch
        {
            MobileNetworkCoreNetworkType.FiveGC => "5GC",
            MobileNetworkCoreNetworkType.Epc => "EPC",
            MobileNetworkCoreNetworkType.Epc5GC => "EPC + 5GC",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown MobileNetworkCoreNetworkType value.")
        };

        public static MobileNetworkCoreNetworkType ToMobileNetworkCoreNetworkType(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "5GC")) return MobileNetworkCoreNetworkType.FiveGC;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "EPC")) return MobileNetworkCoreNetworkType.Epc;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "EPC + 5GC")) return MobileNetworkCoreNetworkType.Epc5GC;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown MobileNetworkCoreNetworkType value.");
        }
    }
}
