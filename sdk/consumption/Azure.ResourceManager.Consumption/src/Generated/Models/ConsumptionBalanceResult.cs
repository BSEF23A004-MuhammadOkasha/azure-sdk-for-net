// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Consumption.Models
{
    /// <summary> A balance resource. </summary>
    public partial class ConsumptionBalanceResult : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="ConsumptionBalanceResult"/>. </summary>
        internal ConsumptionBalanceResult()
        {
            NewPurchasesDetails = new ChangeTrackingList<ConsumptionBalanceNewPurchasesDetail>();
            AdjustmentDetails = new ChangeTrackingList<ConsumptionBalanceAdjustmentDetail>();
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="ConsumptionBalanceResult"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="currency"> The ISO currency in which the meter is charged, for example, USD. </param>
        /// <param name="beginningBalance"> The beginning balance for the billing period. </param>
        /// <param name="endingBalance"> The ending balance for the billing period (for open periods this will be updated daily). </param>
        /// <param name="newPurchases"> Total new purchase amount. </param>
        /// <param name="adjustments"> Total adjustment amount. </param>
        /// <param name="utilized"> Total Commitment usage. </param>
        /// <param name="serviceOverage"> Overage for Azure services. </param>
        /// <param name="chargesBilledSeparately"> Charges Billed separately. </param>
        /// <param name="totalOverage"> serviceOverage + chargesBilledSeparately. </param>
        /// <param name="totalUsage"> Azure service commitment + total Overage. </param>
        /// <param name="azureMarketplaceServiceCharges"> Total charges for Azure Marketplace. </param>
        /// <param name="billingFrequency"> The billing frequency. </param>
        /// <param name="isPriceHidden"> Price is hidden or not. </param>
        /// <param name="newPurchasesDetails"> List of new purchases. </param>
        /// <param name="adjustmentDetails"> List of Adjustments (Promo credit, SIE credit etc.). </param>
        /// <param name="etag"> The etag for the resource. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConsumptionBalanceResult(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string currency, decimal? beginningBalance, decimal? endingBalance, decimal? newPurchases, decimal? adjustments, decimal? utilized, decimal? serviceOverage, decimal? chargesBilledSeparately, decimal? totalOverage, decimal? totalUsage, decimal? azureMarketplaceServiceCharges, ConsumptionBillingFrequency? billingFrequency, bool? isPriceHidden, IReadOnlyList<ConsumptionBalanceNewPurchasesDetail> newPurchasesDetails, IReadOnlyList<ConsumptionBalanceAdjustmentDetail> adjustmentDetails, ETag? etag, IReadOnlyDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Currency = currency;
            BeginningBalance = beginningBalance;
            EndingBalance = endingBalance;
            NewPurchases = newPurchases;
            Adjustments = adjustments;
            Utilized = utilized;
            ServiceOverage = serviceOverage;
            ChargesBilledSeparately = chargesBilledSeparately;
            TotalOverage = totalOverage;
            TotalUsage = totalUsage;
            AzureMarketplaceServiceCharges = azureMarketplaceServiceCharges;
            BillingFrequency = billingFrequency;
            IsPriceHidden = isPriceHidden;
            NewPurchasesDetails = newPurchasesDetails;
            AdjustmentDetails = adjustmentDetails;
            ETag = etag;
            Tags = tags;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The ISO currency in which the meter is charged, for example, USD. </summary>
        public string Currency { get; }
        /// <summary> The beginning balance for the billing period. </summary>
        public decimal? BeginningBalance { get; }
        /// <summary> The ending balance for the billing period (for open periods this will be updated daily). </summary>
        public decimal? EndingBalance { get; }
        /// <summary> Total new purchase amount. </summary>
        public decimal? NewPurchases { get; }
        /// <summary> Total adjustment amount. </summary>
        public decimal? Adjustments { get; }
        /// <summary> Total Commitment usage. </summary>
        public decimal? Utilized { get; }
        /// <summary> Overage for Azure services. </summary>
        public decimal? ServiceOverage { get; }
        /// <summary> Charges Billed separately. </summary>
        public decimal? ChargesBilledSeparately { get; }
        /// <summary> serviceOverage + chargesBilledSeparately. </summary>
        public decimal? TotalOverage { get; }
        /// <summary> Azure service commitment + total Overage. </summary>
        public decimal? TotalUsage { get; }
        /// <summary> Total charges for Azure Marketplace. </summary>
        public decimal? AzureMarketplaceServiceCharges { get; }
        /// <summary> The billing frequency. </summary>
        public ConsumptionBillingFrequency? BillingFrequency { get; }
        /// <summary> Price is hidden or not. </summary>
        public bool? IsPriceHidden { get; }
        /// <summary> List of new purchases. </summary>
        public IReadOnlyList<ConsumptionBalanceNewPurchasesDetail> NewPurchasesDetails { get; }
        /// <summary> List of Adjustments (Promo credit, SIE credit etc.). </summary>
        public IReadOnlyList<ConsumptionBalanceAdjustmentDetail> AdjustmentDetails { get; }
        /// <summary> The etag for the resource. </summary>
        public ETag? ETag { get; }
        /// <summary> Resource tags. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
    }
}
