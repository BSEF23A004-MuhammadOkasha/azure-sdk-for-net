// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CustomerInsights.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CustomerInsights
{
    /// <summary>
    /// A class representing the ConnectorResourceFormat data model.
    /// The connector resource format.
    /// </summary>
    public partial class ConnectorResourceFormatData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ConnectorResourceFormatData"/>. </summary>
        public ConnectorResourceFormatData()
        {
            ConnectorProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="ConnectorResourceFormatData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="connectorId"> ID of the connector. </param>
        /// <param name="connectorName"> Name of the connector. </param>
        /// <param name="connectorType"> Type of connector. </param>
        /// <param name="displayName"> Display name of the connector. </param>
        /// <param name="description"> Description of the connector. </param>
        /// <param name="connectorProperties"> The connector properties. </param>
        /// <param name="created"> The created time. </param>
        /// <param name="lastModified"> The last modified time. </param>
        /// <param name="state"> State of connector. </param>
        /// <param name="tenantId"> The hub name. </param>
        /// <param name="isInternal"> If this is an internal connector. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ConnectorResourceFormatData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, int? connectorId, string connectorName, ConnectorType? connectorType, string displayName, string description, IDictionary<string, BinaryData> connectorProperties, DateTimeOffset? created, DateTimeOffset? lastModified, ConnectorState? state, Guid? tenantId, bool? isInternal, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            ConnectorId = connectorId;
            ConnectorName = connectorName;
            ConnectorType = connectorType;
            DisplayName = displayName;
            Description = description;
            ConnectorProperties = connectorProperties;
            Created = created;
            LastModified = lastModified;
            State = state;
            TenantId = tenantId;
            IsInternal = isInternal;
            _rawData = rawData;
        }

        /// <summary> ID of the connector. </summary>
        public int? ConnectorId { get; }
        /// <summary> Name of the connector. </summary>
        public string ConnectorName { get; set; }
        /// <summary> Type of connector. </summary>
        public ConnectorType? ConnectorType { get; set; }
        /// <summary> Display name of the connector. </summary>
        public string DisplayName { get; set; }
        /// <summary> Description of the connector. </summary>
        public string Description { get; set; }
        /// <summary>
        /// The connector properties.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public IDictionary<string, BinaryData> ConnectorProperties { get; }
        /// <summary> The created time. </summary>
        public DateTimeOffset? Created { get; }
        /// <summary> The last modified time. </summary>
        public DateTimeOffset? LastModified { get; }
        /// <summary> State of connector. </summary>
        public ConnectorState? State { get; }
        /// <summary> The hub name. </summary>
        public Guid? TenantId { get; }
        /// <summary> If this is an internal connector. </summary>
        public bool? IsInternal { get; set; }
    }
}
