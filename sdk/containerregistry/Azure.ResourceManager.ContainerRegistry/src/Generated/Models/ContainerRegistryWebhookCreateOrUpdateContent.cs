// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The parameters for creating a webhook. </summary>
    public partial class ContainerRegistryWebhookCreateOrUpdateContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryWebhookCreateOrUpdateContent"/>. </summary>
        /// <param name="location"> The location of the webhook. This cannot be changed after the resource is created. </param>
        public ContainerRegistryWebhookCreateOrUpdateContent(AzureLocation location)
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            Location = location;
            CustomHeaders = new ChangeTrackingDictionary<string, string>();
            Actions = new ChangeTrackingList<ContainerRegistryWebhookAction>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryWebhookCreateOrUpdateContent"/>. </summary>
        /// <param name="tags"> The tags for the webhook. </param>
        /// <param name="location"> The location of the webhook. This cannot be changed after the resource is created. </param>
        /// <param name="serviceUri"> The service URI for the webhook to post notifications. </param>
        /// <param name="customHeaders"> Custom headers that will be added to the webhook notifications. </param>
        /// <param name="status"> The status of the webhook at the time the operation was called. </param>
        /// <param name="scope"> The scope of repositories where the event can be triggered. For example, 'foo:*' means events for all tags under repository 'foo'. 'foo:bar' means events for 'foo:bar' only. 'foo' is equivalent to 'foo:latest'. Empty means all events. </param>
        /// <param name="actions"> The list of actions that trigger the webhook to post notifications. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerRegistryWebhookCreateOrUpdateContent(IDictionary<string, string> tags, AzureLocation location, Uri serviceUri, IDictionary<string, string> customHeaders, ContainerRegistryWebhookStatus? status, string scope, IList<ContainerRegistryWebhookAction> actions, Dictionary<string, BinaryData> rawData)
        {
            Tags = tags;
            Location = location;
            ServiceUri = serviceUri;
            CustomHeaders = customHeaders;
            Status = status;
            Scope = scope;
            Actions = actions;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryWebhookCreateOrUpdateContent"/> for deserialization. </summary>
        internal ContainerRegistryWebhookCreateOrUpdateContent()
        {
        }

        /// <summary> The tags for the webhook. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The location of the webhook. This cannot be changed after the resource is created. </summary>
        public AzureLocation Location { get; }
        /// <summary> The service URI for the webhook to post notifications. </summary>
        public Uri ServiceUri { get; set; }
        /// <summary> Custom headers that will be added to the webhook notifications. </summary>
        public IDictionary<string, string> CustomHeaders { get; }
        /// <summary> The status of the webhook at the time the operation was called. </summary>
        public ContainerRegistryWebhookStatus? Status { get; set; }
        /// <summary> The scope of repositories where the event can be triggered. For example, 'foo:*' means events for all tags under repository 'foo'. 'foo:bar' means events for 'foo:bar' only. 'foo' is equivalent to 'foo:latest'. Empty means all events. </summary>
        public string Scope { get; set; }
        /// <summary> The list of actions that trigger the webhook to post notifications. </summary>
        public IList<ContainerRegistryWebhookAction> Actions { get; }
    }
}
