// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary>
    /// The details about the localizable name of a type of usage.
    /// Serialized Name: LocalizedName
    /// </summary>
    public partial class LocalizedName
    {
        /// <summary> Initializes a new instance of LocalizedName. </summary>
        internal LocalizedName()
        {
        }

        /// <summary> Initializes a new instance of LocalizedName. </summary>
        /// <param name="value">
        /// The name of the used resource.
        /// Serialized Name: LocalizedName.value
        /// </param>
        /// <param name="localizedValue">
        /// The localized name of the used resource.
        /// Serialized Name: LocalizedName.localizedValue
        /// </param>
        internal LocalizedName(string value, string localizedValue)
        {
            Value = value;
            LocalizedValue = localizedValue;
        }

        /// <summary>
        /// The name of the used resource.
        /// Serialized Name: LocalizedName.value
        /// </summary>
        public string Value { get; }
        /// <summary>
        /// The localized name of the used resource.
        /// Serialized Name: LocalizedName.localizedValue
        /// </summary>
        public string LocalizedValue { get; }
    }
}
