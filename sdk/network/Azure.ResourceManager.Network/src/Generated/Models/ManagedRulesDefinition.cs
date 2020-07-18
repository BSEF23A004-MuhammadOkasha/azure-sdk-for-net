// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Allow to exclude some variable satisfy the condition for the WAF check. </summary>
    public partial class ManagedRulesDefinition
    {
        /// <summary> Initializes a new instance of ManagedRulesDefinition. </summary>
        /// <param name="managedRuleSets"> The managed rule sets that are associated with the policy. </param>
        public ManagedRulesDefinition(IEnumerable<ManagedRuleSet> managedRuleSets)
        {
            if (managedRuleSets == null)
            {
                throw new ArgumentNullException(nameof(managedRuleSets));
            }

            ManagedRuleSets = managedRuleSets.ToList();
        }

        /// <summary> Initializes a new instance of ManagedRulesDefinition. </summary>
        /// <param name="exclusions"> The Exclusions that are applied on the policy. </param>
        /// <param name="managedRuleSets"> The managed rule sets that are associated with the policy. </param>
        internal ManagedRulesDefinition(IList<OwaspCrsExclusionEntry> exclusions, IList<ManagedRuleSet> managedRuleSets)
        {
            Exclusions = exclusions;
            ManagedRuleSets = managedRuleSets ?? new List<ManagedRuleSet>();
        }

        /// <summary> The Exclusions that are applied on the policy. </summary>
        public IList<OwaspCrsExclusionEntry> Exclusions { get; set; }
        /// <summary> The managed rule sets that are associated with the policy. </summary>
        public IList<ManagedRuleSet> ManagedRuleSets { get; }
    }
}
