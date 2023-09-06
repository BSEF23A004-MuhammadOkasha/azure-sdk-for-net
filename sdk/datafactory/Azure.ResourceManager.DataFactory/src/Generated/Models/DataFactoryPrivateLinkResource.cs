// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> A private link resource. </summary>
    public partial class DataFactoryPrivateLinkResource : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DataFactoryPrivateLinkResource"/>. </summary>
        public DataFactoryPrivateLinkResource()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataFactoryPrivateLinkResource"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Core resource properties. </param>
        /// <param name="eTag"> Etag identifies change in the resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DataFactoryPrivateLinkResource(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DataFactoryPrivateLinkResourceProperties properties, ETag? eTag, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            ETag = eTag;
            _rawData = rawData;
        }

        /// <summary> Core resource properties. </summary>
        public DataFactoryPrivateLinkResourceProperties Properties { get; set; }
        /// <summary> Etag identifies change in the resource. </summary>
        public ETag? ETag { get; }
    }
}
