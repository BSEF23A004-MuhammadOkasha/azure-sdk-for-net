// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ListSharesExpand.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ListSharesExpand
    {
        [EnumMember(Value = "deleted")]
        Deleted
    }
    internal static class ListSharesExpandEnumExtension
    {
        internal static string ToSerializedValue(this ListSharesExpand? value)
        {
            return value == null ? null : ((ListSharesExpand)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ListSharesExpand value)
        {
            switch( value )
            {
                case ListSharesExpand.Deleted:
                    return "deleted";
            }
            return null;
        }

        internal static ListSharesExpand? ParseListSharesExpand(this string value)
        {
            switch( value )
            {
                case "deleted":
                    return ListSharesExpand.Deleted;
            }
            return null;
        }
    }
}
