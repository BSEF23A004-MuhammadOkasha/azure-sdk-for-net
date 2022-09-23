// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The agent that initiated the event. For most situations, this could be from the authorization context of the request. </summary>
    internal partial class ContainerRegistryWebhookEventActor
    {
        /// <summary> Initializes a new instance of ContainerRegistryWebhookEventActor. </summary>
        internal ContainerRegistryWebhookEventActor()
        {
        }

        /// <summary> Initializes a new instance of ContainerRegistryWebhookEventActor. </summary>
        /// <param name="name"> The subject or username associated with the request context that generated the event. </param>
        internal ContainerRegistryWebhookEventActor(string name)
        {
            Name = name;
        }

        /// <summary> The subject or username associated with the request context that generated the event. </summary>
        public string Name { get; }
    }
}
