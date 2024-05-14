// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.BillingBenefits.Models
{
    /// <summary> The roll up count summary of savings plans in each state. </summary>
    internal partial class SavingsPlanSummaryCount
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

        /// <summary> Initializes a new instance of <see cref="SavingsPlanSummaryCount"/>. </summary>
        internal SavingsPlanSummaryCount()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SavingsPlanSummaryCount"/>. </summary>
        /// <param name="succeededCount"> The number of savings plans in Succeeded state. </param>
        /// <param name="failedCount"> The number of savings plans in Failed state. </param>
        /// <param name="expiringCount"> The number of savings plans in Expiring state. </param>
        /// <param name="expiredCount"> The number of savings plans in Expired state. </param>
        /// <param name="pendingCount"> The number of savings plans in Pending state. </param>
        /// <param name="cancelledCount"> The number of savings plans in Cancelled state. </param>
        /// <param name="processingCount"> The number of savings plans in Processing state. </param>
        /// <param name="noBenefitCount"> The number of savings plans in No Benefit state. </param>
        /// <param name="warningCount"> The number of savings plans in Warning state. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SavingsPlanSummaryCount(float? succeededCount, float? failedCount, float? expiringCount, float? expiredCount, float? pendingCount, float? cancelledCount, float? processingCount, float? noBenefitCount, float? warningCount, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SucceededCount = succeededCount;
            FailedCount = failedCount;
            ExpiringCount = expiringCount;
            ExpiredCount = expiredCount;
            PendingCount = pendingCount;
            CancelledCount = cancelledCount;
            ProcessingCount = processingCount;
            NoBenefitCount = noBenefitCount;
            WarningCount = warningCount;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The number of savings plans in Succeeded state. </summary>
        public float? SucceededCount { get; }
        /// <summary> The number of savings plans in Failed state. </summary>
        public float? FailedCount { get; }
        /// <summary> The number of savings plans in Expiring state. </summary>
        public float? ExpiringCount { get; }
        /// <summary> The number of savings plans in Expired state. </summary>
        public float? ExpiredCount { get; }
        /// <summary> The number of savings plans in Pending state. </summary>
        public float? PendingCount { get; }
        /// <summary> The number of savings plans in Cancelled state. </summary>
        public float? CancelledCount { get; }
        /// <summary> The number of savings plans in Processing state. </summary>
        public float? ProcessingCount { get; }
        /// <summary> The number of savings plans in No Benefit state. </summary>
        public float? NoBenefitCount { get; }
        /// <summary> The number of savings plans in Warning state. </summary>
        public float? WarningCount { get; }
    }
}
