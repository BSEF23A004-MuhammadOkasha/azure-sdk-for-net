// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An action group resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ActionGroupResource : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ActionGroupResource class.
        /// </summary>
        public ActionGroupResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ActionGroupResource class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="groupShortName">The short name of the action group.
        /// This will be used in SMS messages.</param>
        /// <param name="enabled">Indicates whether this action group is
        /// enabled. If an action group is not enabled, then none of its
        /// receivers will receive communications.</param>
        /// <param name="id">Azure resource Id</param>
        /// <param name="name">Azure resource name</param>
        /// <param name="type">Azure resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="emailReceivers">The list of email receivers that are
        /// part of this action group.</param>
        /// <param name="smsReceivers">The list of SMS receivers that are part
        /// of this action group.</param>
        /// <param name="webhookReceivers">The list of webhook receivers that
        /// are part of this action group.</param>
        /// <param name="itsmReceivers">The list of ITSM receivers that are
        /// part of this action group.</param>
        /// <param name="azureAppPushReceivers">The list of AzureAppPush
        /// receivers that are part of this action group.</param>
        /// <param name="automationRunbookReceivers">The list of
        /// AutomationRunbook receivers that are part of this action
        /// group.</param>
        /// <param name="voiceReceivers">The list of voice receivers that are
        /// part of this action group.</param>
        /// <param name="logicAppReceivers">The list of logic app receivers
        /// that are part of this action group.</param>
        /// <param name="azureFunctionReceivers">The list of azure function
        /// receivers that are part of this action group.</param>
        public ActionGroupResource(string location, string groupShortName, bool enabled, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), IList<EmailReceiver> emailReceivers = default(IList<EmailReceiver>), IList<SmsReceiver> smsReceivers = default(IList<SmsReceiver>), IList<WebhookReceiver> webhookReceivers = default(IList<WebhookReceiver>), IList<ItsmReceiver> itsmReceivers = default(IList<ItsmReceiver>), IList<AzureAppPushReceiver> azureAppPushReceivers = default(IList<AzureAppPushReceiver>), IList<AutomationRunbookReceiver> automationRunbookReceivers = default(IList<AutomationRunbookReceiver>), IList<VoiceReceiver> voiceReceivers = default(IList<VoiceReceiver>), IList<LogicAppReceiver> logicAppReceivers = default(IList<LogicAppReceiver>), IList<AzureFunctionReceiver> azureFunctionReceivers = default(IList<AzureFunctionReceiver>))
            : base(location, id, name, type, tags)
        {
            GroupShortName = groupShortName;
            Enabled = enabled;
            EmailReceivers = emailReceivers;
            SmsReceivers = smsReceivers;
            WebhookReceivers = webhookReceivers;
            ItsmReceivers = itsmReceivers;
            AzureAppPushReceivers = azureAppPushReceivers;
            AutomationRunbookReceivers = automationRunbookReceivers;
            VoiceReceivers = voiceReceivers;
            LogicAppReceivers = logicAppReceivers;
            AzureFunctionReceivers = azureFunctionReceivers;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the short name of the action group. This will be used
        /// in SMS messages.
        /// </summary>
        [JsonProperty(PropertyName = "properties.groupShortName")]
        public string GroupShortName { get; set; }

        /// <summary>
        /// Gets or sets indicates whether this action group is enabled. If an
        /// action group is not enabled, then none of its receivers will
        /// receive communications.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or sets the list of email receivers that are part of this
        /// action group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.emailReceivers")]
        public IList<EmailReceiver> EmailReceivers { get; set; }

        /// <summary>
        /// Gets or sets the list of SMS receivers that are part of this action
        /// group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.smsReceivers")]
        public IList<SmsReceiver> SmsReceivers { get; set; }

        /// <summary>
        /// Gets or sets the list of webhook receivers that are part of this
        /// action group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.webhookReceivers")]
        public IList<WebhookReceiver> WebhookReceivers { get; set; }

        /// <summary>
        /// Gets or sets the list of ITSM receivers that are part of this
        /// action group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.itsmReceivers")]
        public IList<ItsmReceiver> ItsmReceivers { get; set; }

        /// <summary>
        /// Gets or sets the list of AzureAppPush receivers that are part of
        /// this action group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.azureAppPushReceivers")]
        public IList<AzureAppPushReceiver> AzureAppPushReceivers { get; set; }

        /// <summary>
        /// Gets or sets the list of AutomationRunbook receivers that are part
        /// of this action group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.automationRunbookReceivers")]
        public IList<AutomationRunbookReceiver> AutomationRunbookReceivers { get; set; }

        /// <summary>
        /// Gets or sets the list of voice receivers that are part of this
        /// action group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.voiceReceivers")]
        public IList<VoiceReceiver> VoiceReceivers { get; set; }

        /// <summary>
        /// Gets or sets the list of logic app receivers that are part of this
        /// action group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.logicAppReceivers")]
        public IList<LogicAppReceiver> LogicAppReceivers { get; set; }

        /// <summary>
        /// Gets or sets the list of azure function receivers that are part of
        /// this action group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.azureFunctionReceivers")]
        public IList<AzureFunctionReceiver> AzureFunctionReceivers { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (GroupShortName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "GroupShortName");
            }
            if (GroupShortName != null)
            {
                if (GroupShortName.Length > 12)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "GroupShortName", 12);
                }
            }
            if (EmailReceivers != null)
            {
                foreach (var element in EmailReceivers)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (SmsReceivers != null)
            {
                foreach (var element1 in SmsReceivers)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (WebhookReceivers != null)
            {
                foreach (var element2 in WebhookReceivers)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
            if (ItsmReceivers != null)
            {
                foreach (var element3 in ItsmReceivers)
                {
                    if (element3 != null)
                    {
                        element3.Validate();
                    }
                }
            }
            if (AzureAppPushReceivers != null)
            {
                foreach (var element4 in AzureAppPushReceivers)
                {
                    if (element4 != null)
                    {
                        element4.Validate();
                    }
                }
            }
            if (AutomationRunbookReceivers != null)
            {
                foreach (var element5 in AutomationRunbookReceivers)
                {
                    if (element5 != null)
                    {
                        element5.Validate();
                    }
                }
            }
            if (VoiceReceivers != null)
            {
                foreach (var element6 in VoiceReceivers)
                {
                    if (element6 != null)
                    {
                        element6.Validate();
                    }
                }
            }
            if (LogicAppReceivers != null)
            {
                foreach (var element7 in LogicAppReceivers)
                {
                    if (element7 != null)
                    {
                        element7.Validate();
                    }
                }
            }
            if (AzureFunctionReceivers != null)
            {
                foreach (var element8 in AzureFunctionReceivers)
                {
                    if (element8 != null)
                    {
                        element8.Validate();
                    }
                }
            }
        }
    }
}
