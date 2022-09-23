// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> A webhook receiver. </summary>
    public partial class MonitorWebhookReceiver
    {
        /// <summary> Initializes a new instance of MonitorWebhookReceiver. </summary>
        /// <param name="name"> The name of the webhook receiver. Names must be unique across all receivers within an action group. </param>
        /// <param name="serviceUri"> The URI where webhooks should be sent. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="serviceUri"/> is null. </exception>
        public MonitorWebhookReceiver(string name, Uri serviceUri)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (serviceUri == null)
            {
                throw new ArgumentNullException(nameof(serviceUri));
            }

            Name = name;
            ServiceUri = serviceUri;
        }

        /// <summary> Initializes a new instance of MonitorWebhookReceiver. </summary>
        /// <param name="name"> The name of the webhook receiver. Names must be unique across all receivers within an action group. </param>
        /// <param name="serviceUri"> The URI where webhooks should be sent. </param>
        /// <param name="useCommonAlertSchema"> Indicates whether to use common alert schema. </param>
        /// <param name="useAadAuth"> Indicates whether or not use AAD authentication. </param>
        /// <param name="objectId"> Indicates the webhook app object Id for aad auth. </param>
        /// <param name="identifierUri"> Indicates the identifier uri for aad auth. </param>
        /// <param name="tenantId"> Indicates the tenant id for aad auth. </param>
        internal MonitorWebhookReceiver(string name, Uri serviceUri, bool? useCommonAlertSchema, bool? useAadAuth, string objectId, Uri identifierUri, Guid? tenantId)
        {
            Name = name;
            ServiceUri = serviceUri;
            UseCommonAlertSchema = useCommonAlertSchema;
            UseAadAuth = useAadAuth;
            ObjectId = objectId;
            IdentifierUri = identifierUri;
            TenantId = tenantId;
        }

        /// <summary> The name of the webhook receiver. Names must be unique across all receivers within an action group. </summary>
        public string Name { get; set; }
        /// <summary> The URI where webhooks should be sent. </summary>
        public Uri ServiceUri { get; set; }
        /// <summary> Indicates whether to use common alert schema. </summary>
        public bool? UseCommonAlertSchema { get; set; }
        /// <summary> Indicates whether or not use AAD authentication. </summary>
        public bool? UseAadAuth { get; set; }
        /// <summary> Indicates the webhook app object Id for aad auth. </summary>
        public string ObjectId { get; set; }
        /// <summary> Indicates the identifier uri for aad auth. </summary>
        public Uri IdentifierUri { get; set; }
        /// <summary> Indicates the tenant id for aad auth. </summary>
        public Guid? TenantId { get; set; }
    }
}
