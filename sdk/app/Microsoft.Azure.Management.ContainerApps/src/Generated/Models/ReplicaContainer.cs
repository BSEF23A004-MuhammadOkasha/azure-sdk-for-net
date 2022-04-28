// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerApps.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Container object under Container App Revision Replica.
    /// </summary>
    public partial class ReplicaContainer
    {
        /// <summary>
        /// Initializes a new instance of the ReplicaContainer class.
        /// </summary>
        public ReplicaContainer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ReplicaContainer class.
        /// </summary>
        /// <param name="name">The Name of the Container</param>
        /// <param name="containerId">The Id of the Container</param>
        /// <param name="ready">The container ready status</param>
        /// <param name="started">The container start status</param>
        /// <param name="restartCount">The container restart count</param>
        public ReplicaContainer(string name = default(string), string containerId = default(string), bool? ready = default(bool?), bool? started = default(bool?), int? restartCount = default(int?))
        {
            Name = name;
            ContainerId = containerId;
            Ready = ready;
            Started = started;
            RestartCount = restartCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Name of the Container
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Id of the Container
        /// </summary>
        [JsonProperty(PropertyName = "containerId")]
        public string ContainerId { get; set; }

        /// <summary>
        /// Gets or sets the container ready status
        /// </summary>
        [JsonProperty(PropertyName = "ready")]
        public bool? Ready { get; set; }

        /// <summary>
        /// Gets or sets the container start status
        /// </summary>
        [JsonProperty(PropertyName = "started")]
        public bool? Started { get; set; }

        /// <summary>
        /// Gets or sets the container restart count
        /// </summary>
        [JsonProperty(PropertyName = "restartCount")]
        public int? RestartCount { get; set; }

    }
}
