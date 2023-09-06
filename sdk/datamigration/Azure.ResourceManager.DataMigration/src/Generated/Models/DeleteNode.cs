// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Details of node to be deleted. </summary>
    public partial class DeleteNode
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DeleteNode"/>. </summary>
        public DeleteNode()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DeleteNode"/>. </summary>
        /// <param name="nodeName"> The name of node to delete. </param>
        /// <param name="integrationRuntimeName"> The name of integration runtime. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DeleteNode(string nodeName, string integrationRuntimeName, Dictionary<string, BinaryData> rawData)
        {
            NodeName = nodeName;
            IntegrationRuntimeName = integrationRuntimeName;
            _rawData = rawData;
        }

        /// <summary> The name of node to delete. </summary>
        public string NodeName { get; set; }
        /// <summary> The name of integration runtime. </summary>
        public string IntegrationRuntimeName { get; set; }
    }
}
