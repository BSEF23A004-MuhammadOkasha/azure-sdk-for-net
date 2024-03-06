// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> NAT rule collection resource. </summary>
    public partial class AzureFirewallNatRuleCollectionData : NetworkResourceData
    {
        /// <summary> Initializes a new instance of <see cref="AzureFirewallNatRuleCollectionData"/>. </summary>
        public AzureFirewallNatRuleCollectionData()
        {
            Rules = new ChangeTrackingList<AzureFirewallNatRule>();
        }

        /// <summary> Initializes a new instance of <see cref="AzureFirewallNatRuleCollectionData"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="priority"> Priority of the NAT rule collection resource. </param>
        /// <param name="action"> The action type of a NAT rule collection. </param>
        /// <param name="rules"> Collection of rules used by a NAT rule collection. </param>
        /// <param name="provisioningState"> The provisioning state of the NAT rule collection resource. </param>
        internal AzureFirewallNatRuleCollectionData(ResourceIdentifier id, string name, ResourceType? resourceType, IDictionary<string, BinaryData> serializedAdditionalRawData, ETag? etag, int? priority, AzureFirewallNatRCAction action, IList<AzureFirewallNatRule> rules, NetworkProvisioningState? provisioningState) : base(id, name, resourceType, serializedAdditionalRawData)
        {
            ETag = etag;
            Priority = priority;
            Action = action;
            Rules = rules;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> Priority of the NAT rule collection resource. </summary>
        public int? Priority { get; set; }
        /// <summary> The action type of a NAT rule collection. </summary>
        internal AzureFirewallNatRCAction Action { get; set; }
        /// <summary> The type of action. </summary>
        public AzureFirewallNatRCActionType? ActionType
        {
            get => Action is null ? default : Action.ActionType;
            set
            {
                if (Action is null)
                    Action = new AzureFirewallNatRCAction();
                Action.ActionType = value;
            }
        }

        /// <summary> Collection of rules used by a NAT rule collection. </summary>
        public IList<AzureFirewallNatRule> Rules { get; }
        /// <summary> The provisioning state of the NAT rule collection resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
