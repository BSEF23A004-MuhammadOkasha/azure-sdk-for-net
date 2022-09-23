// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AppService.Models
{
    internal static partial class WebSiteAvailabilityStateExtensions
    {
        public static string ToSerialString(this WebSiteAvailabilityState value) => value switch
        {
            WebSiteAvailabilityState.Normal => "Normal",
            WebSiteAvailabilityState.Limited => "Limited",
            WebSiteAvailabilityState.DisasterRecoveryMode => "DisasterRecoveryMode",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown WebSiteAvailabilityState value.")
        };

        public static WebSiteAvailabilityState ToWebSiteAvailabilityState(this string value)
        {
            if (string.Equals(value, "Normal", StringComparison.InvariantCultureIgnoreCase)) return WebSiteAvailabilityState.Normal;
            if (string.Equals(value, "Limited", StringComparison.InvariantCultureIgnoreCase)) return WebSiteAvailabilityState.Limited;
            if (string.Equals(value, "DisasterRecoveryMode", StringComparison.InvariantCultureIgnoreCase)) return WebSiteAvailabilityState.DisasterRecoveryMode;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown WebSiteAvailabilityState value.");
        }
    }
}
