// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Analytical storage specific properties. </summary>
    internal partial class AnalyticalStorageConfiguration
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AnalyticalStorageConfiguration"/>. </summary>
        public AnalyticalStorageConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AnalyticalStorageConfiguration"/>. </summary>
        /// <param name="schemaType"> Describes the types of schema for analytical storage. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AnalyticalStorageConfiguration(AnalyticalStorageSchemaType? schemaType, Dictionary<string, BinaryData> rawData)
        {
            SchemaType = schemaType;
            _rawData = rawData;
        }

        /// <summary> Describes the types of schema for analytical storage. </summary>
        public AnalyticalStorageSchemaType? SchemaType { get; set; }
    }
}
