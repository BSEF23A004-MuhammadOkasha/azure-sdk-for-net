// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Parameters to create Data Transfer Job. </summary>
    public partial class DataTransferJobGetResultCreateOrUpdateContent : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="DataTransferJobGetResultCreateOrUpdateContent"/>. </summary>
        /// <param name="properties"> Data Transfer Create Job Properties. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public DataTransferJobGetResultCreateOrUpdateContent(DataTransferJobProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> Initializes a new instance of <see cref="DataTransferJobGetResultCreateOrUpdateContent"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Data Transfer Create Job Properties. </param>
        internal DataTransferJobGetResultCreateOrUpdateContent(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DataTransferJobProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary> Data Transfer Create Job Properties. </summary>
        public DataTransferJobProperties Properties { get; set; }
    }
}
