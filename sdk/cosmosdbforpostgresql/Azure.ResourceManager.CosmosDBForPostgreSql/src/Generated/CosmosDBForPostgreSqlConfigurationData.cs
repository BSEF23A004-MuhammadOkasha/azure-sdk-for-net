// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CosmosDBForPostgreSql.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CosmosDBForPostgreSql
{
    /// <summary>
    /// A class representing the CosmosDBForPostgreSqlConfiguration data model.
    /// Represents configuration details for coordinator and node.
    /// </summary>
    public partial class CosmosDBForPostgreSqlConfigurationData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CosmosDBForPostgreSqlConfigurationData"/>. </summary>
        public CosmosDBForPostgreSqlConfigurationData()
        {
            ServerRoleGroupConfigurations = new ChangeTrackingList<CosmosDBForPostgreSqlServerRoleGroupConfiguration>();
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDBForPostgreSqlConfigurationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="description"> Description of the configuration. </param>
        /// <param name="dataType"> Data type of the configuration. </param>
        /// <param name="allowedValues"> Allowed values of the configuration. </param>
        /// <param name="isRestartRequired"> If configuration change requires restart. </param>
        /// <param name="serverRoleGroupConfigurations"> The list of server role group configuration values. </param>
        /// <param name="provisioningState"> Provisioning state of the configuration. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CosmosDBForPostgreSqlConfigurationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string description, CosmosDBForPostgreSqlConfigurationDataType? dataType, string allowedValues, bool? isRestartRequired, IList<CosmosDBForPostgreSqlServerRoleGroupConfiguration> serverRoleGroupConfigurations, ProvisioningState? provisioningState, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Description = description;
            DataType = dataType;
            AllowedValues = allowedValues;
            IsRestartRequired = isRestartRequired;
            ServerRoleGroupConfigurations = serverRoleGroupConfigurations;
            ProvisioningState = provisioningState;
            _rawData = rawData;
        }

        /// <summary> Description of the configuration. </summary>
        public string Description { get; }
        /// <summary> Data type of the configuration. </summary>
        public CosmosDBForPostgreSqlConfigurationDataType? DataType { get; }
        /// <summary> Allowed values of the configuration. </summary>
        public string AllowedValues { get; }
        /// <summary> If configuration change requires restart. </summary>
        public bool? IsRestartRequired { get; set; }
        /// <summary> The list of server role group configuration values. </summary>
        public IList<CosmosDBForPostgreSqlServerRoleGroupConfiguration> ServerRoleGroupConfigurations { get; }
        /// <summary> Provisioning state of the configuration. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
