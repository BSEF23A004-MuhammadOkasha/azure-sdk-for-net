// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventGrid.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Properties of the corresponding partner destination of a Channel.
    /// </summary>
    public partial class PartnerDestinationInfo
    {
        /// <summary>
        /// Initializes a new instance of the PartnerDestinationInfo class.
        /// </summary>
        public PartnerDestinationInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PartnerDestinationInfo class.
        /// </summary>
        /// <param name="azureSubscriptionId">Azure subscription ID of the
        /// subscriber. The partner destination associated with the channel
        /// will be
        /// created under this Azure subscription.</param>
        /// <param name="resourceGroupName">Azure Resource Group of the
        /// subscriber. The partner destination associated with the channel
        /// will be
        /// created under this resource group.</param>
        /// <param name="name">Name of the partner destination associated with
        /// the channel.</param>
        /// <param name="endpointServiceContext">Additional context of the
        /// partner destination endpoint.</param>
        /// <param name="resourceMoveChangeHistory">Change history of the
        /// resource move.</param>
        public PartnerDestinationInfo(string azureSubscriptionId = default(string), string resourceGroupName = default(string), string name = default(string), string endpointServiceContext = default(string), IList<ResourceMoveChangeHistory> resourceMoveChangeHistory = default(IList<ResourceMoveChangeHistory>))
        {
            AzureSubscriptionId = azureSubscriptionId;
            ResourceGroupName = resourceGroupName;
            Name = name;
            EndpointServiceContext = endpointServiceContext;
            ResourceMoveChangeHistory = resourceMoveChangeHistory;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets azure subscription ID of the subscriber. The partner
        /// destination associated with the channel will be
        /// created under this Azure subscription.
        /// </summary>
        [JsonProperty(PropertyName = "azureSubscriptionId")]
        public string AzureSubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets azure Resource Group of the subscriber. The partner
        /// destination associated with the channel will be
        /// created under this resource group.
        /// </summary>
        [JsonProperty(PropertyName = "resourceGroupName")]
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// Gets or sets name of the partner destination associated with the
        /// channel.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets additional context of the partner destination
        /// endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "endpointServiceContext")]
        public string EndpointServiceContext { get; set; }

        /// <summary>
        /// Gets or sets change history of the resource move.
        /// </summary>
        [JsonProperty(PropertyName = "resourceMoveChangeHistory")]
        public IList<ResourceMoveChangeHistory> ResourceMoveChangeHistory { get; set; }

    }
}
