// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    /// <summary> Rule Group resource. </summary>
    public partial class FirewallPolicyRuleGroup : SubResource
    {
        /// <summary> Initializes a new instance of FirewallPolicyRuleGroup. </summary>
        public FirewallPolicyRuleGroup()
        {
            Rules = new ChangeTrackingList<FirewallPolicyRule>();
        }

        /// <summary> Initializes a new instance of FirewallPolicyRuleGroup. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> The name of the resource that is unique within a resource group. This name can be used to access the resource. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="type"> Rule Group type. </param>
        /// <param name="priority"> Priority of the Firewall Policy Rule Group resource. </param>
        /// <param name="rules"> Group of Firewall Policy rules. </param>
        /// <param name="provisioningState"> The provisioning state of the firewall policy rule group resource. </param>
        internal FirewallPolicyRuleGroup(string id, string name, string etag, string type, int? priority, IList<FirewallPolicyRule> rules, ProvisioningState? provisioningState) : base(id)
        {
            Name = name;
            Etag = etag;
            Type = type;
            Priority = priority;
            Rules = rules;
            ProvisioningState = provisioningState;
        }

        /// <summary> The name of the resource that is unique within a resource group. This name can be used to access the resource. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> Rule Group type. </summary>
        public string Type { get; }
        /// <summary> Priority of the Firewall Policy Rule Group resource. </summary>
        public int? Priority { get; set; }
        /// <summary> Group of Firewall Policy rules. </summary>
        public IList<FirewallPolicyRule> Rules { get; }
        /// <summary> The provisioning state of the firewall policy rule group resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
