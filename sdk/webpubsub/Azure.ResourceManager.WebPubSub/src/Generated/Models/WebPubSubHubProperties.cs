// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.WebPubSub.Models
{
    /// <summary> Properties of a hub. </summary>
    public partial class WebPubSubHubProperties
    {
        /// <summary> Initializes a new instance of WebPubSubHubProperties. </summary>
        public WebPubSubHubProperties()
        {
            EventHandlers = new ChangeTrackingList<WebPubSubEventHandler>();
        }

        /// <summary> Initializes a new instance of WebPubSubHubProperties. </summary>
        /// <param name="eventHandlers"> Event handler of a hub. </param>
        /// <param name="anonymousConnectPolicy"> The settings for configuring if anonymous connections are allowed for this hub: &quot;allow&quot; or &quot;deny&quot;. Default to &quot;deny&quot;. </param>
        internal WebPubSubHubProperties(IList<WebPubSubEventHandler> eventHandlers, string anonymousConnectPolicy)
        {
            EventHandlers = eventHandlers;
            AnonymousConnectPolicy = anonymousConnectPolicy;
        }

        /// <summary> Event handler of a hub. </summary>
        public IList<WebPubSubEventHandler> EventHandlers { get; }
        /// <summary> The settings for configuring if anonymous connections are allowed for this hub: &quot;allow&quot; or &quot;deny&quot;. Default to &quot;deny&quot;. </summary>
        public string AnonymousConnectPolicy { get; set; }
    }
}
