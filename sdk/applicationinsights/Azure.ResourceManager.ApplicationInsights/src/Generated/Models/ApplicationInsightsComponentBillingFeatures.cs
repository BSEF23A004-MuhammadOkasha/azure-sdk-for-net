// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.ApplicationInsights;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    /// <summary> An Application Insights component billing features. </summary>
    public partial class ApplicationInsightsComponentBillingFeatures
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

        /// <summary> Initializes a new instance of <see cref="ApplicationInsightsComponentBillingFeatures"/>. </summary>
        public ApplicationInsightsComponentBillingFeatures()
        {
            CurrentBillingFeatures = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationInsightsComponentBillingFeatures"/>. </summary>
        /// <param name="dataVolumeCap"> An Application Insights component daily data volume cap. </param>
        /// <param name="currentBillingFeatures"> Current enabled pricing plan. When the component is in the Enterprise plan, this will list both 'Basic' and 'Application Insights Enterprise'. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplicationInsightsComponentBillingFeatures(ApplicationInsightsComponentDataVolumeCap dataVolumeCap, IList<string> currentBillingFeatures, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DataVolumeCap = dataVolumeCap;
            CurrentBillingFeatures = currentBillingFeatures;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> An Application Insights component daily data volume cap. </summary>
        [WirePath("DataVolumeCap")]
        public ApplicationInsightsComponentDataVolumeCap DataVolumeCap { get; set; }
        /// <summary> Current enabled pricing plan. When the component is in the Enterprise plan, this will list both 'Basic' and 'Application Insights Enterprise'. </summary>
        [WirePath("CurrentBillingFeatures")]
        public IList<string> CurrentBillingFeatures { get; }
    }
}
