// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A list of the managed instance's Advanced Threat Protection settings. </summary>
    internal partial class ManagedInstanceAdvancedThreatProtectionListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ManagedInstanceAdvancedThreatProtectionListResult"/>. </summary>
        internal ManagedInstanceAdvancedThreatProtectionListResult()
        {
            Value = new ChangeTrackingList<ManagedInstanceAdvancedThreatProtectionData>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedInstanceAdvancedThreatProtectionListResult"/>. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedInstanceAdvancedThreatProtectionListResult(IReadOnlyList<ManagedInstanceAdvancedThreatProtectionData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<ManagedInstanceAdvancedThreatProtectionData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
