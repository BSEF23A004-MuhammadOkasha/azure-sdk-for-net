// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Datadog.Models
{
    /// <summary> The DatadogApiKey. </summary>
    public partial class DatadogApiKey
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DatadogApiKey"/>. </summary>
        /// <param name="key"> The value of the API key. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public DatadogApiKey(string key)
        {
            Argument.AssertNotNull(key, nameof(key));

            Key = key;
        }

        /// <summary> Initializes a new instance of <see cref="DatadogApiKey"/>. </summary>
        /// <param name="createdBy"> The user that created the API key. </param>
        /// <param name="name"> The name of the API key. </param>
        /// <param name="key"> The value of the API key. </param>
        /// <param name="created"> The time of creation of the API key. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DatadogApiKey(string createdBy, string name, string key, string created, Dictionary<string, BinaryData> rawData)
        {
            CreatedBy = createdBy;
            Name = name;
            Key = key;
            Created = created;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="DatadogApiKey"/> for deserialization. </summary>
        internal DatadogApiKey()
        {
        }

        /// <summary> The user that created the API key. </summary>
        public string CreatedBy { get; set; }
        /// <summary> The name of the API key. </summary>
        public string Name { get; set; }
        /// <summary> The value of the API key. </summary>
        public string Key { get; set; }
        /// <summary> The time of creation of the API key. </summary>
        public string Created { get; set; }
    }
}
