// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Allow to exclude some variable satisfy the condition for the WAF check. </summary>
    public partial class ApplicationGatewayFirewallExclusion
    {
        /// <summary> Initializes a new instance of ApplicationGatewayFirewallExclusion. </summary>
        /// <param name="matchVariable"> The variable to be excluded. </param>
        /// <param name="selectorMatchOperator"> When matchVariable is a collection, operate on the selector to specify which elements in the collection this exclusion applies to. </param>
        /// <param name="selector"> When matchVariable is a collection, operator used to specify which elements in the collection this exclusion applies to. </param>
        public ApplicationGatewayFirewallExclusion(string matchVariable, string selectorMatchOperator, string selector)
        {
            if (matchVariable == null)
            {
                throw new ArgumentNullException(nameof(matchVariable));
            }
            if (selectorMatchOperator == null)
            {
                throw new ArgumentNullException(nameof(selectorMatchOperator));
            }
            if (selector == null)
            {
                throw new ArgumentNullException(nameof(selector));
            }

            MatchVariable = matchVariable;
            SelectorMatchOperator = selectorMatchOperator;
            Selector = selector;
        }

        /// <summary> The variable to be excluded. </summary>
        public string MatchVariable { get; set; }
        /// <summary> When matchVariable is a collection, operate on the selector to specify which elements in the collection this exclusion applies to. </summary>
        public string SelectorMatchOperator { get; set; }
        /// <summary> When matchVariable is a collection, operator used to specify which elements in the collection this exclusion applies to. </summary>
        public string Selector { get; set; }
    }
}
