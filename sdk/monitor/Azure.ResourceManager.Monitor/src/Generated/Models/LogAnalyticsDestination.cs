// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Log Analytics destination. </summary>
    public partial class LogAnalyticsDestination
    {
        /// <summary> Initializes a new instance of LogAnalyticsDestination. </summary>
        public LogAnalyticsDestination()
        {
        }

        /// <summary> Initializes a new instance of LogAnalyticsDestination. </summary>
        /// <param name="workspaceResourceId"> The resource ID of the Log Analytics workspace. </param>
        /// <param name="workspaceId"> The Customer ID of the Log Analytics workspace. </param>
        /// <param name="name">
        /// A friendly name for the destination. 
        /// This name should be unique across all destinations (regardless of type) within the data collection rule.
        /// </param>
        internal LogAnalyticsDestination(ResourceIdentifier workspaceResourceId, string workspaceId, string name)
        {
            WorkspaceResourceId = workspaceResourceId;
            WorkspaceId = workspaceId;
            Name = name;
        }

        /// <summary> The resource ID of the Log Analytics workspace. </summary>
        public ResourceIdentifier WorkspaceResourceId { get; set; }
        /// <summary> The Customer ID of the Log Analytics workspace. </summary>
        public string WorkspaceId { get; }
        /// <summary>
        /// A friendly name for the destination. 
        /// This name should be unique across all destinations (regardless of type) within the data collection rule.
        /// </summary>
        public string Name { get; set; }
    }
}
