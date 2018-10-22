// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ContentKeyPolicyPlayReadyUnknownOutputPassingOption.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ContentKeyPolicyPlayReadyUnknownOutputPassingOption
    {
        /// <summary>
        /// Represents a ContentKeyPolicyPlayReadyUnknownOutputPassingOption
        /// that is unavailable in current API version.
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown,
        /// <summary>
        /// Passing the video portion of protected content to an Unknown Output
        /// is not allowed.
        /// </summary>
        [EnumMember(Value = "NotAllowed")]
        NotAllowed,
        /// <summary>
        /// Passing the video portion of protected content to an Unknown Output
        /// is allowed.
        /// </summary>
        [EnumMember(Value = "Allowed")]
        Allowed,
        /// <summary>
        /// Passing the video portion of protected content to an Unknown Output
        /// is allowed but with constrained resolution.
        /// </summary>
        [EnumMember(Value = "AllowedWithVideoConstriction")]
        AllowedWithVideoConstriction
    }
    internal static class ContentKeyPolicyPlayReadyUnknownOutputPassingOptionEnumExtension
    {
        internal static string ToSerializedValue(this ContentKeyPolicyPlayReadyUnknownOutputPassingOption? value)
        {
            return value == null ? null : ((ContentKeyPolicyPlayReadyUnknownOutputPassingOption)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ContentKeyPolicyPlayReadyUnknownOutputPassingOption value)
        {
            switch( value )
            {
                case ContentKeyPolicyPlayReadyUnknownOutputPassingOption.Unknown:
                    return "Unknown";
                case ContentKeyPolicyPlayReadyUnknownOutputPassingOption.NotAllowed:
                    return "NotAllowed";
                case ContentKeyPolicyPlayReadyUnknownOutputPassingOption.Allowed:
                    return "Allowed";
                case ContentKeyPolicyPlayReadyUnknownOutputPassingOption.AllowedWithVideoConstriction:
                    return "AllowedWithVideoConstriction";
            }
            return null;
        }

        internal static ContentKeyPolicyPlayReadyUnknownOutputPassingOption? ParseContentKeyPolicyPlayReadyUnknownOutputPassingOption(this string value)
        {
            switch( value )
            {
                case "Unknown":
                    return ContentKeyPolicyPlayReadyUnknownOutputPassingOption.Unknown;
                case "NotAllowed":
                    return ContentKeyPolicyPlayReadyUnknownOutputPassingOption.NotAllowed;
                case "Allowed":
                    return ContentKeyPolicyPlayReadyUnknownOutputPassingOption.Allowed;
                case "AllowedWithVideoConstriction":
                    return ContentKeyPolicyPlayReadyUnknownOutputPassingOption.AllowedWithVideoConstriction;
            }
            return null;
        }
    }
}
