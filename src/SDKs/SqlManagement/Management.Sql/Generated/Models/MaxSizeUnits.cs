// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Sql;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for MaxSizeUnits.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MaxSizeUnits
    {
        [EnumMember(Value = "Megabytes")]
        Megabytes,
        [EnumMember(Value = "Gigabytes")]
        Gigabytes,
        [EnumMember(Value = "Terabytes")]
        Terabytes,
        [EnumMember(Value = "Petabytes")]
        Petabytes
    }
    internal static class MaxSizeUnitsEnumExtension
    {
        internal static string ToSerializedValue(this MaxSizeUnits? value)  =>
            value == null ? null : ((MaxSizeUnits)value).ToSerializedValue();

        internal static string ToSerializedValue(this MaxSizeUnits value)
        {
            switch( value )
            {
                case MaxSizeUnits.Megabytes:
                    return "Megabytes";
                case MaxSizeUnits.Gigabytes:
                    return "Gigabytes";
                case MaxSizeUnits.Terabytes:
                    return "Terabytes";
                case MaxSizeUnits.Petabytes:
                    return "Petabytes";
            }
            return null;
        }

        internal static MaxSizeUnits? ParseMaxSizeUnits(this string value)
        {
            switch( value )
            {
                case "Megabytes":
                    return MaxSizeUnits.Megabytes;
                case "Gigabytes":
                    return MaxSizeUnits.Gigabytes;
                case "Terabytes":
                    return MaxSizeUnits.Terabytes;
                case "Petabytes":
                    return MaxSizeUnits.Petabytes;
            }
            return null;
        }
    }
}
