// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Properties of the FirewallPolicyFilterRuleCollectionAction. </summary>
    internal partial class FirewallPolicyFilterRuleCollectionAction
    {
        /// <summary> Initializes a new instance of FirewallPolicyFilterRuleCollectionAction. </summary>
        public FirewallPolicyFilterRuleCollectionAction()
        {
        }

        /// <summary> Initializes a new instance of FirewallPolicyFilterRuleCollectionAction. </summary>
        /// <param name="firewallPolicyFilterRuleCollectionActionType"> The type of action. </param>
        internal FirewallPolicyFilterRuleCollectionAction(FirewallPolicyFilterRuleCollectionActionType? firewallPolicyFilterRuleCollectionActionType)
        {
            FirewallPolicyFilterRuleCollectionActionType = firewallPolicyFilterRuleCollectionActionType;
        }

        /// <summary> The type of action. </summary>
        public FirewallPolicyFilterRuleCollectionActionType? FirewallPolicyFilterRuleCollectionActionType { get; set; }
    }
}
