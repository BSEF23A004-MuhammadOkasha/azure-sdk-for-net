// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A managed server dns alias creation request. </summary>
    public partial class ManagedServerDnsAliasCreateOrUpdateContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ManagedServerDnsAliasCreateOrUpdateContent"/>. </summary>
        public ManagedServerDnsAliasCreateOrUpdateContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ManagedServerDnsAliasCreateOrUpdateContent"/>. </summary>
        /// <param name="createDnsRecord"> Whether or not DNS record should be created for this alias. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedServerDnsAliasCreateOrUpdateContent(bool? createDnsRecord, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CreateDnsRecord = createDnsRecord;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Whether or not DNS record should be created for this alias. </summary>
        public bool? CreateDnsRecord { get; set; }
    }
}
