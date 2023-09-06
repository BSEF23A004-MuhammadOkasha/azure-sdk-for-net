// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Attribute reference details for the referred column. </summary>
    public partial class MapperAttributeReference
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MapperAttributeReference"/>. </summary>
        public MapperAttributeReference()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MapperAttributeReference"/>. </summary>
        /// <param name="name"> Name of the column. </param>
        /// <param name="entity"> Name of the table. </param>
        /// <param name="entityConnectionReference"> The connection reference for the connection. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MapperAttributeReference(string name, string entity, MapperConnectionReference entityConnectionReference, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            Entity = entity;
            EntityConnectionReference = entityConnectionReference;
            _rawData = rawData;
        }

        /// <summary> Name of the column. </summary>
        public string Name { get; set; }
        /// <summary> Name of the table. </summary>
        public string Entity { get; set; }
        /// <summary> The connection reference for the connection. </summary>
        public MapperConnectionReference EntityConnectionReference { get; set; }
    }
}
