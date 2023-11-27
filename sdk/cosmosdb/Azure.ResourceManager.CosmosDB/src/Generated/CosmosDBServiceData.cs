// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.CosmosDB.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary>
    /// A class representing the CosmosDBService data model.
    /// Properties for the database account.
    /// </summary>
    public partial class CosmosDBServiceData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="CosmosDBServiceData"/>. </summary>
        public CosmosDBServiceData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDBServiceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties">
        /// Services response resource.
        /// Please note <see cref="CosmosDBServiceProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DataTransferServiceProperties"/>, <see cref="GraphApiComputeServiceProperties"/>, <see cref="MaterializedViewsBuilderServiceProperties"/> and <see cref="SqlDedicatedGatewayServiceProperties"/>.
        /// </param>
        internal CosmosDBServiceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, CosmosDBServiceProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary>
        /// Services response resource.
        /// Please note <see cref="CosmosDBServiceProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DataTransferServiceProperties"/>, <see cref="GraphApiComputeServiceProperties"/>, <see cref="MaterializedViewsBuilderServiceProperties"/> and <see cref="SqlDedicatedGatewayServiceProperties"/>.
        /// </summary>
        public CosmosDBServiceProperties Properties { get; set; }
    }
}
