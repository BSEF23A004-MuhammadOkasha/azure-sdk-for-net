// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Redis;

namespace Azure.ResourceManager.Redis.Models
{
    /// <summary> The response of list Redis operation. </summary>
    internal partial class RedisListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RedisListResult"/>. </summary>
        internal RedisListResult()
        {
            Value = new ChangeTrackingList<RedisData>();
        }

        /// <summary> Initializes a new instance of <see cref="RedisListResult"/>. </summary>
        /// <param name="value"> List of Redis cache instances. </param>
        /// <param name="nextLink"> Link for next page of results. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RedisListResult(IReadOnlyList<RedisData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of Redis cache instances. </summary>
        public IReadOnlyList<RedisData> Value { get; }
        /// <summary> Link for next page of results. </summary>
        public string NextLink { get; }
    }
}
