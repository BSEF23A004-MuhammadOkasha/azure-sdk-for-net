// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.RecoveryServicesSiteRecovery;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> List of network mappings. As with NetworkMapping, it should be possible to reuse a prev version of this class. It doesn't seem likely this class could be anything more than a slightly bespoke collection of NetworkMapping. Hence it makes sense to override Load with Base.NetworkMapping instead of existing CurrentVersion.NetworkMapping. </summary>
    internal partial class SiteRecoveryNetworkMappingListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryNetworkMappingListResult"/>. </summary>
        internal SiteRecoveryNetworkMappingListResult()
        {
            Value = new ChangeTrackingList<SiteRecoveryNetworkMappingData>();
        }

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryNetworkMappingListResult"/>. </summary>
        /// <param name="value"> The Network Mappings list. </param>
        /// <param name="nextLink"> The value of next link. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SiteRecoveryNetworkMappingListResult(IReadOnlyList<SiteRecoveryNetworkMappingData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The Network Mappings list. </summary>
        public IReadOnlyList<SiteRecoveryNetworkMappingData> Value { get; }
        /// <summary> The value of next link. </summary>
        public string NextLink { get; }
    }
}
