// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing the DeletedServer data model.
    /// A deleted server.
    /// </summary>
    public partial class DeletedServerData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DeletedServerData"/>. </summary>
        public DeletedServerData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DeletedServerData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="version"> The version of the deleted server. </param>
        /// <param name="deletedOn"> The deletion time of the deleted server. </param>
        /// <param name="originalId"> The original ID of the server before deletion. </param>
        /// <param name="fullyQualifiedDomainName"> The fully qualified domain name of the server. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DeletedServerData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string version, DateTimeOffset? deletedOn, ResourceIdentifier originalId, string fullyQualifiedDomainName, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Version = version;
            DeletedOn = deletedOn;
            OriginalId = originalId;
            FullyQualifiedDomainName = fullyQualifiedDomainName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The version of the deleted server. </summary>
        public string Version { get; }
        /// <summary> The deletion time of the deleted server. </summary>
        public DateTimeOffset? DeletedOn { get; }
        /// <summary> The original ID of the server before deletion. </summary>
        public ResourceIdentifier OriginalId { get; }
        /// <summary> The fully qualified domain name of the server. </summary>
        public string FullyQualifiedDomainName { get; }
    }
}
