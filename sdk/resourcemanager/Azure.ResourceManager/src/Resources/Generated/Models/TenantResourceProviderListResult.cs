// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> List of resource providers. </summary>
    internal partial class TenantResourceProviderListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="TenantResourceProviderListResult"/>. </summary>
        internal TenantResourceProviderListResult()
        {
            Value = new ChangeTrackingList<TenantResourceProvider>();
        }

        /// <summary> Initializes a new instance of <see cref="TenantResourceProviderListResult"/>. </summary>
        /// <param name="value"> An array of resource providers. </param>
        /// <param name="nextLink"> The URL to use for getting the next set of results. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TenantResourceProviderListResult(IReadOnlyList<TenantResourceProvider> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> An array of resource providers. </summary>
        public IReadOnlyList<TenantResourceProvider> Value { get; }
        /// <summary> The URL to use for getting the next set of results. </summary>
        public string NextLink { get; }
    }
}
