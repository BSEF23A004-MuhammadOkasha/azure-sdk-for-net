// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> The HTTP header. </summary>
    public partial class ContainerHttpHeader
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ContainerHttpHeader"/>. </summary>
        public ContainerHttpHeader()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerHttpHeader"/>. </summary>
        /// <param name="name"> The header name. </param>
        /// <param name="value"> The header value. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerHttpHeader(string name, string value, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            Value = value;
            _rawData = rawData;
        }

        /// <summary> The header name. </summary>
        public string Name { get; set; }
        /// <summary> The header value. </summary>
        public string Value { get; set; }
    }
}
