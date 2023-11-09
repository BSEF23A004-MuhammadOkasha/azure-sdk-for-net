// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A server dns alias acquisition request. </summary>
    public partial class ServerDnsAliasAcquisition
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ServerDnsAliasAcquisition"/>. </summary>
        /// <param name="oldServerDnsAliasId"> The id of the server alias that will be acquired to point to this server instead. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="oldServerDnsAliasId"/> is null. </exception>
        public ServerDnsAliasAcquisition(ResourceIdentifier oldServerDnsAliasId)
        {
            Argument.AssertNotNull(oldServerDnsAliasId, nameof(oldServerDnsAliasId));

            OldServerDnsAliasId = oldServerDnsAliasId;
        }

        /// <summary> Initializes a new instance of <see cref="ServerDnsAliasAcquisition"/>. </summary>
        /// <param name="oldServerDnsAliasId"> The id of the server alias that will be acquired to point to this server instead. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ServerDnsAliasAcquisition(ResourceIdentifier oldServerDnsAliasId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            OldServerDnsAliasId = oldServerDnsAliasId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ServerDnsAliasAcquisition"/> for deserialization. </summary>
        internal ServerDnsAliasAcquisition()
        {
        }

        /// <summary> The id of the server alias that will be acquired to point to this server instead. </summary>
        public ResourceIdentifier OldServerDnsAliasId { get; }
    }
}
