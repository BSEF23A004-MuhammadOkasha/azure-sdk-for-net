// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Data flow debug resource. </summary>
    public partial class DataFlowDebugResource : SubResourceDebugResource
    {
        /// <summary> Initializes a new instance of <see cref="DataFlowDebugResource"/>. </summary>
        /// <param name="properties">
        /// Data flow properties.
        /// Please note <see cref="DataFlow"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="Flowlet"/> and <see cref="MappingDataFlow"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public DataFlowDebugResource(DataFlow properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> Initializes a new instance of <see cref="DataFlowDebugResource"/>. </summary>
        /// <param name="name"> The resource name. </param>
        /// <param name="properties">
        /// Data flow properties.
        /// Please note <see cref="DataFlow"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="Flowlet"/> and <see cref="MappingDataFlow"/>.
        /// </param>
        internal DataFlowDebugResource(string name, DataFlow properties) : base(name)
        {
            Properties = properties;
        }

        /// <summary>
        /// Data flow properties.
        /// Please note <see cref="DataFlow"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="Flowlet"/> and <see cref="MappingDataFlow"/>.
        /// </summary>
        public DataFlow Properties { get; set; }
    }
}
