// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    /// <summary> Request of a switch billing Operation. </summary>
    public partial class NewRelicSwitchBillingContent
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NewRelicSwitchBillingContent"/>. </summary>
        /// <param name="userEmail"> User Email. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="userEmail"/> is null. </exception>
        public NewRelicSwitchBillingContent(string userEmail)
        {
            Argument.AssertNotNull(userEmail, nameof(userEmail));

            UserEmail = userEmail;
        }

        /// <summary> Initializes a new instance of <see cref="NewRelicSwitchBillingContent"/>. </summary>
        /// <param name="azureResourceId"> Azure resource Id. </param>
        /// <param name="organizationId"> Organization id. </param>
        /// <param name="planData"> Plan details. </param>
        /// <param name="userEmail"> User Email. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NewRelicSwitchBillingContent(ResourceIdentifier azureResourceId, string organizationId, NewRelicPlanDetails planData, string userEmail, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AzureResourceId = azureResourceId;
            OrganizationId = organizationId;
            PlanData = planData;
            UserEmail = userEmail;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="NewRelicSwitchBillingContent"/> for deserialization. </summary>
        internal NewRelicSwitchBillingContent()
        {
        }

        /// <summary> Azure resource Id. </summary>
        [WirePath("azureResourceId")]
        public ResourceIdentifier AzureResourceId { get; set; }
        /// <summary> Organization id. </summary>
        [WirePath("organizationId")]
        public string OrganizationId { get; set; }
        /// <summary> Plan details. </summary>
        [WirePath("planData")]
        public NewRelicPlanDetails PlanData { get; set; }
        /// <summary> User Email. </summary>
        [WirePath("userEmail")]
        public string UserEmail { get; }
    }
}
