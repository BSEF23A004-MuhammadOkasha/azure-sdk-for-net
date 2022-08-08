// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ApiManagement.Models
{
    internal static partial class ApiManagementServiceNameUnavailableReasonExtensions
    {
        public static string ToSerialString(this ApiManagementServiceNameUnavailableReason value) => value switch
        {
            ApiManagementServiceNameUnavailableReason.Valid => "Valid",
            ApiManagementServiceNameUnavailableReason.Invalid => "Invalid",
            ApiManagementServiceNameUnavailableReason.AlreadyExists => "AlreadyExists",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ApiManagementServiceNameUnavailableReason value.")
        };

        public static ApiManagementServiceNameUnavailableReason ToApiManagementServiceNameUnavailableReason(this string value)
        {
            if (string.Equals(value, "Valid", StringComparison.InvariantCultureIgnoreCase)) return ApiManagementServiceNameUnavailableReason.Valid;
            if (string.Equals(value, "Invalid", StringComparison.InvariantCultureIgnoreCase)) return ApiManagementServiceNameUnavailableReason.Invalid;
            if (string.Equals(value, "AlreadyExists", StringComparison.InvariantCultureIgnoreCase)) return ApiManagementServiceNameUnavailableReason.AlreadyExists;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ApiManagementServiceNameUnavailableReason value.");
        }
    }
}
