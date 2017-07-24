// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Store.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataLake;
    using Microsoft.Azure.Management.DataLake.Store;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for EncryptionState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EncryptionState
    {
        [EnumMember(Value = "Enabled")]
        Enabled,
        [EnumMember(Value = "Disabled")]
        Disabled
    }
    internal static class EncryptionStateEnumExtension
    {
        internal static string ToSerializedValue(this EncryptionState? value)  =>
            value == null ? null : ((EncryptionState)value).ToSerializedValue();

        internal static string ToSerializedValue(this EncryptionState value)
        {
            switch( value )
            {
                case EncryptionState.Enabled:
                    return "Enabled";
                case EncryptionState.Disabled:
                    return "Disabled";
            }
            return null;
        }

        internal static EncryptionState? ParseEncryptionState(this string value)
        {
            switch( value )
            {
                case "Enabled":
                    return EncryptionState.Enabled;
                case "Disabled":
                    return EncryptionState.Disabled;
            }
            return null;
        }
    }
}
