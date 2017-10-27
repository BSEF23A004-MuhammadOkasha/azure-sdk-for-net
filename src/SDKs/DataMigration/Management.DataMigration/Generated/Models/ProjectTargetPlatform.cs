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
    /// Defines values for ProjectTargetPlatform.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProjectTargetPlatform
    {
        [EnumMember(Value = "SQLDB")]
        SQLDB
    }
    internal static class ProjectTargetPlatformEnumExtension
    {
        internal static string ToSerializedValue(this ProjectTargetPlatform? value)
        {
            return value == null ? null : ((ProjectTargetPlatform)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ProjectTargetPlatform value)
        {
            switch( value )
            {
                case ProjectTargetPlatform.SQLDB:
                    return "SQLDB";
            }
            return null;
        }

        internal static ProjectTargetPlatform? ParseProjectTargetPlatform(this string value)
        {
            switch( value )
            {
                case "SQLDB":
                    return ProjectTargetPlatform.SQLDB;
            }
            return null;
        }
    }
}
