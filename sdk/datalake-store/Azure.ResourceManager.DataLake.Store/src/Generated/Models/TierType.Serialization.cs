// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataLake.Store.Models
{
    internal static partial class TierTypeExtensions
    {
        public static string ToSerialString(this TierType value) => value switch
        {
            TierType.Consumption => "Consumption",
            TierType.Commitment1TB => "Commitment_1TB",
            TierType.Commitment10TB => "Commitment_10TB",
            TierType.Commitment100TB => "Commitment_100TB",
            TierType.Commitment500TB => "Commitment_500TB",
            TierType.Commitment1PB => "Commitment_1PB",
            TierType.Commitment5PB => "Commitment_5PB",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown TierType value.")
        };

        public static TierType ToTierType(this string value)
        {
            if (string.Equals(value, "Consumption", StringComparison.InvariantCultureIgnoreCase)) return TierType.Consumption;
            if (string.Equals(value, "Commitment_1TB", StringComparison.InvariantCultureIgnoreCase)) return TierType.Commitment1TB;
            if (string.Equals(value, "Commitment_10TB", StringComparison.InvariantCultureIgnoreCase)) return TierType.Commitment10TB;
            if (string.Equals(value, "Commitment_100TB", StringComparison.InvariantCultureIgnoreCase)) return TierType.Commitment100TB;
            if (string.Equals(value, "Commitment_500TB", StringComparison.InvariantCultureIgnoreCase)) return TierType.Commitment500TB;
            if (string.Equals(value, "Commitment_1PB", StringComparison.InvariantCultureIgnoreCase)) return TierType.Commitment1PB;
            if (string.Equals(value, "Commitment_5PB", StringComparison.InvariantCultureIgnoreCase)) return TierType.Commitment5PB;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown TierType value.");
        }
    }
}
