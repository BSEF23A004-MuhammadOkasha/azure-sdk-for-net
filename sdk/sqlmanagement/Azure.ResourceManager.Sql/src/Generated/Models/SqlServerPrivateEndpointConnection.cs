// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A private endpoint connection under a server. </summary>
    public partial class SqlServerPrivateEndpointConnection
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SqlServerPrivateEndpointConnection"/>. </summary>
        internal SqlServerPrivateEndpointConnection()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SqlServerPrivateEndpointConnection"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="properties"> Private endpoint connection properties. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SqlServerPrivateEndpointConnection(ResourceIdentifier id, ServerPrivateEndpointConnectionProperties properties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Resource ID. </summary>
        public ResourceIdentifier Id { get; }
        /// <summary> Private endpoint connection properties. </summary>
        public ServerPrivateEndpointConnectionProperties Properties { get; }
    }
}
