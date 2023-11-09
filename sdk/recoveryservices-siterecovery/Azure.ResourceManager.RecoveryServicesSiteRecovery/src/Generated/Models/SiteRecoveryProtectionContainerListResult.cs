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
    /// <summary> Protection Container collection. </summary>
    internal partial class SiteRecoveryProtectionContainerListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryProtectionContainerListResult"/>. </summary>
        internal SiteRecoveryProtectionContainerListResult()
        {
            Value = new ChangeTrackingList<SiteRecoveryProtectionContainerData>();
        }

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryProtectionContainerListResult"/>. </summary>
        /// <param name="value"> The Protection Container details. </param>
        /// <param name="nextLink"> The value of next link. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SiteRecoveryProtectionContainerListResult(IReadOnlyList<SiteRecoveryProtectionContainerData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The Protection Container details. </summary>
        public IReadOnlyList<SiteRecoveryProtectionContainerData> Value { get; }
        /// <summary> The value of next link. </summary>
        public string NextLink { get; }
    }
}
