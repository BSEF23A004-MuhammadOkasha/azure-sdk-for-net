// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A class representing the SecurityAlertsSuppressionRule data model.
    /// Describes the suppression rule
    /// </summary>
    public partial class SecurityAlertsSuppressionRuleData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SecurityAlertsSuppressionRuleData"/>. </summary>
        public SecurityAlertsSuppressionRuleData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SecurityAlertsSuppressionRuleData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="alertType"> Type of the alert to automatically suppress. For all alert types, use '*'. </param>
        /// <param name="lastModifiedOn"> The last time this rule was modified. </param>
        /// <param name="expireOn"> Expiration date of the rule, if value is not provided or provided as null this field will default to the maximum allowed expiration date. </param>
        /// <param name="reason"> The reason for dismissing the alert. </param>
        /// <param name="state"> Possible states of the rule. </param>
        /// <param name="comment"> Any comment regarding the rule. </param>
        /// <param name="suppressionAlertsScope"> The suppression conditions. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityAlertsSuppressionRuleData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string alertType, DateTimeOffset? lastModifiedOn, DateTimeOffset? expireOn, string reason, SecurityAlertsSuppressionRuleState? state, string comment, SuppressionAlertsScope suppressionAlertsScope, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            AlertType = alertType;
            LastModifiedOn = lastModifiedOn;
            ExpireOn = expireOn;
            Reason = reason;
            State = state;
            Comment = comment;
            SuppressionAlertsScope = suppressionAlertsScope;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Type of the alert to automatically suppress. For all alert types, use '*'. </summary>
        public string AlertType { get; set; }
        /// <summary> The last time this rule was modified. </summary>
        public DateTimeOffset? LastModifiedOn { get; }
        /// <summary> Expiration date of the rule, if value is not provided or provided as null this field will default to the maximum allowed expiration date. </summary>
        public DateTimeOffset? ExpireOn { get; set; }
        /// <summary> The reason for dismissing the alert. </summary>
        public string Reason { get; set; }
        /// <summary> Possible states of the rule. </summary>
        public SecurityAlertsSuppressionRuleState? State { get; set; }
        /// <summary> Any comment regarding the rule. </summary>
        public string Comment { get; set; }
        /// <summary> The suppression conditions. </summary>
        internal SuppressionAlertsScope SuppressionAlertsScope { get; set; }
        /// <summary> All the conditions inside need to be true in order to suppress the alert. </summary>
        public IList<SuppressionAlertsScopeElement> SuppressionAlertsScopeAllOf
        {
            get => SuppressionAlertsScope is null ? default : SuppressionAlertsScope.AllOf;
            set => SuppressionAlertsScope = new SuppressionAlertsScope(value);
        }
    }
}
