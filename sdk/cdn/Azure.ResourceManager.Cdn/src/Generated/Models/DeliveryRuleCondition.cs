// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary>
    /// A condition for the delivery rule.
    /// Please note <see cref="DeliveryRuleCondition"/> is the base class. In order to more specifically assign or retrieve the value of this property, the derived class is needed.
    /// The available derived classes include <see cref="DeliveryRuleRemoteAddressCondition"/>, <see cref="DeliveryRuleRequestMethodCondition"/>, <see cref="DeliveryRuleQueryStringCondition"/>, <see cref="DeliveryRulePostArgsCondition"/>, <see cref="DeliveryRuleRequestUriCondition"/>, <see cref="DeliveryRuleRequestHeaderCondition"/>, <see cref="DeliveryRuleRequestBodyCondition"/>, <see cref="DeliveryRuleRequestSchemeCondition"/>, <see cref="DeliveryRuleUriPathCondition"/>, <see cref="DeliveryRuleUriFileExtensionCondition"/>, <see cref="DeliveryRuleUriFileNameCondition"/>, <see cref="DeliveryRuleHttpVersionCondition"/>, <see cref="DeliveryRuleCookiesCondition"/>, <see cref="DeliveryRuleIsDeviceCondition"/>, <see cref="DeliveryRuleSocketAddressCondition"/>, <see cref="DeliveryRuleClientPortCondition"/>, <see cref="DeliveryRuleServerPortCondition"/>, <see cref="DeliveryRuleHostNameCondition"/>, <see cref="DeliveryRuleSslProtocolCondition"/>.
    /// </summary>
    public partial class DeliveryRuleCondition
    {
        /// <summary> Initializes a new instance of DeliveryRuleCondition. </summary>
        public DeliveryRuleCondition()
        {
        }

        /// <summary> Initializes a new instance of DeliveryRuleCondition. </summary>
        /// <param name="name"> The name of the condition for the delivery rule. </param>
        internal DeliveryRuleCondition(MatchVariable name)
        {
            Name = name;
        }

        /// <summary> The name of the condition for the delivery rule. </summary>
        internal MatchVariable Name { get; set; }
    }
}
