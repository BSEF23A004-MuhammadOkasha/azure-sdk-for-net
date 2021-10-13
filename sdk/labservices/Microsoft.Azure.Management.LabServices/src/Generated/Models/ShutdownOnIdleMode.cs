// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.LabServices.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ShutdownOnIdleMode.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ShutdownOnIdleMode
    {
        /// <summary>
        /// The VM won't be shut down when it is idle.
        /// </summary>
        [EnumMember(Value = "None")]
        None,
        /// <summary>
        /// The VM will be considered as idle when there is no keyboard or
        /// mouse input.
        /// </summary>
        [EnumMember(Value = "UserAbsence")]
        UserAbsence,
        /// <summary>
        /// The VM will be considered as idle when user is absent and the
        /// resource (CPU and disk) consumption is low.
        /// </summary>
        [EnumMember(Value = "LowUsage")]
        LowUsage
    }
    internal static class ShutdownOnIdleModeEnumExtension
    {
        internal static string ToSerializedValue(this ShutdownOnIdleMode? value)
        {
            return value == null ? null : ((ShutdownOnIdleMode)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ShutdownOnIdleMode value)
        {
            switch( value )
            {
                case ShutdownOnIdleMode.None:
                    return "None";
                case ShutdownOnIdleMode.UserAbsence:
                    return "UserAbsence";
                case ShutdownOnIdleMode.LowUsage:
                    return "LowUsage";
            }
            return null;
        }

        internal static ShutdownOnIdleMode? ParseShutdownOnIdleMode(this string value)
        {
            switch( value )
            {
                case "None":
                    return ShutdownOnIdleMode.None;
                case "UserAbsence":
                    return ShutdownOnIdleMode.UserAbsence;
                case "LowUsage":
                    return ShutdownOnIdleMode.LowUsage;
            }
            return null;
        }
    }
}
