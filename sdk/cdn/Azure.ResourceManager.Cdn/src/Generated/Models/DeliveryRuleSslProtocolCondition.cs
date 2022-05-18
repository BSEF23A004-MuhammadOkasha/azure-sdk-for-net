// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the SslProtocol condition for the delivery rule. </summary>
    public partial class DeliveryRuleSslProtocolCondition : DeliveryRuleCondition
    {
        /// <summary> Initializes a new instance of DeliveryRuleSslProtocolCondition. </summary>
        /// <param name="parameters"> Defines the parameters for the condition. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public DeliveryRuleSslProtocolCondition(SslProtocolMatchConditionDefinition parameters)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            Parameters = parameters;
            Name = MatchVariable.SslProtocol;
        }

        /// <summary> Initializes a new instance of DeliveryRuleSslProtocolCondition. </summary>
        /// <param name="name"> The name of the condition for the delivery rule. </param>
        /// <param name="parameters"> Defines the parameters for the condition. </param>
        internal DeliveryRuleSslProtocolCondition(MatchVariable name, SslProtocolMatchConditionDefinition parameters) : base(name)
        {
            Parameters = parameters;
            Name = name;
        }

        /// <summary> Defines the parameters for the condition. </summary>
        public SslProtocolMatchConditionDefinition Parameters { get; set; }
    }
}
