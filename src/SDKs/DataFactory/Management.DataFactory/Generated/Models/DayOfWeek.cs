// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 2.4.36.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for DayOfWeek.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DayOfWeek
    {
        [EnumMember(Value = "Sunday")]
        Sunday,
        [EnumMember(Value = "Monday")]
        Monday,
        [EnumMember(Value = "Tuesday")]
        Tuesday,
        [EnumMember(Value = "Wednesday")]
        Wednesday,
        [EnumMember(Value = "Thursday")]
        Thursday,
        [EnumMember(Value = "Friday")]
        Friday,
        [EnumMember(Value = "Saturday")]
        Saturday
    }
    internal static class DayOfWeekEnumExtension
    {
        internal static string ToSerializedValue(this DayOfWeek? value)
        {
            return value == null ? null : ((DayOfWeek)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this DayOfWeek value)
        {
            switch( value )
            {
                case DayOfWeek.Sunday:
                    return "Sunday";
                case DayOfWeek.Monday:
                    return "Monday";
                case DayOfWeek.Tuesday:
                    return "Tuesday";
                case DayOfWeek.Wednesday:
                    return "Wednesday";
                case DayOfWeek.Thursday:
                    return "Thursday";
                case DayOfWeek.Friday:
                    return "Friday";
                case DayOfWeek.Saturday:
                    return "Saturday";
            }
            return null;
        }

        internal static DayOfWeek? ParseDayOfWeek(this string value)
        {
            switch( value )
            {
                case "Sunday":
                    return DayOfWeek.Sunday;
                case "Monday":
                    return DayOfWeek.Monday;
                case "Tuesday":
                    return DayOfWeek.Tuesday;
                case "Wednesday":
                    return DayOfWeek.Wednesday;
                case "Thursday":
                    return DayOfWeek.Thursday;
                case "Friday":
                    return DayOfWeek.Friday;
                case "Saturday":
                    return DayOfWeek.Saturday;
            }
            return null;
        }
    }
}
