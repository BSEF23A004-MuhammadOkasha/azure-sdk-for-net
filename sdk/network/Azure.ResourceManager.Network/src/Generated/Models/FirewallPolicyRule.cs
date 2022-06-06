// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary>
    /// Properties of a rule.
    /// Please note <see cref="FirewallPolicyRule"/> is the base class. In order to more specifically assign or retrieve the value of this property, the derived class is needed.
    /// The available derived classes include <see cref="ApplicationRule"/>, <see cref="NatRule"/>, <see cref="NetworkRule"/>.
    /// </summary>
    public partial class FirewallPolicyRule
    {
        /// <summary> Initializes a new instance of FirewallPolicyRule. </summary>
        public FirewallPolicyRule()
        {
        }

        /// <summary> Initializes a new instance of FirewallPolicyRule. </summary>
        /// <param name="name"> Name of the rule. </param>
        /// <param name="description"> Description of the rule. </param>
        /// <param name="ruleType"> Rule Type. </param>
        internal FirewallPolicyRule(string name, string description, FirewallPolicyRuleType ruleType)
        {
            Name = name;
            Description = description;
            RuleType = ruleType;
        }

        /// <summary> Name of the rule. </summary>
        public string Name { get; set; }
        /// <summary> Description of the rule. </summary>
        public string Description { get; set; }
        /// <summary> Rule Type. </summary>
        internal FirewallPolicyRuleType RuleType { get; set; }
    }
}
