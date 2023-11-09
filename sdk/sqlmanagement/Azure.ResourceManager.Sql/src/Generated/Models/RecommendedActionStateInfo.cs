// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Contains information of current state for an Azure SQL Database, Server or Elastic Pool Recommended Action. </summary>
    public partial class RecommendedActionStateInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RecommendedActionStateInfo"/>. </summary>
        /// <param name="currentValue"> Current state the recommended action is in. Some commonly used states are: Active      -&gt; recommended action is active and no action has been taken yet. Pending     -&gt; recommended action is approved for and is awaiting execution. Executing   -&gt; recommended action is being applied on the user database. Verifying   -&gt; recommended action was applied and is being verified of its usefulness by the system. Success     -&gt; recommended action was applied and improvement found during verification. Pending Revert  -&gt; verification found little or no improvement so recommended action is queued for revert or user has manually reverted. Reverting   -&gt; changes made while applying recommended action are being reverted on the user database. Reverted    -&gt; successfully reverted the changes made by recommended action on user database. Ignored     -&gt; user explicitly ignored/discarded the recommended action. </param>
        public RecommendedActionStateInfo(RecommendedActionCurrentState currentValue)
        {
            CurrentValue = currentValue;
        }

        /// <summary> Initializes a new instance of <see cref="RecommendedActionStateInfo"/>. </summary>
        /// <param name="currentValue"> Current state the recommended action is in. Some commonly used states are: Active      -&gt; recommended action is active and no action has been taken yet. Pending     -&gt; recommended action is approved for and is awaiting execution. Executing   -&gt; recommended action is being applied on the user database. Verifying   -&gt; recommended action was applied and is being verified of its usefulness by the system. Success     -&gt; recommended action was applied and improvement found during verification. Pending Revert  -&gt; verification found little or no improvement so recommended action is queued for revert or user has manually reverted. Reverting   -&gt; changes made while applying recommended action are being reverted on the user database. Reverted    -&gt; successfully reverted the changes made by recommended action on user database. Ignored     -&gt; user explicitly ignored/discarded the recommended action. </param>
        /// <param name="actionInitiatedBy"> Gets who initiated the execution of this recommended action. Possible Value are: User    -&gt; When user explicity notified system to apply the recommended action. System  -&gt; When auto-execute status of this advisor was set to 'Enabled', in which case the system applied it. </param>
        /// <param name="lastModified"> Gets the time when the state was last modified. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RecommendedActionStateInfo(RecommendedActionCurrentState currentValue, RecommendedActionInitiatedBy? actionInitiatedBy, DateTimeOffset? lastModified, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CurrentValue = currentValue;
            ActionInitiatedBy = actionInitiatedBy;
            LastModified = lastModified;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RecommendedActionStateInfo"/> for deserialization. </summary>
        internal RecommendedActionStateInfo()
        {
        }

        /// <summary> Current state the recommended action is in. Some commonly used states are: Active      -&gt; recommended action is active and no action has been taken yet. Pending     -&gt; recommended action is approved for and is awaiting execution. Executing   -&gt; recommended action is being applied on the user database. Verifying   -&gt; recommended action was applied and is being verified of its usefulness by the system. Success     -&gt; recommended action was applied and improvement found during verification. Pending Revert  -&gt; verification found little or no improvement so recommended action is queued for revert or user has manually reverted. Reverting   -&gt; changes made while applying recommended action are being reverted on the user database. Reverted    -&gt; successfully reverted the changes made by recommended action on user database. Ignored     -&gt; user explicitly ignored/discarded the recommended action. </summary>
        public RecommendedActionCurrentState CurrentValue { get; set; }
        /// <summary> Gets who initiated the execution of this recommended action. Possible Value are: User    -&gt; When user explicity notified system to apply the recommended action. System  -&gt; When auto-execute status of this advisor was set to 'Enabled', in which case the system applied it. </summary>
        public RecommendedActionInitiatedBy? ActionInitiatedBy { get; }
        /// <summary> Gets the time when the state was last modified. </summary>
        public DateTimeOffset? LastModified { get; }
    }
}
