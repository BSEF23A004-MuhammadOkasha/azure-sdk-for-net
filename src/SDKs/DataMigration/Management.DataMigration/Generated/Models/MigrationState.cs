// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for MigrationState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MigrationState
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "InProgress")]
        InProgress,
        [EnumMember(Value = "Failed")]
        Failed,
        [EnumMember(Value = "Warning")]
        Warning,
        [EnumMember(Value = "Completed")]
        Completed,
        [EnumMember(Value = "Skipped")]
        Skipped
    }
    internal static class MigrationStateEnumExtension
    {
        internal static string ToSerializedValue(this MigrationState? value)
        {
            return value == null ? null : ((MigrationState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this MigrationState value)
        {
            switch( value )
            {
                case MigrationState.None:
                    return "None";
                case MigrationState.InProgress:
                    return "InProgress";
                case MigrationState.Failed:
                    return "Failed";
                case MigrationState.Warning:
                    return "Warning";
                case MigrationState.Completed:
                    return "Completed";
                case MigrationState.Skipped:
                    return "Skipped";
            }
            return null;
        }

        internal static MigrationState? ParseMigrationState(this string value)
        {
            switch( value )
            {
                case "None":
                    return MigrationState.None;
                case "InProgress":
                    return MigrationState.InProgress;
                case "Failed":
                    return MigrationState.Failed;
                case "Warning":
                    return MigrationState.Warning;
                case "Completed":
                    return MigrationState.Completed;
                case "Skipped":
                    return MigrationState.Skipped;
            }
            return null;
        }
    }
}
