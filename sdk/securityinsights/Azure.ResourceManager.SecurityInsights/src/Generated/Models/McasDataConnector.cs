// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Represents MCAS (Microsoft Cloud App Security) data connector. </summary>
    public partial class McasDataConnector : SecurityInsightsDataConnectorData
    {
        /// <summary> Initializes a new instance of <see cref="McasDataConnector"/>. </summary>
        public McasDataConnector()
        {
            Kind = DataConnectorKind.MicrosoftCloudAppSecurity;
        }

        /// <summary> Initializes a new instance of <see cref="McasDataConnector"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> The data connector kind. </param>
        /// <param name="etag"> Etag of the azure resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="tenantId"> The tenant id to connect to, and get the data from. </param>
        /// <param name="dataTypes"> The available data types for the connector. </param>
        internal McasDataConnector(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DataConnectorKind kind, ETag? etag, IDictionary<string, BinaryData> serializedAdditionalRawData, Guid? tenantId, McasDataConnectorDataTypes dataTypes) : base(id, name, resourceType, systemData, kind, etag, serializedAdditionalRawData)
        {
            TenantId = tenantId;
            DataTypes = dataTypes;
            Kind = kind;
        }

        /// <summary> The tenant id to connect to, and get the data from. </summary>
        public Guid? TenantId { get; set; }
        /// <summary> The available data types for the connector. </summary>
        public McasDataConnectorDataTypes DataTypes { get; set; }
    }
}
