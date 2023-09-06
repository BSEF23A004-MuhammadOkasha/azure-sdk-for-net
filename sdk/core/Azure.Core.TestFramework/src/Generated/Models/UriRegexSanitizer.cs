// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Core.TestFramework.Models
{
    /// <summary> Sanitizer for a request URI. </summary>
    public partial class UriRegexSanitizer
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="UriRegexSanitizer"/>. </summary>
        /// <param name="regex"></param>
        /// <param name="value"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="regex"/> or <paramref name="value"/> is null. </exception>
        public UriRegexSanitizer(string regex, string value)
        {
            Argument.AssertNotNull(regex, nameof(regex));
            Argument.AssertNotNull(value, nameof(value));

            Regex = regex;
            Value = value;
        }

        /// <summary> Initializes a new instance of <see cref="UriRegexSanitizer"/>. </summary>
        /// <param name="regex"></param>
        /// <param name="value"></param>
        /// <param name="groupForReplace"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal UriRegexSanitizer(string regex, string value, string groupForReplace, Dictionary<string, BinaryData> rawData)
        {
            Regex = regex;
            Value = value;
            GroupForReplace = groupForReplace;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="UriRegexSanitizer"/> for deserialization. </summary>
        internal UriRegexSanitizer()
        {
        }

        /// <summary> Gets the regex. </summary>
        public string Regex { get; }
        /// <summary> Gets the value. </summary>
        public string Value { get; }
        /// <summary> Gets or sets the group for replace. </summary>
        public string GroupForReplace { get; set; }
    }
}
