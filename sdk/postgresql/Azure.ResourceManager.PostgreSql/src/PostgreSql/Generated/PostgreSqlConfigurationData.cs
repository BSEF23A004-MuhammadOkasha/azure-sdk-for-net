// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.PostgreSql
{
    /// <summary> A class representing the PostgreSqlConfiguration data model. </summary>
    public partial class PostgreSqlConfigurationData : ResourceData
    {
        /// <summary> Initializes a new instance of PostgreSqlConfigurationData. </summary>
        public PostgreSqlConfigurationData()
        {
        }

        /// <summary> Initializes a new instance of PostgreSqlConfigurationData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="value"> Value of the configuration. </param>
        /// <param name="description"> Description of the configuration. </param>
        /// <param name="defaultValue"> Default value of the configuration. </param>
        /// <param name="dataType"> Data type of the configuration. </param>
        /// <param name="allowedValues"> Allowed values of the configuration. </param>
        /// <param name="source"> Source of the configuration. </param>
        internal PostgreSqlConfigurationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string value, string description, string defaultValue, string dataType, string allowedValues, string source) : base(id, name, resourceType, systemData)
        {
            Value = value;
            Description = description;
            DefaultValue = defaultValue;
            DataType = dataType;
            AllowedValues = allowedValues;
            Source = source;
        }

        /// <summary> Value of the configuration. </summary>
        public string Value { get; set; }
        /// <summary> Description of the configuration. </summary>
        public string Description { get; }
        /// <summary> Default value of the configuration. </summary>
        public string DefaultValue { get; }
        /// <summary> Data type of the configuration. </summary>
        public string DataType { get; }
        /// <summary> Allowed values of the configuration. </summary>
        public string AllowedValues { get; }
        /// <summary> Source of the configuration. </summary>
        public string Source { get; set; }
    }
}
