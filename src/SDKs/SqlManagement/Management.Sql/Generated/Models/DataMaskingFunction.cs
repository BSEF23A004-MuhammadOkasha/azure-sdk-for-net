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
    /// Defines values for DataMaskingFunction.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DataMaskingFunction
    {
        [EnumMember(Value = "CCN")]
        CCN,
        [EnumMember(Value = "Default")]
        Default,
        [EnumMember(Value = "Email")]
        Email,
        [EnumMember(Value = "Number")]
        Number,
        [EnumMember(Value = "SSN")]
        SSN,
        [EnumMember(Value = "Text")]
        Text
    }
    internal static class DataMaskingFunctionEnumExtension
    {
        internal static string ToSerializedValue(this DataMaskingFunction? value)  =>
            value == null ? null : ((DataMaskingFunction)value).ToSerializedValue();

        internal static string ToSerializedValue(this DataMaskingFunction value)
        {
            switch( value )
            {
                case DataMaskingFunction.CCN:
                    return "CCN";
                case DataMaskingFunction.Default:
                    return "Default";
                case DataMaskingFunction.Email:
                    return "Email";
                case DataMaskingFunction.Number:
                    return "Number";
                case DataMaskingFunction.SSN:
                    return "SSN";
                case DataMaskingFunction.Text:
                    return "Text";
            }
            return null;
        }

        internal static DataMaskingFunction? ParseDataMaskingFunction(this string value)
        {
            switch( value )
            {
                case "CCN":
                    return DataMaskingFunction.CCN;
                case "Default":
                    return DataMaskingFunction.Default;
                case "Email":
                    return DataMaskingFunction.Email;
                case "Number":
                    return DataMaskingFunction.Number;
                case "SSN":
                    return DataMaskingFunction.SSN;
                case "Text":
                    return DataMaskingFunction.Text;
            }
            return null;
        }
    }
}
