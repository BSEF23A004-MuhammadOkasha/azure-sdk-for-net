// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> CDC table details. </summary>
    public partial class MapperTable
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MapperTable"/>. </summary>
        public MapperTable()
        {
            Schema = new ChangeTrackingList<MapperTableSchema>();
            DslConnectorProperties = new ChangeTrackingList<MapperDslConnectorProperties>();
        }

        /// <summary> Initializes a new instance of <see cref="MapperTable"/>. </summary>
        /// <param name="name"> Name of the table. </param>
        /// <param name="schema"> List of columns for the source table. </param>
        /// <param name="dslConnectorProperties"> List of name/value pairs for connection properties. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MapperTable(string name, IList<MapperTableSchema> schema, IList<MapperDslConnectorProperties> dslConnectorProperties, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            Schema = schema;
            DslConnectorProperties = dslConnectorProperties;
            _rawData = rawData;
        }

        /// <summary> Name of the table. </summary>
        public string Name { get; set; }
        /// <summary> List of columns for the source table. </summary>
        public IList<MapperTableSchema> Schema { get; }
        /// <summary> List of name/value pairs for connection properties. </summary>
        public IList<MapperDslConnectorProperties> DslConnectorProperties { get; }
    }
}
