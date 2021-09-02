// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.EventHub.Models
{
    internal static partial class UnavailableReasonExtensions
    {
        public static string ToSerialString(this UnavailableReason value) => value switch
        {
            UnavailableReason.None => "None",
            UnavailableReason.InvalidName => "InvalidName",
            UnavailableReason.SubscriptionIsDisabled => "SubscriptionIsDisabled",
            UnavailableReason.NameInUse => "NameInUse",
            UnavailableReason.NameInLockdown => "NameInLockdown",
            UnavailableReason.TooManyNamespaceInCurrentSubscription => "TooManyNamespaceInCurrentSubscription",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown UnavailableReason value.")
        };

        public static UnavailableReason ToUnavailableReason(this string value)
        {
            if (string.Equals(value, "None", StringComparison.InvariantCultureIgnoreCase)) return UnavailableReason.None;
            if (string.Equals(value, "InvalidName", StringComparison.InvariantCultureIgnoreCase)) return UnavailableReason.InvalidName;
            if (string.Equals(value, "SubscriptionIsDisabled", StringComparison.InvariantCultureIgnoreCase)) return UnavailableReason.SubscriptionIsDisabled;
            if (string.Equals(value, "NameInUse", StringComparison.InvariantCultureIgnoreCase)) return UnavailableReason.NameInUse;
            if (string.Equals(value, "NameInLockdown", StringComparison.InvariantCultureIgnoreCase)) return UnavailableReason.NameInLockdown;
            if (string.Equals(value, "TooManyNamespaceInCurrentSubscription", StringComparison.InvariantCultureIgnoreCase)) return UnavailableReason.TooManyNamespaceInCurrentSubscription;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown UnavailableReason value.");
        }
    }
}
