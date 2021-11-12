// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace SubscriptionClient.Models
{
    /// <summary> Put subscription additional properties. </summary>
    public partial class PutAliasRequestAdditionalProperties
    {
        /// <summary> Initializes a new instance of PutAliasRequestAdditionalProperties. </summary>
        public PutAliasRequestAdditionalProperties()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Management group Id for the subscription. </summary>
        public string ManagementGroupId { get; set; }
        /// <summary> Tenant Id of the subscription. </summary>
        public string SubscriptionTenantId { get; set; }
        /// <summary> Owner Id of the subscription. </summary>
        public string SubscriptionOwnerId { get; set; }
        /// <summary> Tags for the subscription. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
