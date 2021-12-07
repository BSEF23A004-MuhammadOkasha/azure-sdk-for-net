// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Core.TestFramework.Models
{
    /// <summary> Sanitizer for a request header. </summary>
    public partial class HeaderRegexSanitizer
    {
        /// <summary> Initializes a new instance of HeaderRegexSanitizer. </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public HeaderRegexSanitizer(string key, string value)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Key = key;
            Value = value;
        }

        /// <summary> Gets the key. </summary>
        public string Key { get; }
        /// <summary> Gets the value. </summary>
        public string Value { get; }
        /// <summary> Gets or sets the regex. </summary>
        public string Regex { get; set; }
        /// <summary> Gets or sets the group for replace. </summary>
        public string GroupForReplace { get; set; }
    }
}
