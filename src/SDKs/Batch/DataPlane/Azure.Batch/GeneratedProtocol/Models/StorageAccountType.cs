// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for StorageAccountType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StorageAccountType
    {
        /// <summary>
        /// The data disk should use standard locally redundant storage.
        /// </summary>
        [EnumMember(Value = "standard_lrs")]
        StandardLRS,
        /// <summary>
        /// The data disk should use premium locally redundant storage.
        /// </summary>
        [EnumMember(Value = "premium_lrs")]
        PremiumLRS
    }
    internal static class StorageAccountTypeEnumExtension
    {
        internal static string ToSerializedValue(this StorageAccountType? value)
        {
            return value == null ? null : ((StorageAccountType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this StorageAccountType value)
        {
            switch( value )
            {
                case StorageAccountType.StandardLRS:
                    return "standard_lrs";
                case StorageAccountType.PremiumLRS:
                    return "premium_lrs";
            }
            return null;
        }

        internal static StorageAccountType? ParseStorageAccountType(this string value)
        {
            switch( value )
            {
                case "standard_lrs":
                    return StorageAccountType.StandardLRS;
                case "premium_lrs":
                    return StorageAccountType.PremiumLRS;
            }
            return null;
        }
    }
}
