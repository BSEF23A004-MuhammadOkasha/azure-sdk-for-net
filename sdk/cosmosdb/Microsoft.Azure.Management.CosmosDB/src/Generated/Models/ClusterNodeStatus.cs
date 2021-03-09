// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The status of all nodes in the cluster (as returned by 'nodetool
    /// status').
    /// </summary>
    public partial class ClusterNodeStatus
    {
        /// <summary>
        /// Initializes a new instance of the ClusterNodeStatus class.
        /// </summary>
        public ClusterNodeStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ClusterNodeStatus class.
        /// </summary>
        /// <param name="nodes">Information about nodes in the cluster
        /// (corresponds to what is returned from nodetool info).</param>
        public ClusterNodeStatus(IList<ClusterNodeStatusNodesItem> nodes = default(IList<ClusterNodeStatusNodesItem>))
        {
            Nodes = nodes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets information about nodes in the cluster (corresponds to
        /// what is returned from nodetool info).
        /// </summary>
        [JsonProperty(PropertyName = "nodes")]
        public IList<ClusterNodeStatusNodesItem> Nodes { get; set; }

    }
}
