// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.PrivateDns.Models;

namespace Azure.ResourceManager.PrivateDns
{
    /// <summary>
    /// A class representing the PrivateDnsZone data model.
    /// Describes a Private DNS zone.
    /// </summary>
    public partial class PrivateDnsZoneData : TrackedResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PrivateDnsZoneData"/>. </summary>
        /// <param name="location"> The location. </param>
        public PrivateDnsZoneData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="PrivateDnsZoneData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="etag"> The ETag of the zone. </param>
        /// <param name="maxNumberOfRecords"> The maximum number of record sets that can be created in this Private DNS zone. This is a read-only property and any attempt to set this value will be ignored. </param>
        /// <param name="numberOfRecords"> The current number of record sets in this Private DNS zone. This is a read-only property and any attempt to set this value will be ignored. </param>
        /// <param name="maxNumberOfVirtualNetworkLinks"> The maximum number of virtual networks that can be linked to this Private DNS zone. This is a read-only property and any attempt to set this value will be ignored. </param>
        /// <param name="numberOfVirtualNetworkLinks"> The current number of virtual networks that are linked to this Private DNS zone. This is a read-only property and any attempt to set this value will be ignored. </param>
        /// <param name="maxNumberOfVirtualNetworkLinksWithRegistration"> The maximum number of virtual networks that can be linked to this Private DNS zone with registration enabled. This is a read-only property and any attempt to set this value will be ignored. </param>
        /// <param name="numberOfVirtualNetworkLinksWithRegistration"> The current number of virtual networks that are linked to this Private DNS zone with registration enabled. This is a read-only property and any attempt to set this value will be ignored. </param>
        /// <param name="privateDnsProvisioningState"> The provisioning state of the resource. This is a read-only property and any attempt to set this value will be ignored. </param>
        /// <param name="internalId"> Private zone internal Id. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PrivateDnsZoneData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ETag? etag, long? maxNumberOfRecords, long? numberOfRecords, long? maxNumberOfVirtualNetworkLinks, long? numberOfVirtualNetworkLinks, long? maxNumberOfVirtualNetworkLinksWithRegistration, long? numberOfVirtualNetworkLinksWithRegistration, PrivateDnsProvisioningState? privateDnsProvisioningState, string internalId, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            ETag = etag;
            MaxNumberOfRecords = maxNumberOfRecords;
            NumberOfRecords = numberOfRecords;
            MaxNumberOfVirtualNetworkLinks = maxNumberOfVirtualNetworkLinks;
            NumberOfVirtualNetworkLinks = numberOfVirtualNetworkLinks;
            MaxNumberOfVirtualNetworkLinksWithRegistration = maxNumberOfVirtualNetworkLinksWithRegistration;
            NumberOfVirtualNetworkLinksWithRegistration = numberOfVirtualNetworkLinksWithRegistration;
            PrivateDnsProvisioningState = privateDnsProvisioningState;
            InternalId = internalId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="PrivateDnsZoneData"/> for deserialization. </summary>
        internal PrivateDnsZoneData()
        {
        }

        /// <summary> The ETag of the zone. </summary>
        public ETag? ETag { get; set; }
        /// <summary> The maximum number of record sets that can be created in this Private DNS zone. This is a read-only property and any attempt to set this value will be ignored. </summary>
        public long? MaxNumberOfRecords { get; }
        /// <summary> The current number of record sets in this Private DNS zone. This is a read-only property and any attempt to set this value will be ignored. </summary>
        public long? NumberOfRecords { get; }
        /// <summary> The maximum number of virtual networks that can be linked to this Private DNS zone. This is a read-only property and any attempt to set this value will be ignored. </summary>
        public long? MaxNumberOfVirtualNetworkLinks { get; }
        /// <summary> The current number of virtual networks that are linked to this Private DNS zone. This is a read-only property and any attempt to set this value will be ignored. </summary>
        public long? NumberOfVirtualNetworkLinks { get; }
        /// <summary> The maximum number of virtual networks that can be linked to this Private DNS zone with registration enabled. This is a read-only property and any attempt to set this value will be ignored. </summary>
        public long? MaxNumberOfVirtualNetworkLinksWithRegistration { get; }
        /// <summary> The current number of virtual networks that are linked to this Private DNS zone with registration enabled. This is a read-only property and any attempt to set this value will be ignored. </summary>
        public long? NumberOfVirtualNetworkLinksWithRegistration { get; }
        /// <summary> The provisioning state of the resource. This is a read-only property and any attempt to set this value will be ignored. </summary>
        public PrivateDnsProvisioningState? PrivateDnsProvisioningState { get; }
        /// <summary> Private zone internal Id. </summary>
        public string InternalId { get; }
    }
}
