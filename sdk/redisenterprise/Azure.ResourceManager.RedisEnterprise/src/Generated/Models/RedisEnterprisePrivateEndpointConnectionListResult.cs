// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.RedisEnterprise;

namespace Azure.ResourceManager.RedisEnterprise.Models
{
    /// <summary> List of private endpoint connection associated with the specified storage account. </summary>
    internal partial class RedisEnterprisePrivateEndpointConnectionListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RedisEnterprisePrivateEndpointConnectionListResult"/>. </summary>
        internal RedisEnterprisePrivateEndpointConnectionListResult()
        {
            Value = new ChangeTrackingList<RedisEnterprisePrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of <see cref="RedisEnterprisePrivateEndpointConnectionListResult"/>. </summary>
        /// <param name="value"> Array of private endpoint connections. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RedisEnterprisePrivateEndpointConnectionListResult(IReadOnlyList<RedisEnterprisePrivateEndpointConnectionData> value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Array of private endpoint connections. </summary>
        public IReadOnlyList<RedisEnterprisePrivateEndpointConnectionData> Value { get; }
    }
}
