// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Information protection policies response. </summary>
    internal partial class InformationProtectionPolicyList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="InformationProtectionPolicyList"/>. </summary>
        internal InformationProtectionPolicyList()
        {
            Value = new ChangeTrackingList<InformationProtectionPolicy>();
        }

        /// <summary> Initializes a new instance of <see cref="InformationProtectionPolicyList"/>. </summary>
        /// <param name="value"> List of information protection policies. </param>
        /// <param name="nextLink"> The URI to fetch the next page. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InformationProtectionPolicyList(IReadOnlyList<InformationProtectionPolicy> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of information protection policies. </summary>
        public IReadOnlyList<InformationProtectionPolicy> Value { get; }
        /// <summary> The URI to fetch the next page. </summary>
        public string NextLink { get; }
    }
}
