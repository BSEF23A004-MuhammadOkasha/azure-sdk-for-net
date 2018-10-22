// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorSimple1200Series.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for MetricAggregationType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MetricAggregationType
    {
        [EnumMember(Value = "Average")]
        Average,
        [EnumMember(Value = "Last")]
        Last,
        [EnumMember(Value = "Maximum")]
        Maximum,
        [EnumMember(Value = "Minimum")]
        Minimum,
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "Total")]
        Total
    }
    internal static class MetricAggregationTypeEnumExtension
    {
        internal static string ToSerializedValue(this MetricAggregationType? value)
        {
            return value == null ? null : ((MetricAggregationType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this MetricAggregationType value)
        {
            switch( value )
            {
                case MetricAggregationType.Average:
                    return "Average";
                case MetricAggregationType.Last:
                    return "Last";
                case MetricAggregationType.Maximum:
                    return "Maximum";
                case MetricAggregationType.Minimum:
                    return "Minimum";
                case MetricAggregationType.None:
                    return "None";
                case MetricAggregationType.Total:
                    return "Total";
            }
            return null;
        }

        internal static MetricAggregationType? ParseMetricAggregationType(this string value)
        {
            switch( value )
            {
                case "Average":
                    return MetricAggregationType.Average;
                case "Last":
                    return MetricAggregationType.Last;
                case "Maximum":
                    return MetricAggregationType.Maximum;
                case "Minimum":
                    return MetricAggregationType.Minimum;
                case "None":
                    return MetricAggregationType.None;
                case "Total":
                    return MetricAggregationType.Total;
            }
            return null;
        }
    }
}
