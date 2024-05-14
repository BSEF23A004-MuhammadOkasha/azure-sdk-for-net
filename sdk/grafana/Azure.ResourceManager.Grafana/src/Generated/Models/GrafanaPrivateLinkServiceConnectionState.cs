// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Grafana.Models
{
    /// <summary> A collection of information about the state of the connection between service consumer and provider. </summary>
    public partial class GrafanaPrivateLinkServiceConnectionState
    {
        /// <summary> Initializes a new instance of <see cref="GrafanaPrivateLinkServiceConnectionState"/>. </summary>
        public GrafanaPrivateLinkServiceConnectionState()
        {
        }

        /// <summary> Initializes a new instance of <see cref="GrafanaPrivateLinkServiceConnectionState"/>. </summary>
        /// <param name="status"> Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service. </param>
        /// <param name="description"> The reason for approval/rejection of the connection. </param>
        /// <param name="actionsRequired"> A message indicating if changes on the service provider require any updates on the consumer. </param>
        internal GrafanaPrivateLinkServiceConnectionState(GrafanaPrivateEndpointServiceConnectionStatus? status, string description, string actionsRequired)
        {
            Status = status;
            Description = description;
            ActionsRequired = actionsRequired;
        }

        /// <summary> Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service. </summary>
        public GrafanaPrivateEndpointServiceConnectionStatus? Status { get; set; }
        /// <summary> The reason for approval/rejection of the connection. </summary>
        public string Description { get; set; }
        /// <summary> A message indicating if changes on the service provider require any updates on the consumer. </summary>
        public string ActionsRequired { get; set; }
    }
}
