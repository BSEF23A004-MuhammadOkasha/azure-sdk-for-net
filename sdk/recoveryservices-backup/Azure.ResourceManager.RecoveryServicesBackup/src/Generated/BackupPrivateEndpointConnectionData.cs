// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.RecoveryServicesBackup.Models;

namespace Azure.ResourceManager.RecoveryServicesBackup
{
    /// <summary>
    /// A class representing the BackupPrivateEndpointConnection data model.
    /// Private Endpoint Connection Response Properties
    /// </summary>
    public partial class BackupPrivateEndpointConnectionData : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BackupPrivateEndpointConnectionData"/>. </summary>
        /// <param name="location"> The location. </param>
        public BackupPrivateEndpointConnectionData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="BackupPrivateEndpointConnectionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> PrivateEndpointConnectionResource properties. </param>
        /// <param name="eTag"> Optional ETag. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BackupPrivateEndpointConnectionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, BackupPrivateEndpointConnectionProperties properties, ETag? eTag, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Properties = properties;
            ETag = eTag;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BackupPrivateEndpointConnectionData"/> for deserialization. </summary>
        internal BackupPrivateEndpointConnectionData()
        {
        }

        /// <summary> PrivateEndpointConnectionResource properties. </summary>
        public BackupPrivateEndpointConnectionProperties Properties { get; set; }
        /// <summary> Optional ETag. </summary>
        public ETag? ETag { get; set; }
    }
}
